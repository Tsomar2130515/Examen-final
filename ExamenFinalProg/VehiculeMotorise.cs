using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    
    public class VehiculeMotorise : Vehicule
    {
        protected Moteur moteur;
        protected VehiculeMotorise(string nom,string marque,int prix,Moteur moteur) : base(nom, marque, prix)
        {
            this.moteur = moteur;
        }
        public override string ToString()
        {
            string info = "INFORMATION VOITURE\n";
            info += "Nom : " + nom + "Marque :" + marque + " Prix  : " + prix + "$" + "\n";
            info += "INFORMATION SUR LE MOTEUR \n";
            info += "Marque: " + moteur.Marque + " HP :" + moteur.Force + " Prix  : " + moteur.TypeRefroid + "\n";
            return info;

        }







    }
}


