using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CS
{
    public partial class chitietnhaphang : Form
    {
        private string data;
        public chitietnhaphang(string data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void chitietnhaphang_Load(object sender, EventArgs e)
        {
            databasschoNHandLH databasschoNHandLH = new databasschoNHandLH();
            DataTable dataTable = new DataTable();
            dataTable=databasschoNHandLH.laydulieuCTNH(data);
            dataGridView1.DataSource = dataTable;
            textBox1.Text = data;

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            databasschoNHandLH databasschoNHandLH = new databasschoNHandLH();
            DataTable dataTable = new DataTable();
            dataTable = databasschoNHandLH.tensanpham(masanpham.Text.ToString());
            if (dataTable.Rows.Count > 0)
            {
                textBox3.Text = dataTable.Rows[0]["TenSP"].ToString();
            }
            else
            {
                textBox3.Text = "Không tìm thấy sản phẩm";
            }

        }
    }
}
