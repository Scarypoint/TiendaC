using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaC;

namespace TiendaC
{
    class Catalogo
    {
        private static List<Articulo> Inventario { get; set; }

        private static void LlenarCatalogo()
        {
            Inventario = new List<Articulo>
        {
            new Articulo{Nombre="Jabon", Precio=18.9m, ID=1},
            new Articulo{Nombre="Mayonesa", Precio=45.13m, ID=2},
            new Articulo{Nombre="Tomate", Precio=49.00m, ID=3},
            new Articulo{Nombre="Carne", Precio=98m, ID=4},
            new Articulo{Nombre="Huevos", Precio=65m, ID=5},
        };
        }

        public static void MostrarCatalogo()
        {
            LlenarCatalogo();
            foreach (Articulo art in Inventario)
            {
                Console.WriteLine($"{art.ID} - {art.Nombre} - {art.Precio:F2}");
            }
        }

        public static Articulo BuscarArticuloPorID(int artID)
        {
            return Inventario.Find(articulo => articulo.ID == artID);
        }
    }
}