using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6 {
    class Car {



        private double pojemnoscSilnika;
        private string marka;


        public Car() 
        {
            this.marka =  "Ford";
        }


        public Car(double pojemnoscSilnika, string marka) 
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        
        }
        public static Car Create(double pojemnosc, string marka)
        {
            Car temp = new Car(pojemnosc, marka);
            return temp;
        }
        public static int iloscKol;

            static Car()
            {
                iloscKol = 4;
            }
            public const int iloscDrzwi = 4;

        ~Car() //destruktor
            {
                Console.WriteLine("Zwalniam pamięć");
                Console.ReadKey();
            }
    }
}
