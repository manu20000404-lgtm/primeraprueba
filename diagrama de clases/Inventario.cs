using System;
using System.Collections.Generic;

namespace TiendaPOO
{
    public class Inventario
    {
        // Se utiliza SortedList para buscar el stock por código de producto.
        // Además, mantiene los productos ordenados por su código.
        private SortedList<string, Stock> stocks;

        public Inventario()
        {
            stocks = new SortedList<string, Stock>();
        }

        public void AgregarProducto(Producto producto, int cantidadInicial, int stockMinimo)
        {
            if (stocks.ContainsKey(producto.Codigo))
            {
                throw new InvalidOperationException(
                    "Ya existe un producto con ese código.");
            }

            Stock nuevoStock = new Stock(
                producto,
                cantidadInicial,
                stockMinimo);

            stocks.Add(producto.Codigo, nuevoStock);
        }

        public void ActualizarStock(string codigo, int cantidad)
        {
            Stock stock = ObtenerStock(codigo);
            stock.ReponerStock(cantidad);
        }

        public int ConsultarStock(string codigo)
        {
            Stock stock = ObtenerStock(codigo);
            return stock.CantidadDisponible;
        }

        public Stock ObtenerStock(string codigo)
        {
            if (!stocks.ContainsKey(codigo))
            {
                throw new KeyNotFoundException(
                    $"No existe un producto con código {codigo}.");
            }

            return stocks[codigo];
        }

        public Producto ObtenerProducto(string codigo)
        {
            return ObtenerStock(codigo).Producto;
        }

        public void DescontarStock(string codigo, int cantidad)
        {
            Stock stock = ObtenerStock(codigo);
            stock.DescontarStock(cantidad);
        }

        public void MostrarInventario()
        {
            Console.WriteLine("\n--- Estado final del inventario ---");

            foreach (KeyValuePair<string, Stock> elemento in stocks)
            {
                Stock stock = elemento.Value;

                Console.WriteLine(
                    $"{stock.Producto.Nombre}: " +
                    $"{stock.CantidadDisponible} unidades " +
                    $"(mínimo: {stock.StockMinimo})");
            }
        }
    }
}
