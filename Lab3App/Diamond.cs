using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond:Treasure
    {
        public Diamond(string description, int score) : base(score, description){}
        public override void Display()
        {
            Console.WriteLine(Description + " is displayed");
        }
        
    }
}
