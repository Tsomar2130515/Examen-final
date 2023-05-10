using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Concessionnaire
    {
        private string nom;
        private List<Vehicule> vehicules;
        private  double montantArgent;
        public Concessionnaire(string nom,double montantArgent)
        {
            this.nom = nom;
            this.montantArgent = montantArgent;
            vehicules=new List<Vehicule>();
        }
        public void AjouterVehicule(VehiculeMotorise veh)
        {
           vehicules.Add(veh);
        }
        public void VendreVehicule(VehiculeMotorise veh)
        {
            vehicules.Remove(veh);
        }
        public void GetInfoInventaire()
        {
            foreach (Vehicule veh in vehicules)
            {
                Console.WriteLine(veh.ToString());
            }
        }
        public void RemplirInventaire()
        {
            vehicules.Add(new Motomarine("Spark", "BRP",  12000,new Moteur()));
            vehicules.Add(new Motomarine("SparkGTI", "BRP", 10000, new Moteur()));
            vehicules.Add(new Motomarine("GTI", "XX", 6000, new Moteur()));
            vehicules.Add(new Motomarine("WW", "BRP", 8785, new Moteur("REL",78,typeRef.liquide)));
            vehicules.Add(new Motomarine("Spark", "BRP", 45, new Moteur("Rotax", 52, typeRef.air)));
            vehicules.Add(new Motomarine("SparkGTI", "BRP", 10000, new Moteur("YYY", 85, typeRef.liquide)));

            vehicules.Add(new VTT("XP", "BRP", 24544, new Moteur(),"TOYOTA",18));
            vehicules.Add(new VTT("PP", "BRP", 24544, new Moteur(), "TOYOTA", 18));
            vehicules.Add(new VTT("TOYOTA", "FHFG", 98744, new Moteur(), "COROLA", 11));


        }





    }
}
