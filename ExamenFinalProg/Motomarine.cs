using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public enum typeMotomarine
    {
        jetski,
        seaDoo
        
        

    }
    public class Motomarine : VehiculeMotorise
    {
        private typeMotomarine type;
        public Motomarine(string nom,string marque,int prix,Moteur moteur,typeMotomarine type = typeMotomarine.seaDoo) : base( nom, marque, prix, moteur)
        {
            this.nom = nom;
            this.marque = marque;
            this.moteur = moteur;
            this.type = type;
            this.prix= prix;
        }
        public override string ToString()
        {
            string info = "INFORMATION VTT \n";
            info += "Nom : " + nom + "Marque :" + marque + " Prix  : " + prix + "$" + "\n";
            info += "INFORMATION SUR LE MOTEUR \n";
            info += moteur.ToString() + "\n";
            return info;

        }

    }
   
}



