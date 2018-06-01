using System;

namespace ExemploTuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            var tupla1 = (Valor1: 1, Valor2: 2);
            var tupla2 = (Valor1: 1, Valor2: 2);
            var tupla3 = (Valor1: 3, Valor2: 4);

            if (tupla1 == tupla2)
                Console.WriteLine("tupla1 == tupla2");

            if (tupla2 != tupla3)
                Console.WriteLine("tupla2 != tupla3");

            Console.ReadKey();
        }
    }
}
