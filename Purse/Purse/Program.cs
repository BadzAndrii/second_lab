using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGold;
using MoneyClass;
namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hvozdyk add 
            Gold card = new Gold();
            //Hello
            //this is project by Badz and Hvozdyk
            //task for Hvozdyk

            card.owner = "Hvozdyk";
            card.age = 25;
            Money m = new Money();
            m.StartMoney = 100;
            m.AddMoney = 500;
            
            //get info
            Console.WriteLine("Owner of card information:");
            Console.WriteLine(card.owner);
            Console.WriteLine(card.age);
            Console.WriteLine("Start money:");
            Console.WriteLine(m.startMoney);
            Console.WriteLine("End money:");
            Console.WriteLine(m.EndMoney);
        }
    }
}
