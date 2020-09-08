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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string n11 = textBox1.Text;
            try
            {
                n1 = float.Parse(n11);
            }
            catch { textBox4.Text = "请规范输入"; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fuhao = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string n11 = textBox3.Text;
            try
            {
                n2 = float.Parse(n11);
            }
            catch {
                textBox4.Text = "请规范输入";
            }
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
                    break;
            
            }
           
            textBox4.Text = i.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
