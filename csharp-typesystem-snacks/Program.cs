﻿using System;

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



        }
    }
}

