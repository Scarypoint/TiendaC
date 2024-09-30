using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaC
{
    class Caja
    {
        private static int NumCompra = 0;
        private decimal Pagando { get; set; }
        private Carrito Cart { get; set; }
        private decimal Subtotal = 0;
        private decimal Total = 0;

        public Caja() { }

        public void IngresarCarrito(Carrito cart)
        {
            Cart = cart;
            Subtotal = 0;

            foreach (Articulo articulo in cart.Lista)
            {
                Subtotal += articulo.Precio * articulo.Cantidad; // Sumar, no reasignar
            }
            MostrarTotales();
        }

        public void MostrarTotales()
        {
            decimal iva = Subtotal * 0.16m;
            Total = Subtotal + iva;

            Console.WriteLine($"Sub total: {Subtotal:F2}");
            Console.WriteLine($"I.V.A.: {iva:F2}");
            Console.WriteLine($"Total: {Total:F2}");
        }

        public void Cobrar()
        {
            Console.WriteLine("Ingrese cantidad a pagar:");
            Pagando = Convert.ToDecimal(Console.ReadLine());
            decimal cambio = Pagando - Total;

            NumCompra++;
            Ticket ticket = new Ticket(Cart.Lista, Total, Pagando, cambio, NumCompra, Subtotal * 0.16m);
            ticket.ImprimirTicket();
        }
    }
}
