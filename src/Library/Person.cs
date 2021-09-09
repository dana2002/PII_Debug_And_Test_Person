using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string fecha_nac)
        {
            this.Name = name;
            this.ID = id;
            this.Fecha_nac = fecha_nac;
        }

        private string name;

        private string id;

        private string fecha_nac;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public string Fecha_nac
        {
            get
            {
                return this.fecha_nac;
            }
            
            set
            {
                string fecha = value;
                string[] lista  = fecha.Split('/');
                if (Int32.Parse(lista[0]) <= 31 && Int32.Parse(lista[1]) <= 12 && Int32.Parse(lista[2]) >= 1925)
                {
                    this.fecha_nac = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}, nací el {this.Fecha_nac}");
        }
    }
}
