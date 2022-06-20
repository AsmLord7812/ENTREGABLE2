using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTREGABLE2
{
    internal class Program
    {
        const double PLUS = 1.10;
        static void Main(string[] args)
        {
            repartidor rep1 = new repartidor("Ivan", 30, 20.40, "Zona 1");
            Console.WriteLine(rep1.ToString());

            repartidor rep2 = new repartidor("Ulises", 20, 10.00, "Zona 1");
            Console.WriteLine(rep2.ToString());

            comercial com1 = new comercial("Raul", 40, 20.00, 150);
            Console.WriteLine(com1.ToString());

            comercial com2 = new comercial("Alberto", 40, 20.00, 250);
            Console.WriteLine(com2.ToString());

            Console.Read();
        }
    }

    public class Empleado
    {
        public double PLUS = 1.10;

        protected String Nombre { get; set; }
        protected int Edad { get; set; }
        protected double Salario { get; set; }

        public Empleado() 
        {
            Nombre = "Nombre";
            Edad = 0;
            Salario = 0.0;
        }
        public Empleado(String eNombre, int eEdad, double eSalario)
        {
            this.Nombre = eNombre;
            this.Edad = eEdad;
            this.Salario = eSalario;
        }

        public override string ToString() =>
            $"Nombre: {this.Nombre} Edad: {this.Edad} Salario: {this.Salario}";

    }

    public class repartidor : Empleado
    {
        protected String mZona { get; set; }

        public repartidor() { }
        public repartidor(String Nombre, int Edad, double Salario, String Zona)
        {
            this.Nombre = Nombre;
            this.Edad= Edad;
            this.Salario= Salario;
            this.mZona = Zona;
        }

        public double plus ()
        {
            if(Edad < 23 && mZona == "Zona 1")
            {
                return Salario * PLUS;
            }
            else
            {
                return Salario;
            }
        }

        public override String ToString() =>
            $"Repartidor -> {base.ToString()} Zona: {this.mZona} plus: {this.plus()}";
    }

    public class comercial : Empleado
    {
        protected double mComision { get; set; }

        public comercial() { }
        public comercial(String Nombre, int Edad, double Salario, double Comision)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Salario = Salario;
            this.mComision = Comision;
        }

        public double plus()
        {
            if (Edad > 30 && mComision > 200)
            {
                return Salario * PLUS;
            }
            else
            {
                return Salario;
            }
        }

        public override String ToString() =>
            $"Comercial ->{base.ToString()} Comisión: {this.mComision} plus: {this.plus()}";
    }
}
