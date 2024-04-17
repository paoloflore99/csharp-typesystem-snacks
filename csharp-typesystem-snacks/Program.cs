using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            for (int i = 0; i < numeri.Length; i++)
            {
                Console.WriteLine($"inserisci il numero {i + 1}");
                numeri[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine($"numeri stampati ");


            for (int i = 0; i < numeri.Length; i++)
            {
                //metodo breve con il +=
                risultato += numeri[i];

                //metodo "lungo"
                //risultato = risultato + numeri[i];


            }

            Console.WriteLine($"totale {risultato}");





            //Snack 4
            int[] arrey4 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int somma = 0;

            for (int i = 0; i < arrey4.Length; i++)
            {
                somma += arrey4[i];
            }

            Console.WriteLine($"{somma / 9}");





            //Snack 5 
            
            Console.WriteLine("inserisci un numero");
            int numeroDaValutare = Convert.ToInt32(Console.ReadLine());

            bool pari = numeroDaValutare % 2 == 0;

            if (pari)
            {
                Console.WriteLine("il numero e pari" + pari);
            }
            else
            {
                Console.WriteLine("il numero e dispari  " + (numeroDaValutare % 2 == 0) + 1);

            }



            //Sneck 6
            string[] Gatsby = { "paolo", "flore", "marco", "rossi", "serena", "martina", "marta", "andrea" };


            Console.WriteLine("inserisci il tuo nome");
            string mioNome = Console.ReadLine();
            bool invitato = false;

            foreach (string invitati in Gatsby)
            {

                //il .ToLower() serve per le gestioni delle maiuscole 
                if (mioNome.ToLower() == invitati.ToLower())
                {
                    invitato = true;
                    break;
                }
            }



            if (invitato)
            {
                Console.WriteLine($"Ciao {mioNome}, sei invitato!");
            }
            else
            {
                Console.WriteLine("Mi dispiace, non sei invitato.");
            }


            //Snack 7
            int[] array6 = new int[6];

            for (int i = 0; i < array6.Length; i++)
            {
                Console.WriteLine($"{i + 1} inserisci un numero");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 != 0)
                {
                    array6[i] = numero;
                }
                else
                {
                    array6[i] = 0;
                }

                
            }

            foreach (int compilato6 in array6)
            {
                Console.WriteLine($"lista {compilato6}");
            }




            //Snack 8
            int[] arrayPari = {2,3,4,5,6,7,8,9,0,14,424,53};
            int parametro = 0;

            for (int i = 0; i < arrayPari.Length; i+= 2)
            {
                parametro += arrayPari[i];
            }

            Console.WriteLine($"la somma e {parametro}");





        }


    }
}


