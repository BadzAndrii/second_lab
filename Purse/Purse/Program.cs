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
<<<<<<< HEAD
            //task for Hvozdyk

            card.owner = "Hvozdyk";
            card.age = 25;
=======
            //Hvozdyk add reference on Gold Card
            Gold card = new Gold();

            card.owner = "Hvozdyk";
            card.age = 25;

            //get info
            Console.WriteLine("Owner of card information:");
            Console.WriteLine(card.owner);
            Console.WriteLine(card.age);


            // Badz Add class
//Badz ADDDDD
             //test2
>>>>>>> 3e05a4d37d98063adc3c4e732cba22cd5133584f
            Money m = new Money();
            m.StartMoney = 100;
            m.AddMoney = 500;
            
            //get info
<<<<<<< HEAD
            Console.WriteLine("Owner of card information:");
            Console.WriteLine(card.owner);
            Console.WriteLine(card.age);
=======
>>>>>>> 3e05a4d37d98063adc3c4e732cba22cd5133584f
            Console.WriteLine("Start money:");
            Console.WriteLine(m.startMoney);
            Console.WriteLine("End money:");
            Console.WriteLine(m.EndMoney);
        }
    }
}
