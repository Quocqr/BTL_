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
        databasschoNHandLH db = new databasschoNHandLH();

        private void chitietnhaphang_Load(object sender, EventArgs e)
        {
            
            DataTable dataTable = new DataTable();
            dataTable= db.laydulieuCTNH(data);
            dataGridView1.DataSource = dataTable;
            textBox1.Text = data;

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            

        }
        //xu ly lay ten san pham khi nhap ma san pham ------------------------------------
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = db.tensanpham(masanpham.Text.ToString());
            if (dataTable.Rows.Count > 0)
            {
                textBox3.Text = dataTable.Rows[0]["TenSP"].ToString();
            }
            else
            {
                textBox3.Text = "Không tìm thấy sản phẩm";
            }

        }
            // xu ly thanh tien ngay tren app--------------------------------------------
        private void gianhaptb_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(soluongNUD.Value.ToString()) && !string.IsNullOrEmpty(gianhaptb.Text))
            {
                // Tính toán kết quả và gán vào TextBox3
                int  value1, value2;
                if (int.TryParse(soluongNUD.Value.ToString(), out value1) && int.TryParse(gianhaptb.Text, out value2))
                {
                    thanhtientb.Text = (value1 * value2).ToString();
                }
            }
        }
        // them ----------------------------------------------------------------------
        private void themctnh_Click(object sender, EventArgs e)
        {
            db.themctnhaphang(masanpham.Text, data, soluongNUD.Value.ToString(), gianhaptb.Text);
            dataGridView1.DataSource = db.laydulieuCTNH(data);
        }
        // sua lai chi tiet nhap hang ------------------------------------------------
        private void suactnh_Click(object sender, EventArgs e)
        {
            db.SuaCTnhaphang(masanpham.Text, data, soluongNUD.Value.ToString(), gianhaptb.Text);
            dataGridView1.DataSource = db.laydulieuCTNH(data);

        }

        private void xoactnh_Click(object sender, EventArgs e)
        {
            db.DeleteCTnhaphang(masanpham.Text, data);
            dataGridView1.DataSource = db.laydulieuCTNH(data);
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seachct_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = db.seachCTnhaphang(otimkiem.Text,data,otimkiem.Text,checkBox1.Checked,checkBox2.Checked);
            dataGridView1.DataSource = tb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InBaoCaoCTNH from = new InBaoCaoCTNH(data);
            from.Show();
        }
    }
}
