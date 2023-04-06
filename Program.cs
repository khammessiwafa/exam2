using System;
using ConsultationSpace;
using PatientSpace;
using MedecinSpace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // test de la classe Consultation

            Console.WriteLine("--------------test de la classe Consultation---------------------");

            DateTime Date_0 = new DateTime(2022, 11, 13);



            Consultation Consultation_0 = new Consultation(Date_0);

            Console.WriteLine(Consultation_0);
            DateTime Date_1 = new DateTime(2022, 11, 14);

            Consultation Consultation_1 = new Consultation(Date_1,"maux de tete");

            Console.WriteLine(Consultation_1);

            // test de la classe patient

            Console.WriteLine("--------------test de la classe Patient---------------------");

            DateTime Date_2 = new DateTime(1996, 10, 23);

            Patient patient_1 = new Patient("Ronaldo", "Cristiano", Date_2 );
            Console.WriteLine(patient_1);

            patient_1.AjouterVisite(Consultation_1);
          
            Console.WriteLine(patient_1);
            patient_1.VisiteEffectuee();
            Console.WriteLine(patient_1);
            DateTime Date_3 = new DateTime(2004, 02, 02);

            Patient patient_2 = new Patient("Ronaldo", "Cristiano", Date_3, Consultation_0);
            Console.WriteLine(patient_2);
            DateTime Date_4 = new DateTime(2022, 11, 15);
            Consultation Consultation_2 = new Consultation(Date_4, "mal aux yeux");

            Console.WriteLine(Consultation_2);
            patient_2.AjouterVisite(Consultation_2);
            Console.WriteLine(patient_2);
            patient_2.VisiteEffectuee();
            Console.WriteLine(patient_2);
            Console.WriteLine("patient_1 == patient_1 {0}", patient_1 == patient_1);
            Console.WriteLine("patient_1 != patient_1 {0}", patient_1 != patient_1);

            Console.WriteLine("patient_1 != patient_2 {0}", patient_1 != patient_2);
            Console.WriteLine("patient_1 == patient_2 {0}", patient_1 == patient_2);

            // Test classe Medecin

            Console.WriteLine("--------------test de la classe Medecin---------------------");
            DateTime Date_6 = new DateTime(1980, 11, 20);
            Medecin MedecinPrincipal = new Medecin("Dubois", "Audrey", Date_6);
            Console.WriteLine(MedecinPrincipal);
            Console.WriteLine("MedecinPrincipal ==MedecinPrincipal {0}", MedecinPrincipal == MedecinPrincipal);
            Console.WriteLine("MedecinPrincipal!= MedecinPrincipal {0}", MedecinPrincipal != MedecinPrincipal);
           
          
            Patient patient_3 = new Patient("James", "Jean", new DateTime(1999, 12, 01));
            
            MedecinPrincipal.AjouterPatient(patient_3);
            Console.WriteLine(MedecinPrincipal);
            MedecinPrincipal.AjouterPatient(patient_3);
            Console.WriteLine(MedecinPrincipal);
            MedecinPrincipal.RetirerPatient(patient_3);
            Console.WriteLine(MedecinPrincipal);
            MedecinPrincipal.AjouterVisite(patient_3,Consultation_0);
            Console.WriteLine(MedecinPrincipal);
            patient_3.VisiteEffectuee();
            Console.WriteLine(MedecinPrincipal);
            MedecinPrincipal.AjouterVisite(patient_3, Consultation_1);
            Console.WriteLine(MedecinPrincipal);
            patient_3.VisiteEffectuee();
            Console.WriteLine(MedecinPrincipal);




            Console.ReadKey();

        }
    }
}