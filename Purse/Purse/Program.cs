using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyClass;
namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
//Badz ADDDDD
            Money m = new Money();
            m.StartMoney = 100;
            m.AddMoney = 500;
            
            //get info
            Console.WriteLine("Start money:");
            Console.WriteLine(m.startMoney);
            Console.WriteLine("End money:");
            Console.WriteLine(m.EndMoney);
        }
    }
}
