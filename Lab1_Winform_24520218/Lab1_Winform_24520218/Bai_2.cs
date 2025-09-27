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
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text.Trim(),out double so1))
            {
                MessageBox.Show("Số thứ nhất không hợp lệ");
                textBox1.Focus();
                return;
            }
            if (!double.TryParse(textBox2.Text.Trim(), out double so2))
            {
                MessageBox.Show("Số thứ hai không hợp lệ");
                textBox2.Focus();
                return;
            }
            if (!double.TryParse(textBox3.Text.Trim(), out double so3))
            {
                MessageBox.Show("Số thứ ba không hợp lệ");
                textBox3.Focus();
                return;
            }

            double min = Math.Min(so1, Math.Min(so2, so3));
            double max = Math.Max(so1, Math.Max(so2, so3));

            textBoxmax.Text = max.ToString();
            textBoxmin.Text = min.ToString();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBoxmax.Clear();
            textBoxmin.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
