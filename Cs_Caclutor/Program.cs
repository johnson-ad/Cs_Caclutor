using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Caclutor
{
    class Program
    {
         
        static void Main(string[] args)
        {
            String respon;
          
            Console.Title = "👨🏽‍💻 Exo Calculator in C# 😁";
            Console.WriteLine("\t\t\tConsole Calulator in C#\r");
            Console.WriteLine("\t\t\t-----------------------\r");        
 
            Console.WriteLine("Entre un nbre: ");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre encore un nbre: ");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect un Operateur:\n\t1- Addition +\n\t2- Soustraction -\n\t3- Multiplication *\n\t4- Division /\n\t5- Modulo %\n\t6- Le Caree ^\n");
            respon = Console.ReadLine();

            do { 
                switch (respon)
                {
                    case "1":
                        Console.WriteLine($"\nLe resultat: {a} + {b} = " + addNum(a, b));
                        break;

                    case "2":
                        Console.WriteLine($"\nLe resultat: {a} - {b} = " + subNum(a, b));
                        break;

                    case "3":
                        Console.WriteLine($"\nLe resultat: {a} * {b} = " + prodNum(a, b));
                        break;

                    case "4":
                        Console.WriteLine($"\nLe resultat: {a} / {b} = " + divNum(a, b));
                        break;

                    case "5":
                        Console.WriteLine($"\nLe resultat: {a} % {b} = " + modNum(a, b));
                        break;

                    case "6":
                        Console.WriteLine($"\nLe resultat: {a} ^ {a} = " + powNum(a));
                        break;
                        default:
                        Console.Beep(); //faire un beep
                        Console.WriteLine("\nVeuille bien selectionner un operateur....");
                        break;
                }
                Console.WriteLine("\nVoulez-vous continuer ? [ Y = oui, N = no ]: ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("\nBaye 😁");
            Console.ReadKey();
        }

        public static double addNum(double a, double b) => a + b; 
        public static double subNum(double a, double b) => a - b;         
        public static double prodNum(double a, double b) => a * b;     
        public static double divNum(double a, double b) => a / b;
        public static double modNum(double a, double b) => a % b;
        public static double powNum(double a) => a * a;      

    }
}
