using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaC
{
    class Carrito
    {
        public List<Articulo> Lista { get; private set; } = new List<Articulo>();

        public void AgregarArticulo(Articulo articulo)
        {
            Lista.Add(articulo);
        }
    }
}