﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Modeles
{
    public class Nain : Hero 
    {
        public Nain(string nom) : base(nom)
        {
            Endurance += 2;
        }
    }
}
