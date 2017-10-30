using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6 {
    class Program {
        static void Main(string[] args) {


            Car auto1 = new Car();
            Car auto2 = new Car(5.4 , "Skoda");
            Car auto3 = Car.Create(6.2, "Fiat");
           
            Car.iloscKol = 6;
            Car auto4 = Car.Create(5.1, "Honda");
        //    Car.iloscDrzwi = 5; //nie moge modyfikowac, bo metoda const (patrz Klasa Car)
            
            Console.ReadKey();
        }

        //Metametyka mat = new Matematyka();
//       Console.WriteLine(Matematyka.ObwodKola(4));

        static string OpiszTyp() {
            return "Metoda bez argumentów";
        }
        static string OpiszTyp(int x) {
            return "Liczba całkowita";
        }
        static string OpiszTyp(string x) {
            return "Łańcuch znaków";
        }
        static string OpiszTyp(int x, int y) {
            return "Dwie liczby calkowite";
        }
        
        //static void Main(string[] args) 
        //{
        //    Console.WriteLine(OpiszTyp("sdassd"));
        //    Console.ReadKey();
        //}
        
        //propfull + tabulator
        //private double cena;

        //public double Cena {
        //    get { return myVar; }
        //    set { myVar = value; }
        //}


        
    }
}
