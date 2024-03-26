using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_CS
{
    public partial class DSNhapHang : Form
    {
        public DSNhapHang()
        {
            InitializeComponent();
        }
        public string data { get; set; }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //tim kiem nhap hamg 
        private void button3_Click(object sender, EventArgs e)
        {
            
                databasschoNHandLH dk = new databasschoNHandLH();
                DataTable dt = new DataTable();
                dt = dk.searchNhapNH(maNHtextbox.Text, manvtextbox.Text.ToString(), ngaynhaptime.Value.ToString("dd/MM/yyyy"), CBngaynhap.Checked);
                dataGridView1.DataSource = dt;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        //tim kiem checkbox 
        private void button6_Click(object sender, EventArgs e)
        {
            databasschoNHandLH dk=new databasschoNHandLH();
            DataTable dt = new DataTable();
            dt = dk.seachtheochekbox(seachgiatri1.Text.ToString(),seachgiatri2.Text.ToString(),dateTimeseach1.Value.ToString("yyyy-MM-dd"),dateTimeseach2.Value.ToString("yyyy-MM-dd"),CBseach1.Checked,CBseach2.Checked);
            dataGridView1.DataSource = dt;
        }
        // du lieu dua vao khi load form 
        private void DSNhapHang_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
             databasschoNHandLH bt=new databasschoNHandLH();
            dt = bt.laydulieu();
            dataGridView1.DataSource = dt;
        }
        // xoa mot du lieu nhap hang 
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string masv = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                databasschoNHandLH bt = new databasschoNHandLH();
                bt.deletetblNhapHang(masv);
                DataTable dt = new DataTable();
                dt = bt.laydulieu();
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa");
            }
        }
        // THEM NHAP HANG 
        private void button1_Click(object sender, EventArgs e)
        {
            databasschoNHandLH dk=new databasschoNHandLH(); 
            dk.themdulieu(maNHtextbox.Text.ToString(),manvtextbox.Text.ToString(),ngaynhaptime.Value.ToString("dd/MM/yyyy"));
            dataGridView1.DataSource = dk.laydulieu();
        }
        //sua nhap hang 
        private void button2_Click(object sender, EventArgs e)
        {
            databasschoNHandLH dk =new databasschoNHandLH();
            dk.updatenhaphang(maNHtextbox.Text.ToString(), ngaynhaptime.Value.ToString("yyyy-MM-dd"), manvtextbox.Text.ToString());
            dataGridView1.DataSource = dk.laydulieu();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấp vào nút DataGridViewLinkColumn hay không
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô cụ thể trong hàng, giả sử ô đầu tiên trong hàng chứa dữ liệu bạn cần
                 data = row.Cells["Column1"].Value.ToString();

                // Hiển thị dữ liệu
                MessageBox.Show(data);
            }
            chitietnhaphang chitietnhaphang = new chitietnhaphang(data);
            chitietnhaphang.Show();
        }
        //
    }
 }

