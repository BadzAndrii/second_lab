using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyClass
{
    public class Money
    {
        //create Money class
        public int startMoney;
        public int endMoney;
        public int addMoney;

        public int StartMoney
        {
            get { return startMoney; }
            set { startMoney = value; }
        }
        public int AddMoney
        {
            set { addMoney = value; }
        }
        public int EndMoney
        {
            get { return endMoney = startMoney + addMoney; }
        }

    }
}
