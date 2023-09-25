using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packing
{
    internal class TruyVanSQL
    {
        private static string DuongDan = Properties.Settings.Default.connectString + ";Persist Security Info = True; User ID = sa; Password=Tanhatminh@123";
        public static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(DuongDan);
        }

        public static DataTable TaoBang(string Sqlcm)   //Truy vấn SELECT và trả kết quả là 1 bảng data
        {
            SqlConnection ketnoi = TaoKetNoi();
            ketnoi.Open();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = Sqlcm;
            cm.Connection = ketnoi;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ketnoi.Close();
            return dt;


        }
        // Truy vấn ( Thêm, Sửa , Xóa) đối với SQL
        public static void ThemSuaXoa(SqlCommand Lenh)
        {
            SqlConnection Ketnoi = TaoKetNoi();
            Ketnoi.Open();
            Lenh.Connection = Ketnoi;
            Lenh.ExecuteNonQuery();
            Ketnoi.Close();
        }
        //Kiểm tra đơn hàng theo mã vận đơn
        public static void KiemTraVanDon(DataGridView dgv,string mavandon)
        {
            dgv.DataSource = TaoBang($"SELECT donggoi.vandon,donggoi.mahang,mathang.tenhang,donggoi.bienthe,donggoi.soluong,bienthe.linkanh " +
                $"FROM donggoi " +
                $"LEFT JOIN mathang ON donggoi.mahang=mathang.mahang " +
                $"LEFT JOIN bienthe ON donggoi.bienthe=bienthe.bienthe AND donggoi.mahang=bienthe.mahang " +
                $"WHERE donggoi.vandon='{mavandon}'");
            List<string> tencot = new List<string> { "vandon", "mahang", "tenhang", "bienthe", "soluong","linkanh" };
            List<string> newHeader = new List<string> { "Vận Đơn", "SKU", "Tên", "Biến Thể", "Số lượng","Link Ảnh" };
            ThaoTac.DoiTenCot(dgv, tencot, newHeader);
            ThaoTac.DieuChinhDoRongCot(dgv);
        }
    }
}
