using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CS
{
    public partial class FormMain : Form
    {
        private string constr = ConfigurationManager.ConnectionStrings["db_qlbh"].ConnectionString;
        public FormMain()
        {
            InitializeComponent();
        }
        public string abc;

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSNhapHang f1 = new DSNhapHang(this);
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
