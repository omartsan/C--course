using System;

namespace U1
{

     class Empleado
    {

        private int num_empleado;
        public int Num_empleado
        {
            get { return num_empleado; }
            set { Num_empleado = value; }
        }


        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int num_telefono;

        public int Num_telefono
        {
            get { return num_telefono; }
            set { num_telefono = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private double salario;

        public double Salario
        {
            get { return salario; }
            set
            {
                if (salario < 0)
                {
                    salario = 0.0;
                }
                else
                {
                    salario = value;
                }

            }
        }

        private double bono;
        public double Bono
        {
            get { return bono; }
            set
            {
                if (bono < 0)
                {
                    bono = 0.0;
                }
                else
                {
                    bono = value;
                }

            }
        }



        public void salaroio10(double _salario)
        {
            double salario_nuevo;
            salario_nuevo = _salario + (_salario * .10);
            //return salario_nuevo;
            Console.WriteLine("El salario mas 10% es :" + salario_nuevo);


        }

        public void salario_an(double _salario, double _bono)
        {
            double salario_anual;
            salario_anual = (_salario * 12) + (bono * 12);
            //return salario_anual;
            Console.WriteLine(" El salario anual es: " + salario_anual);


        }


    }

    class MainClass
    {

     

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Empleado empleado1 = new Empleado();
            Console.WriteLine("Ingresa salario:");

            empleado1.Salario=  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa bono:");
            empleado1.Bono= Convert.ToInt32(Console.ReadLine());

            empleado1.salaroio10(empleado1.Salario);
            empleado1.salario_an(empleado1.Salario, empleado1.Bono);


        }
    }

}