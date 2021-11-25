using System;
using System.Collections.Generic;

namespace Tarefa1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Com Array
            
            int[] array = new int[] { 7, 5, 3, 9, 6, 4, 1 };
            int soma = 0;

            Console.WriteLine("Com Array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 9)
                {
                    array[i] = 5;
                }
                if (array[i] == 4)
                {
                    array[i] = 0;
                }
                soma += array[i];
            }
            
            Console.WriteLine();
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n" + soma);

            // Com Lista

            List<int> lista = new List<int> { 7, 5, 3, 9, 6, 4, 1 };
            
            Console.WriteLine("\nCom Lista:");
            foreach (int item in lista)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int index = lista.FindIndex(n => n == 9);
            lista.Insert(index, 5);
            lista.Remove(9);
            lista.Remove(4);

            soma = 0;
            foreach (int item in lista)
            {
                Console.Write(item + " ");
                soma += item;
            }

            Console.WriteLine("\n" + soma);
          
        }
    }
}
