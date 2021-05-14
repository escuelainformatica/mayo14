using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo14
{
    // Programacion orientada a objeto OOP
    // ????
    // 1) Clases deben partir en mayuscula.
    // 2) los campos deben ser privados.

    // clase con campos/propiedades y funciones = clase de dominio / objetos de negocios.

    // clase con campos/propiedades = clase de modelo (MVC)


    class Producto
    {
        private string campo;

        // propiedades (union de un campo con dos funciones)
        public string Nombre {set; get; }
        public int Precio {set; get; }
       
    }
}
