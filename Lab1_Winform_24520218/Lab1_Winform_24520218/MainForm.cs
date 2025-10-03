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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai_1 bai1 = new Bai_1();
            bai1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai_2 bai2 = new Bai_2();
            bai2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai_3 bai3 = new Bai_3();   
            bai3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai_4 bai4 = new Bai_4();
            bai4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai_5 bai5 = new Bai_5();   
            bai5.Show();    
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai_6 bai6 =new Bai_6();    
            bai6.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bai_7 bai7 = new Bai_7();
            bai7.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bai_8 bai8 = new Bai_8();
            bai8.Show();
            this.Hide();
        }
    }
}
