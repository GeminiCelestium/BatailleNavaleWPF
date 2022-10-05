using BatailleNavaleWPF;
using System;

namespace BatailleNavale
{
    // Classe Navire abstraite car on ne veut pas l'instancier, implémente l'interface INavire...
    public abstract class Navire : INavire
    {
        public int Longueur { get; }

        public bool Coule { get => EstCoule(); }

        public readonly Case[] cases;

        // Constructeur de la classe...
        public Navire(int longueur, Case[] carres)
        {
            Longueur = longueur;

            cases = carres;

            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
        }

        // Méthode qui vérifie si le navire a complètement été touché, donc coulé...
        public bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
