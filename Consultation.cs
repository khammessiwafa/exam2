using exam2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultationSpace
{
    internal class Consultation
    {


        private DateTime date;
        public DateTime Date
            // les attributs
        {
            get { return date; }
            set { date = value; }
        }

        private string raison;
        public string Raison
        {
            get { return raison; }
            set { raison = value; }
        }
        // constructeur
        public Consultation(DateTime date)
        {
            Date = date;
            Raison= "non Défini";
          
           
        }
        public Consultation(DateTime date , string raison )
        {
            Date = date;
            Raison = raison;

        }
        public override string ToString()
        {
            StringBuilder stBuilder = new StringBuilder();
            
            stBuilder.AppendLine("Date de la consultation : " + Date.ToShortDateString());
            stBuilder.AppendLine("Raison de la consultation : " + Raison);
         

            return stBuilder.ToString();
        }
        
    }


}

