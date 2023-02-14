using System;

namespace StudyCase
{
    public class Rectangulo
    {

        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        /*Getters / Setters*/
    }

    public class CalculadorArea
    {

        public double calcularArea(Rectangulo rectangulo)
        {
            return rectangulo.Base * rectangulo.Altura;
        }
    }

    public class App
    {

        public static void Main(String[] args)
        {

            CalculadorArea calcArea = new CalculadorArea();
            Rectangulo rec1 = new Rectangulo(13.5, 14);
            Rectangulo rec2 = new Rectangulo(7.89, 9.85);

            Console.WriteLine("Calculo de rectangulo 1: " + calcArea.calcularArea(rec1));
            Console.WriteLine("Calculo de rectangulo 2: " + calcArea.calcularArea(rec2));
        }
    }
}