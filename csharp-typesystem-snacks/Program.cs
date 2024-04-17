using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //punto uno
            int numeroUno;
            Console.WriteLine("inserisci il primo numero");
            numeroUno = Convert.ToInt32(Console.ReadLine());

            int numeroDue;
            Console.WriteLine("inserisci il secondo numero");
            numeroDue = Convert.ToInt32(Console.ReadLine());

            if (numeroDue > numeroUno)
            {
                Console.WriteLine($"il numero più grande è il {numeroDue}");
            }
            else if (numeroDue < numeroUno)
            {
                Console.WriteLine($"il numero più grande è il {numeroUno}");
            }
            else
            {
                Console.WriteLine("i numeri sono pari");
            }







        }
    }
}

