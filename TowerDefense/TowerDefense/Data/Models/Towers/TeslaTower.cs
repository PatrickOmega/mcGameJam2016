﻿using System;
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
            this.towerType = TowerType.TESLA;
            this.cost = 50;
            this.damage = 5;
            this.attackSpeed = 1000;
            this.range = 10;
            this.damageType = TowerDamageType.SINGLE;
            this.virusType = Viruses.VirusType.GROUND;
            this.level = 1;
            this.upgradeCost = 75;
        }

        public override void upgrade()
        {
            this.damage += 5;
            this.level++;
            this.upgradeCost += 75;
        }
    }
}
