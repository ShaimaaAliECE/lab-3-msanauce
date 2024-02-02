using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        private string description;

        public CollectionBoard board;
        public Collectable(string description)
        {
            Description = description;
        }
        public string Description
        {
            get
            {
                return description;     
            }
            set
            {
                description = value;
            }
        }
        public CollectionBoard Board { 
            get 
            { 
                return board; 
            }
            set
            {
                board = value;
            }
            }
        public abstract void Display();
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(description+" Collected, Congrats!!!!");
        }
    }
}
