using System;
using TiendaC;

internal static class ProgramHelpers
{
    private static void Main(string[] args)
    {
        bool continuarComprando = true;

        while (continuarComprando)
        {
            Carrito cart = new Carrito();
            bool agregarMasArticulos = true;

            while (agregarMasArticulos)
            {
                Console.WriteLine("Selecciona el artículo");
                Catalogo.MostrarCatalogo();
                int artID = Convert.ToInt32(Console.ReadLine());

                Articulo articuloSeleccionado = Catalogo.BuscarArticuloPorID(artID);
                Console.WriteLine("¿Cuántos va a comprar?");
                articuloSeleccionado.Cantidad = Convert.ToInt32(Console.ReadLine());

                cart.AgregarArticulo(articuloSeleccionado);

                Console.WriteLine("¿Desea agregar otro artículo? (S/N)");
                string respuesta = Console.ReadLine().ToUpper();
                agregarMasArticulos = respuesta == "S";
            }

            Caja caja = new Caja();
            caja.IngresarCarrito(cart);
            caja.Cobrar();

            Console.WriteLine("¿Desea realizar otra compra? (S/N)");
            string respuestaCompra = Console.ReadLine().ToUpper();
            continuarComprando = respuestaCompra == "S";
        }

        Console.WriteLine("Gracias por su compra.");
        Console.ReadLine();
    }
}