using System;

namespace Gambling
{
    class Program
    {   
         static void Main(string[] args)
        {
            Random m_random = new Random();
            double m_odds = .75;
            Guy m_player = new Guy() { m_name = "你", m_cash = 100 };

            Console.WriteLine("歡迎參加賭神大賽，目前的賠率是0.75");
            
            while(m_player.m_cash > 0)
            {
                m_player.WriteMyInfo();
                Console.Write("請輸入你的賭注： ");
                string m_inputMoney = Console.ReadLine();        

                if(int.TryParse(m_inputMoney, out int amount))
                {
                    int m_moneyDouble = amount * 2;

                    if (amount <= m_player.m_cash && amount > 0)
                    {
                        if (m_random.NextDouble() > m_odds)
                        {
                            Console.WriteLine("恭喜你贏了" + m_moneyDouble + "元。");
                            m_player.ReceiveCash(m_moneyDouble);
                        }

                        else
                        {
                            Console.WriteLine("真不幸，賠錢囉。");
                            m_player.GiveCash(amount);
                        }
                    }

                    else
                    {
                        Console.WriteLine("請重新押注。");
                    } 
                }
            }
            Console.WriteLine("十賭九輸，下次記得多帶一些錢來喔!!");
        }
    }
}
