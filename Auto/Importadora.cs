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
        // b) Ver si alguno de los automóviles es “Toyota” en el objeto Importadora
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
        // c) Verificar si la placa del objeto automóvil existe en el Objeto Importadora.
        public String verificarPlaca(AutoMovil a)
        {
            Console.WriteLine("---- c) Verificar si la placa del objeto automóvil existe en el Objeto Importadora. ----");
            for (int i = 0; i < nroAutos; i++)
            {
                if (this.a[0, i].Equals(a.Placa))
                    return "si exite";
            }
            return "no exite";
        }
        // d) Cuantos automoviles tienen procedencia del país X
        public void paisProcedencia(String paisX)   
        {
            Console.WriteLine("---- d) Cuantos automoviles tienen procedencia del país X ----");
            int c = 0;
            for (int i = 0; i < nroAutos; i++)
            {
                if (this.a[1, i].Equals(paisX))
                    c++;
            }
            Console.WriteLine("los vehiculos del pais: "+paisX+" son: "+c);
        }
        
    }
}