using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGold
{
    public class Gold
    {
        //create CardGold dll
        //build
        public string owner;
        public int age;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
