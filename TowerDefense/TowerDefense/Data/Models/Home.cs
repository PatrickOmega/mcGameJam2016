using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Data.Models
{
    class Home
    {
        public int Health {
            set { this.Health = value; }
            get { return this.Health; }
        }

        public Home()
        {
            // Default health value
            Health = 100;
        }

        // Invoked by the Map class to inform the Base that it has taken damage.
        // Return boolean value indicating whether the game is over or not.
        public bool takeDamage()
        {
            Health--;
            if (Health > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
