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
    public partial class Bai_5 : Form
    {
        public Bai_5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text.Trim(), out int a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên cho A.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox2.Text.Trim(), out int b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên cho B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
                return;
            }

            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn trong ô.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

            var sb = new StringBuilder();

            string func = comboBox1.SelectedItem as string;
            if (func == "Bảng cửu chương")
            {
                sb.AppendLine($"A - B = {a - b}");
                textBox3.Text = sb.ToString();
            }
            else
            {
                int diff = a - b;
                if (diff < 0)
                {
                    MessageBox.Show("A phải lớn hơn hoặc bằng B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long  fact = 1;
                for (int i = 1; i <= diff; i++)
                {
                    fact *= i;
                }
                sb.AppendLine($"(A-B)! = {diff}! = {fact}");

                long S = 0;
                for (int i = 1; i <= b; i++)
                {
                    S += (long)Math.Pow(a, i);
                }
                sb.AppendLine($"S = A^1 + A^2 + ... + A^B = {S}");
                textBox3.Text = sb.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
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
