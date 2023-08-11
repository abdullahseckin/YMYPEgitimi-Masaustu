using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.MarketDesktopApp
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Height = 510;
            dataGridView1.Location = new Point(dataGridView1.Location.X, 168);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Height = 640;
            dataGridView1.Location = new Point(dataGridView1.Location.X, 38);
        }
    }
}
