using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Data.Models.Position;

namespace TowerDefense.Data.Models.Viruses
{
    abstract class Virus
    {
        private Position.Position Position
        {
            set { this.Position = value; }
            get { return this.Position; }
        }

        private String Name
        {
            set { this.Name = value; }
            get { return this.Name; }
        }

        private int Step
        {
            set { this.Step = value; }
            get { return this.Step; }
        }

        private int Score
        {
            set { this.Score = value; }
            get { return this.Score; }
        }

        private int Speed
        {
            set { this.Speed = value; }
            get { return this.Speed; }
        }

        private int Money
        {
            set { this.Money = value; }
            get { return this.Money; }
        }

        public int Health
        {
            set { this.Health = value; }
            get { return this.Health; }
        }
    }
}
