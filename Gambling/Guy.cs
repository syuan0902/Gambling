using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling
{
    class Guy
    {
        public string m_name;
        public int m_cash;

        public void WriteMyInfo()
        {
            Console.WriteLine(m_name + "有" + m_cash + "元。");
        }

        public int GiveCash(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine(m_name + "說：" + amount + "元不是有效金額。");
                return 0;
            }

            if(amount > m_cash)
            {
                Console.WriteLine(m_name + "說：我沒有足夠的現金支付" + amount + "元。");
                return 0;
            }

            m_cash -= amount;

            return amount;
        }

        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(m_name + "說：我沒有收到錢。");
            }

            else
            {
                m_cash += amount;
            }
        }
    }
}
