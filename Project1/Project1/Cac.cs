using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Cac
    {
        public static IClass
            CreateIClass()
        {
            IClass outOne = null;
            Random r = new Random();
            int i =
                r.Next(100);

            if (i < 20)
            {
                outOne = new Triangle(r.Next(100),
                    r.Next(100),
                    r.Next(100),
                    r.Next(100),
                    r.Next(100),
                    r.Next(100)

                    );


            }
            else if (i < 80)
            {

                outOne = new Rectangle(
                    r.Next(100),
                    r.Next(100));


            }
            else
            {
                outOne = new Square(r.Next(100));
            }

            return outOne;

        }


        public float test2() {
            float s = 0;
            for (int i = 0; i < 10;) {
                IClass a;
                a=
                CreateIClass();
                if (a.ifRight())
                {
                    s += a.GetS();
                    i++;
                }
            
            
            
            }

            return s;
        
        }







    }
}
