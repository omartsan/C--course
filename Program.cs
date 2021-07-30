using System;

namespace EA
{

    class Factura
    {

        public Factura()
        {


        }

        private string num_pieza;
        public string Num_pieza
        {
            get { return num_pieza; }
            set { num_pieza = value; }
        }


        private string desc_pieza;

        public string Desc_pieza
        {
            get { return desc_pieza; }
            set { desc_pieza = value; }
        }

        private int cant_articulos;

        public int Cant_articulos
        {
            get { return cant_articulos; }
            set
            {
                if (cant_articulos < 0)
                {
                    cant_articulos = 0;
                }
                else
                {
                    cant_articulos = value;
                }

            }
        }

        private double precio;
        public double Precio
        {
            get { return precio; }
            set
            {
                if (precio < 0)
                {
                    precio = 0.0;
                }
                else
                {
                    precio = value;
                }

            }
        }



        public void obtenerMontoFactura(string _nump, string desc, double _precio, int _cantidad)
        {
            double monto_factura;

            monto_factura = _precio * _cantidad;


            Console.WriteLine("-------*---------* RESUMEN DE FACTURA *----------*---------*");


            Console.WriteLine("Numero de pieza: " + _nump);

            Console.WriteLine("Descripcion de pieza: " + desc);

            Console.WriteLine("Precio de pieza: " + _precio);

            Console.WriteLine("Cantidad de piezas: " + _cantidad);



            Console.WriteLine("El monto de la factura es :" + monto_factura);


        }

       


        ~Factura()
        {
            num_pieza = null;
            desc_pieza = null;
            cant_articulos = 0;
            precio = 0;
           

        }


        class MainClass
        {
            public static void Main(string[] args)
            {
                


                Factura factura1 = new Factura();

                Console.WriteLine("Ingresa el numero de pieza:");

                factura1.Num_pieza = Console.ReadLine();


                Console.WriteLine("Ingresa la descripcion de la pieza:");

                factura1.Desc_pieza = Console.ReadLine();

                Console.WriteLine("Ingresa la cantidad de articulos de la factura:");

                factura1.Cant_articulos = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Ingresa el precio por articulo:");

              factura1.Precio = Convert.ToDouble(Console.ReadLine());

                factura1.obtenerMontoFactura(factura1.Num_pieza, factura1.Desc_pieza, factura1.Precio, factura1.Cant_articulos);


            }
        }
    }
}