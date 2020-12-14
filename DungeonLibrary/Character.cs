using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //This is the main structure that both Player and Enemy characters will inherit from.

        //Fields

        //Used to manipuate HP status of current Player/Monster.
        private int _health;

        //Properties        
        public string Name { get; set; }
        public int Accuracy { get; set; }
        public int Defense { get; set; }
        public int MaxHP { get; set; }
        
        //CTORS

        //Methods
    }
}
