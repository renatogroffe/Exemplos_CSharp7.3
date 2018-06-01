using System;
using Newtonsoft.Json;

namespace ExemploAutoImplementedAttribute
{
    class Program
    {

        [Serializable]
        public class ClasseExemplo
        {
            public int Valor1 { get; set; }

            [NonSerialized]
            private int _valor2;

            public int Valor2
            {
                get { return _valor2; }
                set { _valor2 = value; }
            }

            /*[field: NonSerialized]
            public int Valor2 { get; set; }*/
        }

        static void Main(string[] args)
        {
            var teste = new ClasseExemplo()
            {
x                Valor1 = 1,
                Valor2 = 2
            };

            Console.WriteLine(JsonConvert.SerializeObject(teste));
            Console.ReadKey();
        }
    }
}