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
    public partial class Bai_7 : Form
    {
        public Bai_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
            }

            string[] parts = input.Split(',');

            if (parts.Length < 2)
            {
                MessageBox.Show("Nhập sai format!");
                return;
            }

            string studentName = parts[0].Trim();

            double[] scores = new double[parts.Length - 1];
            for (int i = 1; i < parts.Length; i++)
            {
                if (!double.TryParse(parts[i].Trim(), out scores[i - 1]))
                {
                    MessageBox.Show("Sai format ở vị trí " + (i));
                    return;
                }
            }

            string result = "";
            result = "Họ và tên: " + studentName + Environment.NewLine;
            result += "Danh sách điểm: " + Environment.NewLine;

            for (int i =0; i < scores.Length; i++) 
            {
                result += $"Môn{i + 1} : {scores[i]}  ";
            }
            result += Environment.NewLine;

            double avg = scores.Average();
            double max = scores.Max();
            double min = scores.Min();
            int pass = scores.Count(s => s >= 5);
            int fail = scores.Count(s => s < 5);

            result += $"Điểm trung bình: {avg:F2}" + Environment.NewLine;
            result += $"Điểm cao nhất: {max}" + Environment.NewLine;
            result += $"Điểm thấp nhất: {min}" + Environment.NewLine;
            result += $"Số môn thi đỗ: {pass}" + Environment.NewLine;
            result += $"Số môn thi trượt: {fail}" + Environment.NewLine;

            string rank = "";
            if (avg >= 8 && scores.All(x => x >= 6.5))
                rank = "Giỏi";
            else if (avg >= 6.5 && scores.All(x => x >= 5))
                rank = "Khá";
            else if (avg >= 5 && scores.All(x => x >= 3.5))
                rank = "TB";
            else if (avg >= 3.5 && scores.All(x => x >= 2))
                rank = "Yếu";
            else
                rank = "Kém";

            result += $"Xếp loại: {rank}";
            

            textBox2.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
