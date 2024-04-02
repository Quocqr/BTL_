using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using CrystalDecisions.Shared;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace BTL_CS
{
    public partial class InBaoCaoCTNH : Form
    {
        private string data;
        private FormMain main;
        public InBaoCaoCTNH(string data, FormMain main)
        {
            InitializeComponent();
            this.data = data;
            this.main = main;

        }
        private string sql = ConfigurationManager.ConnectionStrings["db_qlbh"].ConnectionString;
        private void InBaoCaoCTNH_Load(object sender, EventArgs e)
        {
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                using (SqlCommand con = new SqlCommand())
                {
                    con.Connection = cmd;
                    con.CommandType = CommandType.StoredProcedure;
                    con.CommandText = "dulieubaocao";
                    con.Parameters.AddWithValue("@MaNH", data);
                    cmd.Open();
                    using (SqlDataReader reader = con.ExecuteReader())
                    {
                        DataTable tb = new DataTable();
                        tb.Load(reader);
                        ReportDocument rp = new ReportDocument();
                        rp.Load(@"F:\code\BTL_\BTL_CS\BTL_CS\report\BaoCaoCTNH.rpt");
                        rp.SetDataSource(tb);
                        ParameterFieldDefinition pfd = rp.DataDefinition.ParameterFields["MaNHform"];
                        pfd.CurrentValues.Clear();
                        ParameterValues a = new ParameterValues();
                        ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                        pdv.Value = data;
                        a.Add(pdv);
                        pfd.ApplyCurrentValues(a);
                        crystalReportViewer1.ReportSource = rp;
                        crystalReportViewer1.Refresh();
                    }
                }
            }

            //InBaoCaoCTNH inBaoCaoCTNH = new InBaoCaoCTNH();
            /*ReportDocument dr = new ReportDocument();  
            dr.Load(@"F:\code\BTL_\BTL_CS\BTL_CS\report\BaoCaoCTNH.rpt");
            ParameterFieldDefinition pfd = dr.DataDefinition.ParameterFields["MaNH"];
            pfd.CurrentValues.Clear();
            ParameterValues a = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = data;
            a.Add(pdv);
            pfd.ApplyCurrentValues(a);
            crystalReportViewer1.ReportSource = dr;
            crystalReportViewer1.Refresh();*/
        }

    }
}
