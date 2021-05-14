using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo14
{
    // clase con funciones (y no quiero campos o popiedades)
    // clases de servicio.

    // las funciones = se refieren a verbos o acciones

    // Entity framework


    class ProductoServicio
    {
        public void MostrarProducto(Producto prod)
        {
            Console.WriteLine(prod.Nombre);
        }
        public int Calcular()
        {
            // operacion pendiente
            return 0;
        }
    }
}
