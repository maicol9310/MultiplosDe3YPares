using System;

namespace MultiplosEImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 3, 2, 5, 6, 4, 3, 7, 8, 10, 30, 15, 9 };
            int[] numeros1 = new int[13];
            int[] numeros2 = new int[13];

            for (int i = 0, par=0, mul = 0; i != 13; ++i)
            {
                if (numeros[i] % 3 == 0)
                {
                    numeros2[mul] = numeros[i];
                    Console.WriteLine("Numero multiplo de 3: "+numeros2[mul]);
                    mul++;
                }

                if (numeros[i] % 2 == 0)
                {
                    numeros1[par] = numeros[i];
                    Console.WriteLine("Numero par: " + numeros1[par]);
                    par++;
                }
            }

            Console.WriteLine("Arreglo original: "+ String.Join(" ", numeros));
            Console.ReadKey();
        }
    }
}
