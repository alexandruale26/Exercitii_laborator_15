using System;


namespace Exercitii_laborator_15
{
    class Student
    {
        public Guid ID { get; set; }
        public string Prenume { get; set; }
        public string Nume { get; set; }
        public int Varsta { get; set;}
        public Specializare Specializare { get; set; }


        public override string ToString()
        {
            return $"{Nume} {Prenume} varsta {Varsta} specializare {Specializare}";
        }
    }
}
