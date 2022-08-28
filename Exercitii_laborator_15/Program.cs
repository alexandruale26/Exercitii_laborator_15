using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.ConstrainedExecution;


namespace Exercitii_laborator_15
{
    internal class Program
    {
        static void Main()
        {
            List<Student> studenti = new List<Student>()
            {
                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Mitica",
                Nume = "Popescu",
                Varsta = 18,
                Specializare = Specializare.Constructii
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Marin",
                Nume = "Preda",
                Varsta = 40,
                Specializare = Specializare.Litere
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Sorina",
                Nume = "Gilgamesh",
                Varsta = 31,
                Specializare = Specializare.Constructii
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Dana",
                Nume = "Mihalcea",
                Varsta = 23,
                Specializare = Specializare.Informatica
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Iulian",
                Nume = "Paduraru",
                Varsta = 29,
                Specializare = Specializare.Informatica
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Ion",
                Nume = "Creanga",
                Varsta = 53,
                Specializare = Specializare.Litere
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Catalin",
                Nume = "Visan",
                Varsta = 35,
                Specializare = Specializare.Constructii
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Carmen",
                Nume = "Juga",
                Varsta = 18,
                Specializare = Specializare.Informatica
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Valeriu",
                Nume = "Tomita",
                Varsta = 22,
                Specializare = Specializare.Constructii
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Bianca",
                Nume = "Muraru",
                Varsta = 26,
                Specializare = Specializare.Informatica
                },

                new Student()
                {
                ID = Guid.NewGuid(),
                Prenume = "Mihai",
                Nume = "Eminescu",
                Varsta = 32,
                Specializare = Specializare.Litere
                },
            };


            // 1. Afisati cel mai in varsta student de la Informatica
            Console.WriteLine("1. Afisati cel mai in varsta student de la Informatica");

            Console.WriteLine(studenti.Where(s => s.Specializare == Specializare.Informatica).OrderBy(s => s.Varsta).LastOrDefault());
            Console.WriteLine();


            // 2. Afisati cel mai tanar student • In mai multe moduri
            Console.WriteLine("2. Afisati cel mai tanar student • In mai multe moduri");

            Console.WriteLine(studenti.OrderBy(s => s.Varsta).FirstOrDefault());
            Console.WriteLine(studenti.OrderByDescending(s => s.Varsta).LastOrDefault());
            Console.WriteLine();


            // 3. Afisati in ordine crescatoare a varstei toti, studentii de la litere
            Console.WriteLine("3. Afisati in ordine crescatoare a varstei toti, studentii de la litere");

            List<Student> studentiLaLitereVarstaCrescator = studenti.Where(s => s.Specializare == Specializare.Litere).OrderBy(s => s.Varsta).ToList();
            studentiLaLitereVarstaCrescator.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();


            // 4. Afisati primul student de la constructii cu varsta de peste 20 de ani
            Console.WriteLine("4. Afisati primul student de la constructii cu varsta de peste 20 de ani");

            Console.WriteLine(studenti.First(s => s.Specializare == Specializare.Constructii && s.Varsta > 20));
            Console.WriteLine();


            // 5. Afisati studentii avand varsta egala cu varsta medie a studentilor
            Console.WriteLine("5. Afisati studentii avand varsta egala cu varsta medie a studentilor");

            List<Student> studentiCuVarstaEgalaCuVarstaMedie = studenti.Where(s => s.Varsta == (int)studenti.Average(s => s.Varsta)).ToList();
            studentiCuVarstaEgalaCuVarstaMedie.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();


            // 6. Afisati in ordinea descrescatoare a varstei, si in ordinea alfabetica, dupa numele de
            // familie si dupa numele mic, toti studentii cu varsta cuprinsa intre 18 si 35 de ani
            Console.WriteLine("6. Afisati in ordinea descrescatoare a varstei, si in ordinea alfabetica, dupa numele de \n" +
                              "familie si dupa numele mic, toti studentii cu varsta cuprinsa intre 18 si 35 de ani");

            List<Student> studentiOrdonatiDescrescatorDupaVarsta = studenti.Where(s => s.Varsta >= 18 && s.Varsta <= 35).OrderByDescending(s => s.Varsta).ThenBy(s => s.Nume).ThenBy(s => s.Prenume).ToList();
            studentiOrdonatiDescrescatorDupaVarsta.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();


            // 7. Afisati ultimul elev din lista folosind linq
            Console.WriteLine("7. Afisati ultimul elev din lista folosind linq");
            Console.WriteLine(studenti.LastOrDefault());
            Console.WriteLine();


            // 8. Afisati mesajul "Exista si minori” daca in lista creata exista si persone cu varsta mai mica de
            // 18 ani.In caz contar afisati “Nu exista minori"
            Console.WriteLine("8. Afisati mesajul \"Exista si minori\" daca in lista creata exista si persone cu varsta mai mica de \n" +
                              "18 ani.In caz contar afisati \"Nu exista minori\"");

            Console.WriteLine(studenti.Any(s => s.Varsta < 18) ? "Exista si minori" : "Nu exista minori");
            Console.WriteLine();


            /*
              9. Folosind GroupBy , afisati toti studentii grupati in functie de varsta sub forma urmatoare:
                 Studentii cu varsta de 20 de ani
                 Student1.toString
                 Student2.toString
                 Student3.toString
                 Studentii cu varsta de 25 de ani
            */


        }
    }
}
