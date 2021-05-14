using System;

namespace Mayo14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // datos de un producto (nombre, precio)
            string nombre="cocacola";
            int precio=500;

            Producto prod=new Producto();
            prod.Nombre="cocacola";
            prod.Precio=500;

            ProductoServicio productoServicio=new ProductoServicio();


            productoServicio.MostrarProducto(prod);

            string texto="123";
            int numero=Convert.ToInt32(texto);

          
            // dos errores: en tiempo de ejecucion
            //              en tiempo de compilacion.

            // Producto prod2=null;
            // prod2.Nombre="fanta";

            // c# clon de java.
            // java --> clono
            

        }
    }
}
