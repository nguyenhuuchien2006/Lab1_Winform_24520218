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
    public partial class Bai_3 : Form
    {
        public Bai_3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxin.Text.Trim(), out int num) || num < 0||num >9)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9.", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxin.Clear();
                textBoxin.Focus();
                return;
            }
            switch(num)
            {
                case 0:
                    textBoxkq.Text = "Không";
                    break;
                case 1:
                    textBoxkq.Text = "Một";
                    break;
                case 2:
                    textBoxkq.Text = "Hai";
                    break;
                case 3:
                    textBoxkq.Text = "Ba";
                    break;
                case 4:
                    textBoxkq.Text = "Bốn";
                    break;
                case 5:
                    textBoxkq.Text = "Năm";
                    break;
                case 6:
                    textBoxkq.Text = "Sáu";
                    break;
                case 7:
                    textBoxkq.Text = "Bảy";
                    break;
                case 8:
                    textBoxkq.Text = "Tám";
                    break;
                case 9:
                    textBoxkq.Text = "Chin";
                    break;
            }   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxin.Clear();
            textBoxkq.Clear();
            textBoxin.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
