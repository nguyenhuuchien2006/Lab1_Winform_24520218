using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Winform_24520218
{
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private Dictionary<string, (int GiaVe, List<int> PhongChieu)> dsPhim = new Dictionary<string, (int, List<int>)>()
        {
            { "Đào, phở và piano", (45000, new List<int>{1,2,3}) },
            { "Mai", (100000, new List<int>{2,3}) },
            { "Gặp lại chị bầu", (70000, new List<int>{1}) },
            { "Tarot", (90000, new List<int>{3}) }
        };

        private Dictionary<string, string> loaiGhe = new Dictionary<string, string>()
        {
            {"A1","Vớt"},{"A5","Vớt"},{"C1","Vớt"},{"C5","Vớt"},
            {"A2","Thường"},{"A3","Thường"},{"A4","Thường"},
            {"C2","Thường"},{"C3","Thường"},{"C4","Thường"},
            {"B2","VIP"},{"B3","VIP"},{"B4","VIP"}
        };

        private Dictionary<(int, string), bool> gheDaMua = new Dictionary<(int, string), bool>();
        private void button1_Click(object sender, EventArgs e)
        {
            string tenKhachHang = textBox1.Text;
            string soDT = textBox2.Text;
            string tenPhim = comboBox1.SelectedItem?.ToString();
            int phongChieu = comboBox2.SelectedItem != null ? int.Parse(comboBox2.SelectedItem.ToString()) : -1;
            if (string.IsNullOrEmpty(tenKhachHang) || string.IsNullOrEmpty(soDT) || string.IsNullOrEmpty(tenPhim) || phongChieu == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            var ghechon = flowLayoutPanel1.Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text).ToList();

            if (ghechon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế.");
                return;
            }

            if(ghechon.Count>1)
            {
                MessageBox.Show("Mỗi khách hàng chỉ được mua tối đa 1 vé.");
                return;
            }    

            if(!dsPhim.ContainsKey(tenPhim) || !dsPhim[tenPhim].PhongChieu.Contains(phongChieu))
            {
                MessageBox.Show("Phim không chiếu ở phòng này.");
                return;
            }

            int giaVe = dsPhim[tenPhim].GiaVe;
            int tongTien = giaVe * ghechon.Count;
            string gheDaChon = string.Join(", ", ghechon);
            string loaiGheChon = string.Join(", ", ghechon.Select(ghe => loaiGhe.ContainsKey(ghe) ? loaiGhe[ghe] : "Không xác định"));
            string thongTinVe = $"Khách hàng: {tenKhachHang}" + Environment.NewLine +
                               $"Số điện thoại: {soDT}" + Environment.NewLine +
                               $"Phim: {tenPhim}" + Environment.NewLine +
                               $"Phòng chiếu: {phongChieu}" + Environment.NewLine +
                               $"Ghế đã chọn: {gheDaChon}" + Environment.NewLine +
                               $"Loại ghế: {loaiGheChon}" + Environment.NewLine +
                               $"Tổng tiền: {tongTien} VND";
            textBox3.Text = thongTinVe;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            foreach (CheckBox cb in flowLayoutPanel1.Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
                cb.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
