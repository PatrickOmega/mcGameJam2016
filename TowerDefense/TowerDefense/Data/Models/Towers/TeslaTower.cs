using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Data.Models.Towers
{
    class TeslaTower : Tower
    {
        public TeslaTower()
        {
            this.name = "Tesla";
            this.cost = 50;
            this.damage = 5;
            this.attackSpeed = 1000;
            this.range = 10;
            this.damageType = TowerDamageType.SINGLE;
            this.virusType = Viruses.VirusType.GROUND;
            this.level = 1;
            this.upgradeCost = 75;
        }
    }
}
