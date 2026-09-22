using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagrama_de_clases
{
    internal class Tienda
    {
        public class Tienda
{
    // Atributos privados
    private string nombre;
    private string direccion;

    // Propiedades (Getters y Setters)
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }

    // Constructor
    public Tienda(string nombre, string direccion)
    {
        this.nombre = nombre;
        this.direccion = direccion;
    }

    // Métodos del diagrama UML
    public void RegistrarVenta(Venta v)
    {
        // Lógica para registrar la venta
    }

    public Inventario ConsultarInventario()
    {
        // Lógica para retornar el inventario
        return new Inventario();
    }
}
                                           
                }
            }
        }
        
        
            
        }
    }
}
