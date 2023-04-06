using System;

namespace Auto
{
    public class AutoMovil
    {
        private String nombre, modelo, placa;
        private double precio;
        private int anio;

        public AutoMovil(string nombre, string modelo, string placa, double precio, int anio)
        {
            this.nombre = nombre;
            this.modelo = modelo;
            this.placa = placa;
            this.precio = precio;
            this.anio = anio;
        }

        public void mostrar()
        {
            Console.WriteLine("---- AutoMovil----");
            Console.WriteLine("nombre:");
        }
        

        public string Nombre => nombre;

        public string Modelo => modelo;

        public string Placa => placa;

        public double Precio => precio;

        public int Anio => anio;
    }
}