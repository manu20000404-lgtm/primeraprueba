namespace TiendaPOO
{
    public class DetalleVenta
    {
        public Producto Producto { get; private set; }
        public int Cantidad { get; private set; }
        public double PrecioUnitario { get; private set; }

        public DetalleVenta(Producto producto, int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException(
                    "La cantidad debe ser mayor que cero.");
            }

            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = producto.Precio;
        }

        public double Subtotal()
        {
            return Cantidad * PrecioUnitario;
        }
    }
}
