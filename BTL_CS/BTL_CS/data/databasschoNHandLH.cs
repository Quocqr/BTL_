using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;
using System.Configuration;
namespace BTL_CS
{
    internal class databasschoNHandLH
    {
        private string sql = ConfigurationManager.ConnectionStrings["db_qlbh"].ConnectionString;
        // lay du lieu cho datagridview thong qua su kien load form 
        public DataTable laydulieu()
        {
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                using (SqlCommand drd = new SqlCommand("SELECT * FROM vwNhapHang;", cmd))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(drd))
                    {
                        drd.CommandType = CommandType.Text;
                        using (DataTable tb = new DataTable("tblnhaphang"))
                        {
                            da.Fill(tb);
                            return tb;
                        }
                    }
                }
            }
        }
        //xoa mot phan tu trong nhap hang 
        public void deletetblNhapHang(string MaNH)
        {
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                cmd.Open();
                using (SqlCommand drd = new SqlCommand("DELETE FROM tblNhapHang WHERE MaNH = @MaNH", cmd))
                {
                    drd.CommandType = CommandType.Text;
                    drd.Parameters.AddWithValue("@MaNH", MaNH);
                    drd.ExecuteNonQuery();
                    cmd.Close();
                }
            }
        }
        //them du lieu cho nhap hang  
        public void themdulieu(string a, string b, string c)
        {
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                using (SqlCommand drd = new SqlCommand("sp_InsertNhapHang", cmd))
                {
                    drd.CommandType = CommandType.StoredProcedure;
                    drd.Parameters.AddWithValue("@MaNH", a);
                    drd.Parameters.AddWithValue("@NgayNhap", c);
                    drd.Parameters.AddWithValue("@MaNV", b);

                    // Mở kết nối
                    cmd.Open();

                    // Thực hiện câu lệnh SQL
                    drd.ExecuteNonQuery();

                    // Đóng kết nối
                    cmd.Close();
                }
            }
        }
        //tim kiem du lieu nhap hang 
        public DataTable searchNhapNH(string MaNH, string MaNV, string Ngaynhap, bool a)
        {
            if (a == false)
            {
                object NgayNhap = DBNull.Value;
            }
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                using (SqlCommand drd = new SqlCommand("searchnhaphang", cmd))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(drd))
                    {
                        using (DataTable tb = new DataTable("seachSV"))
                        {
                            cmd.Open();
                            // drd.CommandType = CommandType.Text;

                            drd.CommandType = CommandType.StoredProcedure;
                            drd.Parameters.AddWithValue("@MaNH", string.IsNullOrEmpty(MaNH) ? (object)DBNull.Value : MaNH);
                            drd.Parameters.AddWithValue("@MaNV", string.IsNullOrEmpty(MaNV) ? (object)DBNull.Value : MaNV);
                            // drd.Parameters.AddWithValue("@NgayNhap", Ngaynhap);
                            DateTime temp;
                            if (DateTime.TryParseExact(Ngaynhap, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out temp))
                            {

                                if (a == false)
                                {
                                    drd.Parameters.AddWithValue("@NgayNhap", DBNull.Value);
                                }
                                else
                                    drd.Parameters.AddWithValue("@NgayNhap", temp);
                            }
                            else
                            {
                                drd.Parameters.AddWithValue("@NgayNhap", DBNull.Value);
                            }
                            drd.ExecuteNonQuery();
                            da.Fill(tb);
                            cmd.Close();
                            return tb;
                        }

                    }

                }
            }
        }
        // sua nhap hang 
        public void updatenhaphang(string MaNH, string Ngaynhap, string MaNV)
        {
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                using (SqlCommand drd = new SqlCommand("UpdateTblNhapHang", cmd))
                {
                    cmd.Open();
                    drd.CommandType = CommandType.StoredProcedure;
                    drd.Parameters.AddWithValue("@MaNH", MaNH);
                    drd.Parameters.AddWithValue("Ngaynhap", Ngaynhap);
                    drd.Parameters.AddWithValue("@MaNV", MaNV);
                    drd.ExecuteNonQuery();
                }
                cmd.Close();
            }
        }
        //tim kiem checkbox nhap hang 
        public DataTable seachtheochekbox(string TongGiaTriNhapHang1, string TongGiaTriNhapHang2, string NgayNhap1, string NgayNhap2, bool a, bool b)
        {
            object kq = DBNull.Value;
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                cmd.Open();
                using (SqlCommand drd = new SqlCommand("searchnhaphangcheckbox", cmd))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(drd))
                    {
                        using (DataTable tb = new DataTable("seachSV"))
                        {
                            drd.CommandType = CommandType.StoredProcedure;
                            if (a == true && b == false)
                            {
                                drd.Parameters.AddWithValue("@TongGiaTriNhapHang1", string.IsNullOrEmpty(TongGiaTriNhapHang1) ? (object)DBNull.Value : float.Parse(TongGiaTriNhapHang1));
                                drd.Parameters.AddWithValue("@TongGiaTriNhapHang2", string.IsNullOrEmpty(TongGiaTriNhapHang2) ? (object)DBNull.Value : float.Parse(TongGiaTriNhapHang2));
                                drd.Parameters.AddWithValue("@NgayNhap1", kq);
                                drd.Parameters.AddWithValue("@NgayNhap2", kq);
                                da.Fill(tb);
                                return tb;
                            }
                            if (a == false && b == true)
                            {
                                drd.Parameters.AddWithValue("@TongGiaTriNhapHang1", kq);
                                drd.Parameters.AddWithValue("@TongGiaTriNhapHang2", kq);
                                drd.Parameters.AddWithValue("@NgayNhap1", string.IsNullOrEmpty(NgayNhap1) ? (object)DBNull.Value : NgayNhap1);
                                drd.Parameters.AddWithValue("@NgayNhap2", string.IsNullOrEmpty(NgayNhap2) ? (object)DBNull.Value : NgayNhap2);
                                da.Fill(tb);
                                return tb;
                            }
                            if (a == true && b == true)
                            {
                                drd.Parameters.AddWithValue("@TongGiaTriNhapHang1", string.IsNullOrEmpty(TongGiaTriNhapHang1) ? (object)DBNull.Value : float.Parse(TongGiaTriNhapHang1));
                                drd.Parameters.AddWithValue("@TongGiaTriNhapHang2", string.IsNullOrEmpty(TongGiaTriNhapHang2) ? (object)DBNull.Value : float.Parse(TongGiaTriNhapHang2));
                                drd.Parameters.AddWithValue("@NgayNhap1", string.IsNullOrEmpty(NgayNhap1) ? (object)DBNull.Value : NgayNhap1);
                                drd.Parameters.AddWithValue("@NgayNhap2", string.IsNullOrEmpty(NgayNhap2) ? (object)DBNull.Value : NgayNhap2);
                                da.Fill(tb);
                                return tb;
                            }
                        }
                    }

                }
            }

            return laydulieu();

        }
                                              //                chi tiêt nhập hàng              ////
        //ham chung cho PROCEDURE viewCTnhaphang---------------------------------------------------------
        public DataTable viewCTnhaphang(SqlConnection cmd, string MaNH, string MaSP, string TenSP, string SoLuong, string GiaNhap)
        {
            object kq = DBNull.Value;
            using (SqlCommand drd = new SqlCommand("viewCTnhaphang", cmd))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(drd))
                {
                    drd.CommandType = CommandType.StoredProcedure;
                    drd.Parameters.AddWithValue("@MaNH", string.IsNullOrEmpty(MaNH) ? (object)DBNull.Value : MaNH);
                    drd.Parameters.AddWithValue("@MaSP", string.IsNullOrEmpty(MaSP) ? (object)DBNull.Value : MaSP);
                    drd.Parameters.AddWithValue("@TenSP", string.IsNullOrEmpty(TenSP) ? (object)DBNull.Value : TenSP);
                    drd.Parameters.AddWithValue("@SoLuong", string.IsNullOrEmpty(SoLuong) ? (object)DBNull.Value : float.Parse(SoLuong));
                    drd.Parameters.AddWithValue("@GiaNhap", string.IsNullOrEmpty(GiaNhap) ? (object)DBNull.Value : float.Parse(GiaNhap));


                    using (DataTable tb = new DataTable("tblnhaphang"))
                    {
                        da.Fill(tb);
                        return tb;
                    }
                }
            }
        }

        //xuat du lieu---------------------------------------------------------
        public DataTable laydulieuCTNH(string MaNH)
        {
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                string a = string.Empty;
                return viewCTnhaphang(cmd, MaNH, a, a, a, a);
            }
        }
        //lay ten san pham -------------------------------------------------
        public DataTable tensanpham(string MaSP)
        {
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                using(SqlCommand cmd2 = new SqlCommand("TENSP",cmd))
                {
                    cmd.Open();
                    using(SqlDataAdapter drd =new SqlDataAdapter(cmd2))
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@MaSP", string.IsNullOrEmpty(MaSP) ? (object)DBNull.Value : MaSP);
                        using (DataTable tb = new DataTable("tbltenhang"))
                        {
                            drd.Fill(tb);
                            cmd.Close();
                            return tb;
                        }
                    }
                }
            }

        }
        //them-----------------------------------------------------------------------------------------//
        public void themctnhaphang(string masp ,string maNH,string soluong,string gianhap )
        {
           using(SqlConnection cmd= new SqlConnection(sql))
            {
                cmd.Open();
                using(SqlCommand drd=new SqlCommand("INSERT INTO tblChiTietNhapHang (MaSP, MaNH, SoLuong, GiaNhap,ThanhTien) VALUES(@MaSP, @MaNH, @SoLuong,@GiaNhap, 0); ", cmd))
                {
                    drd.CommandType = CommandType.Text;
                    drd.Parameters.AddWithValue("@MaSP", masp);
                    drd.Parameters.AddWithValue("@MaNH", maNH);
                    drd.Parameters.AddWithValue("@SoLuong", soluong);
                    drd.Parameters.AddWithValue("@GiaNhap", gianhap);
                    drd.ExecuteNonQuery();
                }
            }
        }
        // sua lai chi tiet nhap hang ------------------------------------------------
        public void SuaCTnhaphang(string masp, string maNH, string soluong, string gianhap)
        {
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                cmd.Open();
                using (SqlCommand drd = new SqlCommand("UpdatetblChiTietNhapHang ", cmd))
                {
                    drd.CommandType = CommandType.StoredProcedure;
                    drd.Parameters.AddWithValue("@MaSP", string.IsNullOrEmpty(masp) ? (object)DBNull.Value : masp);
                    drd.Parameters.AddWithValue("@MaNH", string.IsNullOrEmpty(maNH) ? (object)DBNull.Value : maNH);
                    drd.Parameters.AddWithValue("@SoLuong", string.IsNullOrEmpty(soluong) ? (object)DBNull.Value : soluong);
                    drd.Parameters.AddWithValue("@GiaNhap", string.IsNullOrEmpty(gianhap) ? (object)DBNull.Value : gianhap);
                    drd.ExecuteNonQuery();
                }
                cmd.Close();
            }
        }
        // xoa ----------------------------------------------
        public void DeleteCTnhaphang(string masp, string maNH)
        {
            using(SqlConnection cmd = new SqlConnection(sql))
            {
                cmd.Open();
                using (SqlCommand drd = new SqlCommand("DELETE FROM tblChiTietNhapHang WHERE MaNH=@MaNH AND MaSP=@MaSP; ", cmd))
                {
                    drd.CommandType = CommandType.Text;
                    drd.Parameters.AddWithValue("@MaNH",  maNH);
                    drd.Parameters.AddWithValue("@MaSP", masp);
                    drd.ExecuteNonQuery();

                }
                cmd.Close();
            }
        }
        //tim kiem chi tiet don hang 
        public DataTable seachCTnhaphang(string masp, string maNH, string tensp,bool a,bool b )
        {
            string kp = string.Empty;
            using (SqlConnection cmd = new SqlConnection(sql))
            {
                if (a == true && b == false)
                {
                  return viewCTnhaphang(cmd, maNH, masp, kp, kp, kp);
                }
                if(a==false && b == true)
                {
                  return  viewCTnhaphang(cmd, maNH, kp, tensp, kp, kp);
                }
            }
                return laydulieuCTNH(maNH);
        }
    }
}
