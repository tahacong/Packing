using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Packing
{
    public partial class Form1 : Form
    {
        private SerialPort serial;
        private SerialPort serial2;
        public Form1()
        {
            InitializeComponent();
            serial = new SerialPort("COM3", 9600);
            serial2 = new SerialPort("COM9", 9600);
            serial.DataReceived += Serial_DataReceived; // Gắn sự kiện DataReceived ở đây
            serial2.DataReceived += Serial2_DataReceived; // Gắn sự kiện DataReceived ở đây
            FormClosing += Form1_FormClosing; // Gắn sự kiện FormClosing ở đây
        }
        private void Serial2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serial.ReadExisting();
                //BeginInvoke(new Action(() => textBox2.Text = data));
                try { serial.Write("\x16M\x0d\x16T\x0d"); }
                catch (Exception) { }
                
            }
            catch (Exception)
            {
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serial.IsOpen)
            {
                serial.Close();
                serial2.Close();
            }
        }
        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serial.ReadExisting();
                BeginInvoke(new Action(() => 
                TruyVanSQL.KiemTraVanDon(dgvVanDon, data)));
            }
            catch (Exception)
            {
            }
        }
        private void Send_trigger()
        {
            try { serial.Write("\x16M\x0d\x16T\x0d"); }
            catch (Exception) { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            serial.Open();
            serial2.Open();
        }
        private void dgvVanDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVanDon.SelectedRows.Count > 0) // Kiểm tra xem có dòng được chọn không
            {
                DataGridViewRow selectedRow = dgvVanDon.SelectedRows[0]; // Lấy dòng đầu tiên trong các dòng được chọn
                // Gán dữ liệu từ các ô trong dòng được chọn vào các TextBox tương ứng
                txtVanDon.Text = selectedRow.Cells["vandon"].Value.ToString();
                txtMaHang_SKU.Text = selectedRow.Cells["mahang"].Value.ToString();
                lblTenHang.Text = selectedRow.Cells[2].Value.ToString();
                lblBienThe.Text = selectedRow.Cells[3].Value.ToString();
                lblSoLuong.Text = selectedRow.Cells[4].Value.ToString();
                lblSoMaHangTrenDon.Text=dgvVanDon.RowCount.ToString();
                //Hiển thị hình ảnh
                picAnhMau.Image = null;
                ThaoTac.LoadImageFromURL(picAnhMau, selectedRow.Cells[5].Value.ToString());
            }
        }
    }
}
