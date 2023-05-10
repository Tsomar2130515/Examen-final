using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public  class FactoryClient
    {
        static List<string> listNom = new List<string>();
        static List<string> listPrenom = new List<string>();
        static List<int> listArgent = new List<int>();
        static Random rand = new Random();
        public void RemplirListes()
        {
            listNom.Add("X");
            listNom.Add("Y");
            listNom.Add("Q");
            listNom.Add("U");
            listPrenom.Add("Louis");
            listPrenom.Add("Eric");
            listPrenom.Add("Luc");
            listPrenom.Add("Al");
            listArgent.Add(rand.Next(5000, 50000));
            listArgent.Add(rand.Next(5000, 50000));
            listArgent.Add(rand.Next(5000, 50000));
        }

        public  string CreerNomComplet()
        {
            string nom = "";
            nom = listPrenom[rand.Next(0, listPrenom.Count() - 1)] + listNom[rand.Next(0, listNom.Count() - 1)];
            return nom;

        }
        public int CreerMontant()
        {
            int mont = 0;
            mont = listArgent[rand.Next(0, listArgent.Count() - 1)];
            return mont;

        }





    }
}

