using System;

namespace AppliedPrinciple
{
    public class Rectangulo : IFiguraGeometrica
    {
        private double Base { get; set; }
        private double Altura { get; set; }

        public Rectangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public double calcularArea()
        {
            return this.Base * this.Altura;
        }
    }

    public class Cuadrado : IFiguraGeometrica
    {

        private double Lado { get; set; };

        public Cuadrado(double Lado)
        {
            this.Lado = Lado;
        }

        public double calcularArea()
        {
            return this.Lado * this.Lado;
        }
    }

    public class Circulo : IFiguraGeometrica
    {

        public static double PI = 3.1416;
        private double Radio;

        public Circulo(double Radio)
        {
            this.Radio = Radio;
        }

        public double calcularArea()
        {
            return (Circulo.PI * (this.Radio * this.Radio));
        }
    }

    public interface IFiguraGeometrica
    {
        double calcularArea();
    }

    public class CalculadorArea
    {
        public double calcularArea(IFiguraGeometrica figura)
        {
            return figura.calcularArea();
        }
    }

    public class App
    {
        public static void Main(String[] args)
        {

            CalculadorArea calcArea = new CalculadorArea();
            Cuadrado cuadrado = new Cuadrado(3.15);
            Rectangulo rectangulo = new Rectangulo(7.85, 10.85);
            Circulo circulo = new Circulo(7.98);

            Console.WriteLine("Calculo de figura: " + calcArea.calcularArea(cuadrado));
            Console.WriteLine("Calculo de figura: " + calcArea.calcularArea(rectangulo));
            Console.WriteLine("Calculo de figura: " + calcArea.calcularArea(circulo));
        }
    }
}