/* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. */

using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, result;

            Console.WriteLine("DIGITE O NÚMERO: ");
            number = int.Parse(Console.ReadLine());

            result = number % 2;

            if (result == 0)
            {
                Console.WriteLine("PAR");
            } else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}