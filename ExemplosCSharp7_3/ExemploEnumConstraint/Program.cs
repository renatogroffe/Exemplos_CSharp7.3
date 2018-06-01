using System;
using System.Linq;
using System.Text;

namespace ExemploEnumConstraint
{
    public static class EnumHelper
    {
        public static string GetValues<T>() where T : Enum
        {
            StringBuilder strbValores = new StringBuilder();
            strbValores.Append("[ ");

            var valores = Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(v => v.ToString());
            foreach (var valor in valores)
            {
                if (strbValores.Length > 2)
                    strbValores.Append(", ");
                strbValores.Append(valor);
            }

            strbValores.Append(" ]");

            return strbValores.ToString();
        }
    }

    public enum ExemploEnum
    {
        Status1,
        Status2,
        Status3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EnumHelper.GetValues<ExemploEnum>());
            Console.ReadKey();
        }
    }
}