namespace _02.MarketDesktopApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtBarcode = new TextBox();
            groupBox2 = new GroupBox();
            dgList = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            lbTotal = new Label();
            gbPayment = new GroupBox();
            btnCash = new Button();
            btnKK = new Button();
            txtPayment = new TextBox();
            groupBox5 = new GroupBox();
            btnComplete = new Button();
            btnReset = new Button();
            lbRemaing = new Label();
            groupBox6 = new GroupBox();
            dgPayment = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            groupBox3.SuspendLayout();
            gbPayment.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Times New Roman", 54.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarcode.Location = new Point(6, 20);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(808, 91);
            txtBarcode.TabIndex = 0;
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgList);
            groupBox2.Location = new Point(12, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(826, 630);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.BackgroundColor = SystemColors.ButtonFace;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { Count, Name, Quantity, Price, TotalPrice });
            dgList.Location = new Point(10, 19);
            dgList.Name = "dgList";
            dgList.RowHeadersVisible = false;
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(804, 605);
            dgList.TabIndex = 0;
            // 
            // Count
            // 
            Count.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Count.HeaderText = "#";
            Count.Name = "Count";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.Width = 400;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 150;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Location = new Point(858, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(491, 121);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // lbTotal
            // 
            lbTotal.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.Brown;
            lbTotal.Location = new Point(8, 21);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(477, 90);
            lbTotal.TabIndex = 0;
            lbTotal.Text = "0,00 ₺";
            lbTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbPayment
            // 
            gbPayment.Controls.Add(btnCash);
            gbPayment.Controls.Add(btnKK);
            gbPayment.Controls.Add(txtPayment);
            gbPayment.Location = new Point(858, 155);
            gbPayment.Name = "gbPayment";
            gbPayment.Size = new Size(491, 193);
            gbPayment.TabIndex = 3;
            gbPayment.TabStop = false;
            // 
            // btnCash
            // 
            btnCash.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnCash.Image = Properties.Resources.cash;
            btnCash.Location = new Point(247, 97);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(238, 88);
            btnCash.TabIndex = 2;
            btnCash.UseVisualStyleBackColor = true;
            btnCash.Click += btnCash_Click;
            // 
            // btnKK
            // 
            btnKK.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnKK.Image = Properties.Resources.creditcart;
            btnKK.Location = new Point(8, 97);
            btnKK.Name = "btnKK";
            btnKK.Size = new Size(238, 88);
            btnKK.TabIndex = 1;
            btnKK.UseVisualStyleBackColor = true;
            btnKK.Click += btnKK_Click;
            // 
            // txtPayment
            // 
            txtPayment.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            txtPayment.ForeColor = Color.Teal;
            txtPayment.Location = new Point(8, 28);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(479, 63);
            txtPayment.TabIndex = 0;
            txtPayment.Text = "0";
            txtPayment.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnComplete);
            groupBox5.Controls.Add(btnReset);
            groupBox5.Controls.Add(lbRemaing);
            groupBox5.Location = new Point(858, 547);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(491, 222);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            // 
            // btnComplete
            // 
            btnComplete.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnComplete.Image = Properties.Resources.complete;
            btnComplete.Location = new Point(250, 121);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(238, 90);
            btnComplete.TabIndex = 4;
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.Brown;
            btnReset.Image = Properties.Resources.reset;
            btnReset.Location = new Point(6, 121);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(238, 90);
            btnReset.TabIndex = 3;
            btnReset.UseVisualStyleBackColor = true;
            // 
            // lbRemaing
            // 
            lbRemaing.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lbRemaing.ForeColor = Color.Brown;
            lbRemaing.Location = new Point(8, 28);
            lbRemaing.Name = "lbRemaing";
            lbRemaing.Size = new Size(477, 90);
            lbRemaing.TabIndex = 1;
            lbRemaing.Text = "0,00 ₺";
            lbRemaing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgPayment);
            groupBox6.Location = new Point(860, 357);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(489, 184);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.BackgroundColor = SystemColors.ButtonFace;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { Type, Total });
            dgPayment.Location = new Point(6, 21);
            dgPayment.Name = "dgPayment";
            dgPayment.RowHeadersVisible = false;
            dgPayment.RowTemplate.Height = 25;
            dgPayment.Size = new Size(477, 157);
            dgPayment.TabIndex = 1;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 779);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(gbPayment);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);            
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            groupBox3.ResumeLayout(false);
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox gbPayment;
        private TextBox txtBarcode;
        private DataGridView dgList;
        private GroupBox groupBox5;
        private Label lbTotal;
        private TextBox txtPayment;
        private Button btnCash;
        private Button btnKK;
        private Button btnComplete;
        private Button btnReset;
        private Label lbRemaing;
        private GroupBox groupBox6;
        private DataGridView dgPayment;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}