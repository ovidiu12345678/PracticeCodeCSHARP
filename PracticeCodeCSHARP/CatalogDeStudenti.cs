using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCodeCSHARP
{
     public class CatalogDeStudenti
    {
        private List<Students> studenti;

        public CatalogDeStudenti()
        {
            this.studenti = new List<Students>();
        }

        public void CitesteStudenti()
        {
            Console.Write("Introdu numarul de studenti: ");
            int numarStudenti = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for (int i = 0; i < numarStudenti; i++)
            {
                Console.Write("Introdu numele studentului: ");
                string nume = Console.ReadLine();

                Console.Write("Introdu prenumele studentului: ");
                string prenume = Console.ReadLine();

                Console.WriteLine(" ");


                Console.WriteLine("Introduceti specializarea studentului ! ");
                Console.WriteLine(" ");
                string specializareStudent = Console.ReadLine();

                studenti.Add(new Students(nume, prenume, specializareStudent));
                Console.WriteLine(" ");
        

            }


        }

        public void AfiseazaStudentii()
        {
            Console.WriteLine("Acestia sunt studenti : ");

            foreach ( var student in studenti)
            {
                Console.WriteLine($"Ma numesc {student.Nume} {student.Prenume} si sunt la facultatea cu specializarea {student.specializare}");
            }
        }

        
    }
}

