using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin:Treasure
    {
        private int value;
        public Coin( string description,int score, int value):base(score,description)
        {
            this.value = value;
        }
        public int Value {  
            get { return value; } 
            set { this.value = value; }
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
        void UpdateTotalValue()
        {
            board.TotalValue += value;
            Console.WriteLine("Total Value is updated to: " + board.TotalValue);
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }
    }
}
