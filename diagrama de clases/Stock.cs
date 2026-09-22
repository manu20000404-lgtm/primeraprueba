namespace TiendaPOO
{
    public class Stock
    {
        private int cantidadDisponible;
        private int stockMinimo;

        public Producto Producto { get; private set; }

        public int CantidadDisponible
        {
            get { return cantidadDisponible; }
        }

        public int StockMinimo
        {
            get { return stockMinimo; }
        }

        public Stock(Producto producto, int cantidadInicial, int stockMinimo)
        {
            if (cantidadInicial < 0)
            {
                throw new ArgumentException(
                    "La cantidad inicial no puede ser negativa.");
            }

            if (stockMinimo < 0)
            {
                throw new ArgumentException(
                    "El stock mínimo no puede ser negativo.");
            }

            Producto = producto;
            cantidadDisponible = cantidadInicial;
            this.stockMinimo = stockMinimo;
        }

        public void ReponerStock(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException(
                    "La cantidad a reponer debe ser mayor que cero.");
            }

            cantidadDisponible += cantidad;
        }

        public bool HayStockSuficiente(int cantidad)
        {
            return cantidad > 0 && cantidadDisponible >= cantidad;
        }

        public void DescontarStock(int cantidad)
        {
            if (!HayStockSuficiente(cantidad))
            {
                throw new InvalidOperationException(
                    $"No hay stock suficiente de {Producto.Nombre}.");
            }

            cantidadDisponible -= cantidad;
        }
    }
}
