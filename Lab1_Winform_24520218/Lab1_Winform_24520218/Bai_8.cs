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
    public partial class Bai_8 : Form
    {
        public Bai_8()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mon = textBox1.Text;

            if (!string.IsNullOrEmpty(mon))
            {
                listBox1.Items.Add(mon);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) 
            {
                MessageBox.Show("Danh sách món ăn trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random rnd = new Random();
            int index = rnd.Next(listBox1.Items.Count);
            textBox3.Text = listBox1.Items[index].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
