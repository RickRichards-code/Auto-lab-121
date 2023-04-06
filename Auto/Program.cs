using System;

namespace Auto
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AutoMovil a1 = new AutoMovil("zzz","hilux","AGD-1634",513.13,2022);
            Importadora h1 = new Importadora("toyosa", "30", 8324234);
            Console.WriteLine(h1.verificar("toyota"));
            Console.WriteLine(h1.verificar(a1));
            String paisX = "bolivia";
            Console.WriteLine(h1+paisX);
            int k = 4;
            Console.WriteLine(h1-k);    
        }
    }
}