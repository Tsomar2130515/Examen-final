using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Vehicule
    {
        protected string nom;
        protected string marque;
        protected int prix;
        public Vehicule(string nom, string marque, int prix)
        {
            this.nom = nom;
            this.marque = marque;
            this.prix = prix;


        }
        public override string ToString()
        {
            string info = "INFORMATION VOITURE\n";
            info += "Nom : " + nom + "Marque :" + marque + " Prix  : " + prix + "$" + "\n";
            return info;

        }
    }
}
