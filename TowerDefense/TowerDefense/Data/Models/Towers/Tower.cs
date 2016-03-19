﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Data.Models.Viruses;

namespace TowerDefense.Data.Models.Towers
{
    class Tower: Entity
    {
        //variables
        public String name { get; set; }
        public int cost { get; set; }
        public int damage { get; set; }
        public int attackSpeed { get; set; }
        public int range { get; set; }
        public TowerDamageType damageType { get; set; } // Single or area splash
        public VirusType virusType { get; set; } // Whether a ground or flying unit
        public int level { get; set; } // 1-5 
        public int upgradeCost { get; set; }

    }
}
