using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGold;
namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello
            //this is project by Badz and Hvozdyk
            //task for Hvozdyk
            //Hvozdyk add reference on Gold Card
            Gold card = new Gold();

            card.owner = "Hvozdyk";
            card.age = 25;

            //get info
            Console.WriteLine("Owner of card information:");
            Console.WriteLine(card.owner);
            Console.WriteLine(card.age);
        }
    }
}
