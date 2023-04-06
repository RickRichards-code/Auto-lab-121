using System;

namespace Auto
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // a) Instanciar un objeto Automóvil y un objeto Importadora con 4 automóviles.
            AutoMovil a1 = new AutoMovil("zzz","hilux","AGD-1634",513.13,2022);
            Importadora h1 = new Importadora("toyosa", "30", 8324234);
            Console.WriteLine(h1.verificar("toyota"));
            Console.WriteLine(h1.verificarPlaca(a1));
            h1.paisProcedencia("bolivia");
        }
    }
}