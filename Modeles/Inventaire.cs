using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Modeles
{
    public class Inventaire
    {
        public string Objet { get; set; }
        public int nbObjet { get; set; }
        public Dictionary<string, int> Stockage { get; set; }

        public Inventaire()
        {
            Stockage = new Dictionary<string, int>();
        }

        public void AjouterObjet(string Objet)
        {
            Stockage.Add(Objet, nbObjet);
        }

        public void Incrementer()
        {
            if (Stockage.ContainsKey(Objet))
            {
                Stockage[Objet] += nbObjet;
            }
        }

        public void Decrementer()
        {
            if (Stockage.ContainsKey(Objet))
            {
                Stockage[Objet] -= nbObjet;
                if (Stockage[Objet] < 1)
                {
                    Stockage.Remove(Objet);
                }
            }
        }
    }
}


