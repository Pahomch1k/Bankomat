using System;
using static System.Console;


namespace Dz15_Bankomat
{
    class Program
    { 
        public static void Add(IAddMoney f, Bankomat a)
        { 
            a.SetAdd(f);
            a.Input(a); 
        }

        public static void Get(IGetMoney f, Bankomat a)
        { 
            a.SetGet(f);
            a.Snyatie(a);
        }

        static void Main(string[] args)
        {
            Bankomat b = new Bankomat();
            int flag = 0;
            while (flag == 0)
            {
                int choise = 0;
                WriteLine("1 - Клиент\n2 - Банк");
                choise = Convert.ToInt32(ReadLine());

                switch (choise)
                {
                    case 1:
                         {
                            int ch = 0;
                            WriteLine("1 - Снять деньги\n2 - Положить деньги\n3 - Показать остаток\n4 - Выход");
                            ch = Convert.ToInt32(ReadLine());

                            switch (ch)
                            {
                                case 1:
                                    {
                                        IGetMoney f = new GetMoneyClient();
                                        Get(f,b); 
                                    }
                                    break;
                                case 2:
                                    {
                                        IAddMoney f = new AddMoneyClient();
                                        Add(f, b);
                                    }
                                    break;
                                case 3:
                                    {
                                        Write($"Остаток - ");
                                        WriteLine(b.Ostatok);
                                    }
                                    break;
                                case 4:
                                    flag++;
                                    break;
                                default:
                                    break;
                            }
                        }
                         break;
                    case 2:
                        {
                            int ch = 0;
                            WriteLine("1 - Снять деньги\n2 - Положить деньги\n3 - Показать остаток\n4 - Выход");
                            ch = Convert.ToInt32(ReadLine());

                            switch (ch)
                            {
                                case 1:
                                    {
                                        IGetMoney f = new GetMoneyBank();
                                        Get(f, b);
                                    }
                                    break;
                                case 2:
                                    {
                                        IAddMoney f = new AddMoneyBank();
                                        Add(f, b);
                                    }
                                    break;
                                case 3:
                                    {
                                        Write($"Остаток - ");
                                        WriteLine(b);
                                    }
                                    break;
                                case 4:
                                    flag++;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break; 
                    default: flag++;
                        break;
                } 
            } 
        }
    }
     

    class PrintOstatok
    {    
        public void Print(Bankomat b)
        {
            Write($"Остаток - ");
            WriteLine(b);
        }
    }
}
