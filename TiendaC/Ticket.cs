using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaC
{
    //• Lista de articulos
    //• IVA
    //• Total, Pagado y cambio
    //• Fecha
    //• Numero de compra
    class Ticket
    {
        public List<Articulo> Lista { get; set; }
        public decimal Total { get; set; }
        public decimal Pagado { get; set; }
        public decimal Cambio { get; set; }
        public DateTime Fecha { get; set; }
        public int NumCompra { get; set; }
        public decimal IVA { get; set; }

        public Ticket(List<Articulo> lista, decimal total, decimal pagado, decimal cambio, int numCompra, decimal iva)
        {
            Lista = lista;
            Total = total;
            Pagado = pagado;
            Cambio = cambio;
            NumCompra = numCompra;
            IVA = iva;
            Fecha = DateTime.Now;
        }

        public void ImprimirTicket()
        {
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Numero de compra: {NumCompra}");
            Console.WriteLine("Artículos:");
            foreach (var articulo in Lista)
            {
                Console.WriteLine($"{articulo.Nombre} - {articulo.Precio:F2} - Cantidad: {articulo.Cantidad} - Total: {(articulo.Precio * articulo.Cantidad):F2}");
            }
            Console.WriteLine($"IVA: {IVA:F2}");
            Console.WriteLine($"Total: {Total:F2}");
            Console.WriteLine($"Pagado: {Pagado:F2}");
            Console.WriteLine($"Cambio: {Cambio:F2}");
        }
    }
}