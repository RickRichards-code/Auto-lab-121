using System;

namespace Auto
{
    public class Importadora
    {
        private String nombre, edad;
        private int telf,nroAutos;
        private String [,] a = new String[3, 30];

        public Importadora(string nombre, string edad, int telf)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.telf = telf;
            this.nroAutos = 4;
            this.a[0,0] = "ADF-1634";
            this.a[0,1] = "AGF-1634";
            this.a[0,2] = "AGD-1634";
            this.a[0,3] = "AEW-1634";
            this.a[1,0] = "bolivia";
            this.a[1,1] = "argentina";
            this.a[1,2] = "bolivia";
            this.a[1,3] = "argentina";
            this.a[2,0] = "toyota";
            this.a[2,1] = "nissan";
            this.a[2,2] = "tesla";
            this.a[2,3] = "volvo";
        }

        public void mostrar()
        {
            Console.WriteLine("---- importadora ----");
            for (int i = 0; i < nroAutos; i++)
            {
                Console.WriteLine(" -- auto -- ");
                Console.WriteLine("placa: "+a[0,i]);
                Console.WriteLine("pais: "+a[1,i]);
                Console.WriteLine("marca: "+a[2,i]);
            }
        }
        // SOBRECARGAR UN METODO PARA:
        // SOBRECARGA a) Ver si alguno de los automóviles es “Toyota” en el objeto Importadora
        public String verificar(String marcaX)
        {
            Console.WriteLine("---- b) Ver si alguno de los automóviles es “Toyota” en el objeto Importadora ----");
            for (int i = 0; i < nroAutos; i++)
            {
                if (this.a[2, i].Equals(marcaX))
                {
                    return ("si hay un automovil de la marca: "+ marcaX);
                }
            }
            return "no hay esa marca en la importadora";
        }
        // SOBRECARGA b) Verificar si la placa del objeto automóvil existe en el Objeto Importadora.
        public String verificar(AutoMovil a)
        {
            Console.WriteLine("---- c) Verificar si la placa del objeto automóvil existe en el Objeto Importadora. ----");
            for (int i = 0; i < nroAutos; i++)
            {
                if (this.a[0, i].Equals(a.Placa))
                    return "si exite";
            }
            return "no exite";
        }
        // SOBRECARGAR OPERADORES PARA:
        // SOBRECARGA OPERADOR a.1) Cuantos automoviles tienen procedencia del país X
        public static int operator /(Importadora h, String paisX)   
        {
            Console.WriteLine("---- d) Cuantos automoviles tienen procedencia del país X ----");
            int c = 0;
            for (int i = 0; i < h.nroAutos; i++)
            {
                if (h.a[1, i].Equals(paisX))
                    c++;
            }
            Console.WriteLine("los vehiculos del pais: "+paisX+" son: ");
            return c;
        }
        // SOBRECARGA b.1) Agregar k automoviles al Objeto importadora
        public static String operator -(Importadora h, int k)
        {
            int f = 0;
            for (int i = 0; i < k+1; i++)
            {
                f = h.nroAutos + i; 
                h.a[0,f] = "BAFA3-314";
                h.a[1,f] = "bolivia";
                h.a[2,f] = "tesla";
            }
            h.nroAutos = f;
            h.mostrar();
            return ("numero de autos aumentados: " + k);
        }
        
    }
}