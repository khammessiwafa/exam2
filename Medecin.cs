using ConsultationSpace;
using System;
using PatientSpace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedecinSpace
{
    internal class Medecin
    {

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
        private List<Patient> listePatient;
        public List<Patient> ListePatient
        {
            get { return listePatient; }
        }

       

       

        public Medecin(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;

            listePatient = new List<Patient>();

        }


        public void AjouterPatient(Patient patient)
        {

            if (!listePatient.Contains(patient))
            { listePatient.Add(patient); }
               
        }
        public void RetirerPatient(Patient patient)
        {
            listePatient.Remove(patient);
        }


        public void AjouterVisite(Patient patient, Consultation consultation)
        {
            if (!listePatient.Contains(patient))
            {
                listePatient.Add(patient);
            }
            patient.AjouterVisite(consultation);
        }

        public bool Egalite(Medecin autre)
        {
            return autre.DateNaissance == this.DateNaissance
                && autre.Nom.Equals(this.Nom) && autre.Prenom.Equals(this.Prenom);
        }

        public static bool operator ==(Medecin medecin1, Medecin medecin2)
        {
            return medecin1.Egalite(medecin2);
        }
        public static bool operator !=(Medecin medecin1, Medecin medecin2)
        {
            return !medecin1.Egalite(medecin2);
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Nom du medecin: " + Nom);
            stringBuilder.AppendLine("Prenom du medecin : " + Prenom);
            stringBuilder.AppendLine("Date de naissance du medecin : " + DateNaissance.ToShortDateString());

            if (listePatient.Count == 0)
                stringBuilder.AppendLine("Aucun patient pour le moment");


            else
            {
                stringBuilder.AppendLine("Historique de consultations:");

                foreach (Patient patient in listePatient)
                {
                    stringBuilder.AppendLine(patient.ToString());
                    stringBuilder.AppendLine("-------------------------");

                }
            }
            return stringBuilder.ToString();


        }
    }
}
