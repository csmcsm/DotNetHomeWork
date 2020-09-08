using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        float n1, n2;
        string fuhao;
        public Form1()
        {
            
           
            InitializeComponent();
        }
        float getint(string s) {

        
            try
            {
               return float.Parse( s);
            }
            catch { textBox4.Text = "请规范输入"; }
            return int.MaxValue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n1 = getint(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fuhao = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            n2 = getint(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float i=0;
            switch (fuhao) { 
                case"+":
                    i = n1 + n2;
                    break;
                case "-":
                    i = n1 - n2;
                    break;
                case "*":
                    i = n1 * n2;
                    break;
                case "/":
                    i = n1 /n2;
                    break;
                default:
                    textBox4.Text = "请规范输入";
                    return;
                    break;
            
            }
            if (i < int.MaxValue)
            {
                textBox4.Text = i.ToString();
            }
            else {
                textBox4.Text = "请规范输入";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
