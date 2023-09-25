using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Packing
{
    internal class ThaoTac
    {
        //Đổi tiêu đề cột trong dgv
        public static void DoiTenCot(DataGridView dgv, List<string> listTenCot, List<string> newHeader)
        {
            for (int i = 0; i < listTenCot.Count; i++)
            {
                dgv.Columns[listTenCot[i].ToString()].HeaderText = newHeader[i].ToString();
            }
        }
        //Load ảnh từ link
        public static void LoadImageFromURL(PictureBox pic, string imageURL)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(imageURL); // Tải dữ liệu hình ảnh từ URL
                    using (MemoryStream stream = new MemoryStream(data))
                    {
                        Image image = Image.FromStream(stream); // Tạo đối tượng hình ảnh từ dữ liệu
                        pic.SizeMode = PictureBoxSizeMode.Zoom; // Đặt chế độ co dãn hình ảnh
                        pic.Image = image; // Gán hình ảnh cho PictureBox
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        //Điều chỉnh độ rộng cột trong dgv
        public static void DieuChinhDoRongCot(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Đặt auto size cho tất cả các cột
            }
        }
        //Bỏ dòng trống cuối cùng của dgb
    }
}
