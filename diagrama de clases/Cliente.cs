using System;
using System.Collections.Generic;

namespace TiendaPOO
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        private List<Venta> historialVentas;

        public Cliente(string id, string nombre, string email)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            historialVentas = new List<Venta>();
        }

        public void AgregarVenta(Venta venta)
        {
            historialVentas.Add(venta);
        }

        public List<Venta> HistorialCompras()
        {
            return historialVentas;
        }

        public void MostrarHistorial()
        {
            Console.WriteLine($"\n--- Historial de {Nombre} ---");

            foreach (Venta venta in historialVentas)
            {
                Console.WriteLine(
                    $"Venta {venta.Numero}: ${venta.CalcularTotal():N0}");
            }
        }
    }
}
