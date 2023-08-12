using _02.MarketDesktopApp.Constants;
using System.ComponentModel;
using System.Data.SqlClient;

namespace _02.MarketDesktopApp;

public partial class Form7 : Form
{
    string connectionString = Connection.ConnectionString;
    SqlConnection connection;
    public Form7()
    {
        InitializeComponent();
        connection = new(connectionString);
    }

    private void Form7_Load(object sender, EventArgs e)
    {
        GetAllProduct();
    }

    private void GetAllProduct()
    {
        dgProducts.Rows.Clear();

        connection.Open();
        string query = "Select * From Products Order by Name";
        SqlCommand cmd = new(query, connection);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            dgProducts.Rows.Add();
            int count = dgProducts.RowCount - 1;

            dgProducts.Rows[count].Cells["Count"].Value = count + 1;
            dgProducts.Rows[count].Cells["PName"].Value = reader["Name"];
            dgProducts.Rows[count].Cells["Price"].Value = reader["Price"];
        }
        connection.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        decimal price = Convert.ToDecimal(txtPrice.Text);

        connection.Open();
        string query = "Insert into Products Values(@Name,@Price)";
        SqlCommand cmd = new(query, connection);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Price", price);
        cmd.ExecuteNonQuery();

        connection.Close();

        MessageBox.Show("Product save is successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtName.Text = "";
        txtPrice.Text = "0";
        txtName.Focus();
    }    

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string value = tabControl1.SelectedTab.Text;
        if(value == "Products")
        {
            GetAllProduct();
        }
    }
}
