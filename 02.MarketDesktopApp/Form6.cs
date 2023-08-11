using _02.MarketDesktopApp.Constants;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _02.MarketDesktopApp;

public partial class Form6 : Form
{
    string connectionString = Connection.ConnectionString;
    SqlConnection connection;
    public Form6()
    {
        InitializeComponent();
        connection = new(connectionString);
    }

    private void Form6_Load(object sender, EventArgs e)
    {
        GetReceipts();
    }

    private void GetReceipts()
    {
        connection.Open();
        SqlCommand cmd = new("SELECT * FROM Receipts Order By Date Desc", connection);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            dgReceipts.Rows.Add();
            int rowCount = dgReceipts.Rows.Count - 1;

            dgReceipts.Rows[rowCount].Cells["Count"].Value = rowCount + 1;
            dgReceipts.Rows[rowCount].Cells["ReceiptNumber"].Value = reader["ReceiptNumber"];
            dgReceipts.Rows[rowCount].Cells["Date"].Value = reader["Date"];
            dgReceipts.Rows[rowCount].Cells["Total"].Value = reader["Total"];
            dgReceipts.Rows[rowCount].Cells["Payment"].Value = reader["Payment"];
            dgReceipts.Rows[rowCount].Cells["Remaining"].Value = reader["Remaining"];
        }

        connection.Close();
    }

    private void dgReceipts_Click(object sender, EventArgs e)
    {
        dgReceiptDetails.Rows.Clear();

        DataGridViewRow row = dgReceipts.CurrentRow;
        if (row != null && !row.IsNewRow)
        {
            object value = row.Cells["ReceiptNumber"].Value;
            string receiptNumber = value?.ToString();

            connection.Open();
            SqlCommand receiptCmd = new("Select * from Receipts where ReceiptNumber=@ReceiptNumber", connection);
            receiptCmd.Parameters.AddWithValue("@ReceiptNumber", receiptNumber);
            SqlDataReader receiptReader = receiptCmd.ExecuteReader();
            if (receiptReader.Read())
            {
                int receiptId = (int)receiptReader["Id"];

                receiptReader.Close();

                SqlCommand receiptDetailsCmd = new("select p.Name as Name, rd.Quantity as Quantity, rd.Price as Price, rd.Total as Total from ReceiptDetails as rd Left Join Products as p on rd.ProductId = p.Id where ReceiptId =@ReceiptId", connection);
                receiptDetailsCmd.Parameters.AddWithValue("@ReceiptId", receiptId);

                SqlDataReader receiptDetailReader = receiptDetailsCmd.ExecuteReader();
                if (receiptDetailReader.Read())
                {
                    while (receiptDetailReader.Read())
                    {
                        dgReceiptDetails.Rows.Add();
                        int dgRDCount = dgReceiptDetails.Rows.Count - 1;

                        dgReceiptDetails.Rows[dgRDCount].Cells["RDCount"].Value = dgRDCount + 1;
                        dgReceiptDetails.Rows[dgRDCount].Cells["RDProductName"].Value = receiptDetailReader["Name"];
                        dgReceiptDetails.Rows[dgRDCount].Cells["RDQuantity"].Value = receiptDetailReader["Quantity"];
                        dgReceiptDetails.Rows[dgRDCount].Cells["RDPrice"].Value = receiptDetailReader["Price"];
                        dgReceiptDetails.Rows[dgRDCount].Cells["RDTotal"].Value = receiptDetailReader["Total"];
                    }

                    receiptDetailReader.Close();
                }

            }

            dgReceiptDetails.ClearSelection();

            connection.Close();
        }        
    }
}
