using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "小学测试题";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int a, b,i=1;
        string op;
        int result;

        Random rnd = new Random();

     

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = rnd.Next(100) + 1;
            b = rnd.Next(100) + 1;
            int c = rnd.Next(4);
            switch (c)
            {
                case 0: op = "+"; result = a + b; break;
                case 1: op = "-"; result = a - b; break;
                case 2: op = "*"; result = a * b; break;
                case 3: op = "/"; result = a / b; break;
            }
            lblA.Text = a.ToString();
            lblB.Text = b.ToString();
            lblOp.Text = op;
            txtAnswer.Text = "";
            if(i==1)
                this.timer2.Start();
               i++;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string str = txtAnswer.Text;
            string disp = "" + a + op + b + "=" + str + " ";
            string r = "" + result;
            if (str == r) 
                disp += "☆";
            else
                disp += "╳";

            lstDisp.Items.Add(disp);
            if(i==11)
            {
                this.timer1.Stop();
                this.timer2.Stop();
                MessageBox.Show("测试结束");

            }
        }

        private void btnJudge_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("本次测试采取自动判分，一共十题100以内的算术题，每题间隔5秒");
        }
       


      
    }
}

