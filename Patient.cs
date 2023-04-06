using System;
using ConsultationSpace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientSpace
{
    internal class Patient
    {// Attributs
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value.ToUpper(); }
        }

        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value.ToLower(); }
        }
        private DateTime dateNaissance;

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }
        private List<Consultation> listeHistoriqConsultation;
        public List<Consultation> HistoriqueConsultations
        {
            get { return listeHistoriqConsultation; }
        }

        private Consultation consultationFuture;

        public Consultation ConsultationFuture
        {
            get { return consultationFuture; }
            set { consultationFuture = value; }
        }

        public Patient(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            ConsultationFuture = consultationFuture;
            listeHistoriqConsultation = new List<Consultation>();


        }
        public Patient(string nom, string prenom, DateTime dateNaissance,
            Consultation consultationFuture)
        {
            Nom= nom;
            Prenom = prenom;
            DateNaissance= dateNaissance;
            ConsultationFuture = consultationFuture;
            listeHistoriqConsultation = new List<Consultation>();


        }
        public void AjouterVisite(Consultation consultation)
        {
            listeHistoriqConsultation.Add(consultation);
        }
        public void VisiteEffectuee()
        {
            if (consultationFuture != null)
            {
              listeHistoriqConsultation.Add(consultationFuture);
                consultationFuture = null;
            }
        }
        public bool Egalite(Patient autre)
        {
            return autre.DateNaissance == this.DateNaissance
                && autre.Nom.Equals(this.Nom)&& autre.Prenom.Equals(this.Prenom);
        }

        public static bool operator== (Patient patient1, Patient patient2)
        {
            return patient1.Egalite(patient2);
        }
        public static bool operator !=(Patient patient1, Patient patient2)
        {
            return !patient1.Egalite(patient2);
        }
        public override string ToString()
        {
           StringBuilder stringBuilder = new StringBuilder();

           stringBuilder.AppendLine("Nom du patient : " +Nom);
           stringBuilder.AppendLine("Prenom du patient : " + Prenom);
           stringBuilder.AppendLine("Date de naissance du patient : " +DateNaissance.ToShortDateString());

            if (consultationFuture == null)
                stringBuilder.AppendLine("Pas de consultation à venir");

           
            
            else
                stringBuilder.AppendLine("Consultation à venir :"+consultationFuture.ToString());


            if (listeHistoriqConsultation.Count > 0)
            {
                stringBuilder.AppendLine("Historique de consultations:");

                foreach (Consultation consultation in listeHistoriqConsultation)
                {
                    stringBuilder.AppendLine(consultation.ToString());
                    stringBuilder.AppendLine("-------------------------");

                }
            }

            


            else
                stringBuilder.AppendLine("Pas d'historique de consultations");



           
            return stringBuilder.ToString();
            /* if (listeHistoriqConsultation.Count == 0)
                            stringBuilder.AppendLine("Pas d'historique de consultations");


                        else
                        {
                            stringBuilder.AppendLine("Historique de consultations:");

                            foreach (Consultation consultation in listeHistoriqConsultation)
                            {
                                stringBuilder.AppendLine(consultation.ToString());
                                stringBuilder.AppendLine("-------------------------");

                            }
                        }*/

        }
    }





           
        

    
}
