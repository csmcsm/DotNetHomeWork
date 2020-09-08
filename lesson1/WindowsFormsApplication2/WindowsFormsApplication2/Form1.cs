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
    
        int transformStringToInt(string s){
            try
            {
                return  int.Parse(s);
            }
            catch
            {
                return int.MaxValue;
            }
        
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                i = transformStringToInt(textBox1.Text);
           
        }

        bool splitStringToInt(string s,ref int[] ii) {

            string[] ss = new string[0];
          
            int tail = 0;
            int t;
            try
            {

                ss = s.Split(',');


            ii = new int[ss.Length];
            for (int i = 0; i < ss.Length; i++)
            {
               
                    t = int.Parse(ss[i]);
                    ii[tail] = t;
                    tail++;
              

            }

            }
            catch
            {


                return false;
            }
            return true;
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            shuzu = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] ii=new int[0];
            splitStringToInt(textBox3.Text,ref ii);
           int max, min, all;
            float avg;
           max = ii[0];
           min = ii[0];
           all = 0;
           avg = 0;
           for (int k = 0; k < ii.Length; k++) {
               if (ii[k] > max)
               {
                   max = ii[k];
               }
               else if (ii[k] < min) {
                   min = ii[k];
               }
               all += ii[k];
           }

           avg = all / ii.Length;
           textBox4.Text = "Max: "+max+" Min: "+min+
                " Avg: "+avg+" All "+all;

        }

        private void button3_Click(object sender, EventArgs e)
        {
          //check value
            bool[] bb = new bool[99];
            for (int i = 0; i < 99; i++) {
             
                bb[i] = true;
            }

            for (int i = 2; i < 101; i++) {
                for (int m = 0; m < 99; m++) {

                    if (!bb[m] || m + 2 == i)
                    {
                        continue;
                    }
                  
                    if ((m+2) % i == 0) {
                        bb[m] = false;
                    }
                
                }
            
            
            
            }

            //output result
            string s="";
            for (int i = 0; i < 99; i++) {
                if (bb[i])
                {
                    s += " " + (i+2);
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
            m = transformStringToInt(textBox7.Text) !=
                int.MaxValue ? transformStringToInt(textBox7.Text) :0;


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            n = transformStringToInt(textBox8.Text) !=
                int.MaxValue ? transformStringToInt(textBox7.Text) : 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //temp
            int k = m * n;
            int t=0;
            string[] ss = new string[0];
            int[] ii = new int[k];
            try
            {
               ss = shuzu1.Split(',');
          

           
            //transform string to int
            for (int i = 0; i < k; i++)
            {
                if (i < ss.Length)
                {
                     t = int.Parse(ss[i]);
                   

                    ii[i] = t;
                }
                else {

                    ii[i] = 0;
                }
            
            }

            }
            catch
            {
                textBox9.Text = "亲规范输入";
                return;
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
