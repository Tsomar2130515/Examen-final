using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Client
    {
        private string nomComplet;
        private int  montantArgent;
        public Client()
        {
            FactoryClient factoryClient = new FactoryClient();
            factoryClient.RemplirListes();
            this.nomComplet = factoryClient.CreerNomComplet();
            this.montantArgent = factoryClient.CreerMontant();
            
        }
        public override string ToString()
        {
            string info = "Nom : ";
            info += nomComplet + " Montant :" + montantArgent  + "\n";
            return info;
        }
    }
}
