using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int i;
        string shuzu, shuzu1;
        int m, n;
  
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            int t;
            float m;
            for (int n =2; n <= i;n++ )
            {
                t = i % n;
              
                if (t==0&&check(t)) {

                    s += n.ToString();
                }

            }

            textBox2.Text = s;
            
        }
        bool check(int n) {
            if (n == 1) {
                return true;
            }
            int t;
            float m;
            for (int i = 2; i < n; i++) {

                m = n / i;
                t = (int)(m);
                if (m == t)
                {
                    return false;

                }
            
            }
            return true;
        
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                i = int.Parse(textBox1.Text);
            }
            catch { 
            
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            shuzu = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ss=new string[0];
            int[] ii = new int[50];
            int tail = 0;
            int t;
            try
            {

                ss = shuzu.Split(',');
              

            }
            catch {

                textBox4.Text = "请规范输入";
                return;
            }
          
           for (int i = 0; i < ss.Length; i++) {
               try
               {
                   t = int.Parse(ss[i]);
                   ii[tail] = t;
                   tail++;
               }
               catch {
                   textBox4.Text = "请规范输入";
                   return;
               }
           
           }

           int max, min, all;
            float avg;
           max = ii[0];
           min = ii[0];
           all = 0;
           avg = 0;
           for (int k = 0; k < tail; k++) {
               if (ii[k] > max)
               {
                   max = ii[k];
               }
               else if (ii[k] < min) {
                   min = ii[k];
               }
               all += ii[k];
           }

           avg = all / tail;
           textBox4.Text = "Max: "+max+" Min: "+min+
                " Avg: "+avg+" All "+all;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] ii = new int[99];
            bool[] bb = new bool[99];
            for (int i = 0; i < 99; i++) {
                ii[i] = i + 2;
                bb[i] = true;
            }

            for (int i = 2; i < 101; i++) {
                for (int m = 0; m < 99; m++) {

                    if (!bb[m]) {
                        continue;
                    }
                    if (ii[m] == i) {
                        continue;
                    }
                    if (ii[m] % i == 0) {
                        bb[m] = false;
                    }
                
                }
            
            
            
            }
            string s="";
            for (int i = 0; i < 99; i++) {
                if (bb[i])
                {
                    s += " " + ii[i];
                }
            }
            textBox5.Text = s;





        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            shuzu1 = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m =int.Parse( textBox7.Text);
            }
            catch {

                textBox9.Text = "亲规范输入";
            
            }


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(textBox8.Text);
            }
            catch
            {

                textBox9.Text = "亲规范输入";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //temp
            int k = m * n;
            int t=0;
            string[] ss = new string[0];
            try
            {
               ss = shuzu1.Split(',');
            }
            catch {
                textBox9.Text = "亲规范输入";
                return;
            }

            int[] ii = new int[k];
            //transform string to int
            for (int i = 0; i < k; i++)
            {
                if (i < ss.Length)
                {
                    try
                    {
                        t = int.Parse(ss[i]);
                    }
                    catch
                    {
                        textBox9.Text = "亲规范输入";
                        return;
                    }

                    ii[i] = t;
                }
                else {

                    ii[i] = 0;
                }
            
            }

            //true or false;
            m++;
            int total=0;
            int num = ii[0];
            while (true) {
                
                total += m;
                if (total > k - 1)
                {
                    break;
                }
                if (num != ii[total]) {

                    textBox9.Text = "false;";
                    return;
                }
            
            }

            textBox9.Text = "true;";




        }

   
       
       

      

     
    }
}
