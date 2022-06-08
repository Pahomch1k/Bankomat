using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Dz15_Bankomat
{
    class AddMoneyClient: IAddMoney
    { 
        public void Input(Bankomat b)
        {
            double money = 0;
            Write("Сумма? ");
            money = Convert.ToDouble(ReadLine());
            CheckClientAdd f = new CheckClientAdd(); 
            b.Ostatok += money;
            f.SaveCheckAdd(b, money, b.Ostatok);
        }
    }

    class AddMoneyBank : IAddMoney
    {
        public void Input(Bankomat b)
        {
            double money = 0;
            Write("Сумма? ");
            money = Convert.ToDouble(ReadLine());
            b.Ostatok += money;
            OtchetBsnk f = new OtchetBsnk();
            f.OtchetBsnkaddsn(b, money, 1);
        }
    }

    class GetMoneyClient : IGetMoney
    {
        public void Snyatie(Bankomat b)
        {
            double money = 0; 
            Write("Сумма? ");
            money = Convert.ToDouble(ReadLine());
            if (money < b.Min_symma || money > b.Max_symma) WriteLine("Сумма не корректна ");
            else if(b.Ostatok < money) WriteLine("Сумма не корректна ");
            else b.Ostatok -= money;

            CheckClientSnyatie f = new CheckClientSnyatie();
            f.SaveCheckSnyatie(b, money);
        }
    }

    class GetMoneyBank : IGetMoney
    {
        public void Snyatie(Bankomat b)
        {
            double money = 0; 
            Write("Сумма? ");
            money = Convert.ToDouble(ReadLine());
            if (money < b.Min_symma || money > b.Max_symma) WriteLine("Сумма не корректна ");
            else if (b.Ostatok < money) WriteLine("Сумма не корректна ");
            else b.Ostatok -= money;

            OtchetBsnk f = new OtchetBsnk();
            f.OtchetBsnkaddsn(b, money, 0);
        }
    }
}
