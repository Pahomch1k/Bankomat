using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Threading;

namespace Dz15_Bankomat
{
    class CheckClientAdd
    {
        public void SaveCheckAdd(Bankomat b, double money, double ost)
        { 
            StreamWriter sw = new StreamWriter("ClientAdd.txt", true);
            string line;
            line = $"Положенно денег - {money}\nБанкомат - {b.ID}\nОстаток - {ost}"; 
            sw.WriteLine(line); 
            sw.Close();
        }
    }

    class CheckClientSnyatie
    {
        public void SaveCheckSnyatie(Bankomat b, double money)
        {
            StreamWriter sw = new StreamWriter("ClientSnyatie.txt", true);
            string line;
            line = $"Снято денег - {money}\nБанкомат - {b.ID}\nОстаток - {b.Ostatok}";
            sw.WriteLine(line);
            sw.Close();
        }
    }

    class OtchetBsnk
    {
        public void OtchetBsnkaddsn(Bankomat b, double money, int x)
        {
            StreamWriter sw = new StreamWriter("Bank.txt", true);
            string line;
            if(x == 1) line = $"Положенно денег - {money}\nБанкомат - {b.ID}\nОстаток - {b.Ostatok}"; 
            else line = $"Снято денег - {money}\nБанкомат - {b.ID}\nОстаток - {b.Ostatok}";
            sw.WriteLine(line);
            sw.Close(); 
        } 
    }
}
