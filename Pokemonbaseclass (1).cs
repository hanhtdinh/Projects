using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
   abstract  class Pokemon
    {
        //abstract classes cannot be instantiated
        //normal members will be inherited as is
        //data members cannot be virtual, but properties can be virtual
        private string name;
        private string owner;
        private int level;
        private string color;
        //virtual to give flexibility to change
        //making property abstract means you can't change it, but you have to put get or set blocks
        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        public string _owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public int _level
        {
            get { return level; }
            set {level = value; }
        }

        public string _color
        {
            get { return color; }
            set { color = value; }
        }

        public virtual void eat ()
        {
            Console.WriteLine("Pokemon eat pokemon food or even other Pokemon!");
            //basic diet of pokemon
            //can be used in hierarchy or we cna override it and change its implementation
        }

        public abstract void move();

        public abstract void evolve();
        public abstract void attack();

        //remember abstract methods must be implemented and do not contain the implemenattion code in their methods
    }
}
