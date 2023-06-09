﻿using Heroes_Vs_Monsters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Modeles
{
    public class Dragonnet : Monstre
    {
        public Dragonnet(string nom) : base(nom)
        {
            Endurance += 1;
            Or = Dice.Lancer(DiceType.D6, 1) + 1;
            Cuir = Dice.Lancer(DiceType.D4, 1) + 1;
        }
    }
}
