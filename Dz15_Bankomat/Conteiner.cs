using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz15_Bankomat
{
    class Bankomat
    {
        IAddMoney f1;
        IGetMoney f2; 
        public string ID { get; set; }
        public double Ostatok { get; set; }
        public double Min_symma { get; set; }
        public double Max_symma { get; set; }

        public Bankomat()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++) ID += Convert.ToString(r.Next(0, 10));
            Ostatok = 0;
            Min_symma = 10;
            Max_symma = 1000;
        }

        public Bankomat(string i, double o, double min, double max)
        {
            ID = i;
            Ostatok = o;
            Min_symma = min;
            Max_symma = max;
        }

        public override string ToString()
        {
            return Convert.ToString(Ostatok);
        }
        
        public void SetAdd(IAddMoney b)
        {
            f1 = b;
        }

        public void Input(Bankomat b)
        {
            f1.Input(b);
        }

        public void SetGet(IGetMoney b)
        {
            f2 = b;
        }
        public void Snyatie(Bankomat b)
        {
            f2.Snyatie(b);
        }
    }
}
