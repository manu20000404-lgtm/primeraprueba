namespace TiendaPOO
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }

        // Constructor principal
        public Producto(string codigo, string nombre, double precio, string categoria)
        {
            if (precio < 0)
            {
                throw new ArgumentException("El precio no puede ser negativo.");
            }

            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }

        // Constructor sobrecargado
        public Producto(string codigo, string nombre, double precio)
            : this(codigo, nombre, precio, "General")
        {
        }

        public void MostrarInfo()
        {
            Console.WriteLine(
                $"{Codigo} - {Nombre} | Categoría: {Categoria} | Precio: ${Precio:N0}");
        }
    }
}
