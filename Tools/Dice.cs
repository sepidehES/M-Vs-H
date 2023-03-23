using System;
using System.Collections.Generic;
using System.Linq;
using Heroes_Vs_Monsters.Modeles;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Heroes_Vs_Monsters.Tools
{
    public enum DiceType
    {
        D4 = 4,
        D6 = 6,
    }
    public class Dice
    {

        public static int Lancer(DiceType dice = DiceType.D6, int nombre = 4)
        {
            int plusPetitNombre = int.MaxValue, result = 0;

            List<int> DiceList = new List<int>();
            Random rnd = new Random();

            int diceValue = (int)dice;

            for (int i = 0; i < nombre; i++)
                DiceList.Add(rnd.Next(diceValue) + 1);

            for (int i = 0; i < DiceList.Count; i++)
            {
                 if (DiceList[i] < plusPetitNombre)
                    plusPetitNombre = DiceList[i];
            }

            if (nombre != 1)
                DiceList.Remove(plusPetitNombre);

            for (int i = 0; i < DiceList.Count; i++)
            {
                result += DiceList[i];
            }

            return result;
        }
    }
}



