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



            //punto 2 
            string paorlaUno;
            Console.WriteLine("iserisci la prima parola");
            paorlaUno = Console.ReadLine();

            string parolaDue;
            Console.WriteLine("iserisci la seconda parola");
            parolaDue = Console.ReadLine();

            if (paorlaUno.Length > parolaDue.Length)
            {
                Console.WriteLine($"la parola {paorlaUno} e piu lunga");
            }
            else if (paorlaUno.Length < parolaDue.Length)
            {
                Console.WriteLine($"la parola {parolaDue} e piu lunga");
            }
            else
            {
                Console.WriteLine($"le parole {paorlaUno} e {parolaDue} hanno la stessa lunghezza");
            }




            //Snack 3


            int[] numeri = new int[10];
            int risultato = 0;
            Console.WriteLine(numeri.Length);

            for ( int i = 0; i < numeri.Length; i++ )
            {
                Console.WriteLine($"inserisci il numero { i + 1}");
                numeri[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine($"numeri stampati ");

            //da eliminare
            for ( int i = 0;i < numeri.Length;i++ )
            {
                //cosi tampo tutti i numeri inseriti 
                //Console.WriteLine(numeri[i]);
            }





            for ( int i = 0; i < numeri.Length; i++)
            {
                //metodo breve con il +=
                risultato += numeri[i];

                //metodo "lungo"
                //risultato = risultato + numeri[i];


            }
            
            Console.WriteLine($"totale {risultato}" );





            //Snack 4
            int[] arrey4 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int somma = 0;

            for ( int i = 0; i < arrey4.Length; i++)
            {
                somma += arrey4[i];
            }

            Console.WriteLine($"{somma/9}");





            //Snack 5 
            //int numeroDaValutare ;
            Console.WriteLine("inserisci un numero");
            int numeroDaValutare = Convert.ToInt32(Console.ReadLine());

            bool pari = numeroDaValutare % 2 == 0;

            if ( pari )
            {
                Console.WriteLine("il numero e pari" + pari);
            }
            else
            {
                Console.WriteLine("il numero e dispari  " + pari +1);
            }







        }
    }
}

