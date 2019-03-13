using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluaciónParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INGRESE FIGURA: ");
            string figura = Console.ReadLine();
            Console.WriteLine();

            if (figura == "triangulo")
            {
                Triangulo tri = new Triangulo();
                tri.NomFigura = "Triángulo";
                tri.PedirDatosTri();
                tri.CalcularAreaTri();
                tri.VisualizarResultado();
            }

            if (figura == "rectangulo")
            {
                Rectangulo rec = new Rectangulo();
                rec.NomFigura = "Rectángulo";
                rec.PedirDatosRec();
                rec.CalcularAreaRec();
                rec.VisualizarResultado();
            }

            if (figura == "circulo")
            {
                Circulo cir = new Circulo();
                cir.NomFigura = "Círculo";
                cir.PedirDatosCir();
                cir.CalcularAreaCir();
                cir.VisualizarResultado();
            }

            else
            {
                Console.WriteLine("Error 406. No ha elegido ninguna figura guardada...");
            }
            Console.ReadKey();
        }
    }

    abstract class Figura
    {
        public string NomFigura { get; set; }
    }

    class Triangulo : Figura
    {
        public double Basetri { get; set; }
        public double Alturatri { get; set; }
        public double Areatri { get; set; }

        public void PedirDatosTri()
        {
            Console.Write("Ingrese datos para el Triángulo");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ingrese Base: ");
            Basetri = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Altura: ");
            Alturatri = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Area: ");
            Basetri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }

        public void CalcularAreaTri()
        {
            double Area = (Basetri * Alturatri) / 2;
            Console.WriteLine("El calculo del Área es: {0}", Area);
            Console.WriteLine();
        }

        public void VisualizarResultado()
        {
            Console.WriteLine("La base es: {0}", Basetri);
            Console.WriteLine("La Altura es: {0}", Alturatri);
            Console.WriteLine("El Área es: {0}", Areatri);
        }
    }

    class Rectangulo : Figura
    {
        double BaseRec { get; set; }
        double AlturaRec { get; set; }
        double AreaRec { get; set; }

        public void PedirDatosRec()
        {
            Console.Write("Ingrese datos para el Rectángulo");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ingrese Base: ");
            BaseRec = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Altura: ");
            AlturaRec = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Area: ");
            BaseRec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }

        public void CalcularAreaRec()
        {
            double Area = BaseRec * AlturaRec;
            Console.WriteLine("El calculo del Área es: {0}", Area);
            Console.WriteLine();
        }

        public void VisualizarResultado()
        {
            Console.WriteLine("La base es: {0}", BaseRec);
            Console.WriteLine("La Altura es: {0}", AlturaRec);
            Console.WriteLine("El Área es: {0}", AreaRec);
        }
    }

    class Circulo : Figura
    {
        double RadioCir { get; set; }
        double Areacir { get; set; }

        public void PedirDatosCir()
        {
            Console.Write("Ingrese datos para el Círculo");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ingrese Radio: ");
            RadioCir = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Área: ");
            Areacir = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }

        public void CalcularAreaCir()
        {
            double Area = 3.1416 * (Math.Pow(RadioCir, 2));
            Console.WriteLine("El calculo del Área es: {0}", Area);
            Console.WriteLine();
        }

        public void VisualizarResultado()
        {
            Console.WriteLine("El radio es: {0}", RadioCir);
            Console.WriteLine("El Área es: {0}", Areacir);
        }
    }
}

