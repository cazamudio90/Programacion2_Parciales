using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class KwikEMart
    {
        public static List<Producto> ListaDeProductos = new List<Producto>();
        public static List<Cliente> ListaDeClientes = new List<Cliente>();
        public static List<Venta> ListaDeVentas = new List<Venta>();
        public static List<Empleado> ListaEmleados = new List<Empleado>();
        public static Empleado empleadoLogIn;
        public static void CargarProductos()
        {
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Sprite 1.5", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Fernet Branca 1 lts", 10, 350) );
            ListaDeProductos.Add(new Producto("abc", "Queso Cremon 200 grms", 10, 35) );
            ListaDeProductos.Add(new Producto("abc", "Zucaritas 500 grm", 10, 9) );
            ListaDeProductos.Add(new Producto("abc", "Azucar 500 grm", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Mentos", 10, 35) );
            ListaDeProductos.Add(new Producto("abc", "Beldent", 10, 20) );
            ListaDeProductos.Add(new Producto("abc", "Halls", 10, 20) );
            ListaDeProductos.Add(new Producto("abc", "Levite Pomelo", 10, 85) );
            ListaDeProductos.Add(new Producto("abc", "Levite Manzana", 10, 85) );
            ListaDeProductos.Add(new Producto("abc", "Yerba Mate Rosamonte 1 k", 10, 175) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 2.25 lts", 10, 175) );
            ListaDeProductos.Add(new Producto("abc", "Cafe Dolca ", 10, 275) );
            ListaDeProductos.Add(new Producto("abc", "Alfajor Jorgito negro", 10, 6) );
            ListaDeProductos.Add(new Producto("abc", "Alfajor Jorgito blanco", 10, 55) );
            ListaDeProductos.Add(new Producto("abc", "Alfajor Jorgelin blanco", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Alfajor Jorgelin negro", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Queso Rallado 500 grm", 10, 7) );
            /*ListaDeProductos.Add(new Producto("abc", "", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 1.5 lts", 10, 75) );*/
        }

        public static void CargaClientes()
        {
            ListaDeClientes.Add( new Cliente("Juan", "Perez", 18356888) );
            ListaDeClientes.Add( new Cliente("Pablo", "Rodriguez", 28356888) );
        }

        public static void CargaVentas()
        {
            List<Producto> listBprod = new List<Producto>();
            List<Producto> listBprod2 = new List<Producto>();
            List<Producto> listBprod3 = new List<Producto>();
            List<Producto> listBprod4 = new List<Producto>();

            listBprod.Add(new Producto("abc", "Coca-Cola 1.5 lts", (10 * 2), 2));
            listBprod.Add(new Producto("abc", "Sprite 1.5", 10 * 3, 3));
            listBprod.Add(new Producto("abc", "Fernet Branca 1 lts", 10 * 4, 4));
            listBprod.Add(new Producto("abc", "Cafe Dolca ", 10 * 5, 5));
            
            ListaDeVentas.Add(new Venta("Juan", "Perez", 18356888, listBprod, "czamudio"));

            listBprod2.Add(new Producto("abc", "Queso Cremon 200 grms", 10 * 2, 2));
            listBprod2.Add(new Producto("abc", "Zucaritas 500 grm", 10 * 3, 3));
            listBprod2.Add(new Producto("abc", "Azucar 500 grm", 10 * 4, 4));
            listBprod2.Add(new Producto("abc", "Mentos", 10 * 5, 5));
            
            ListaDeVentas.Add(new Venta("Roman", "Martinez", 18356888, listBprod2, "czamudio"));

            listBprod3.Add(new Producto("abc", "Levite Pomelo", 10 * 2, 2));
            listBprod3.Add(new Producto("abc", "Levite Manzana", 10 * 3, 3));
            listBprod3.Add(new Producto("abc", "Alfajor Jorgelin blanco", 10 * 4, 4));
            listBprod3.Add(new Producto("abc", "Queso Rallado 500 grm", 10 * 5, 5));
           
            ListaDeVentas.Add(new Venta("Diego", "Forlan", 18356888, listBprod3, "Admin"));

            listBprod4.Add(new Producto("abc", "Alfajor Jorgelin negro", 10 * 2, 2));
            listBprod4.Add(new Producto("abc", "Yerba Mate Rosamonte 1 k", 10 * 3, 3));
            listBprod4.Add(new Producto("abc", "Cafe Dolca ", 10 * 4, 4));
            listBprod4.Add(new Producto("abc", "Halls", 10 * 5, 5));
            
            ListaDeVentas.Add(new Venta("Sergio", "Aguero", 18356888, listBprod4, "Admin"));
        }
       
        public static void CargarEmpleados()
        {
            ListaEmleados.Add(new Empleado("Carlos", "Zamudio", 35127002, "czamudio", "pass1234"));
            ListaEmleados.Add(new Empleado("Admin", "Admin", 12345678, "Admin", "pass1234"));
        }

        public static void BajarStock(List<Producto> p_lista_productos, string p_producto, int cant)
        {
            for (int i = 0; i < p_lista_productos.Count; i++)
            {
                if (p_lista_productos[i].NombreDeProducto == p_producto)
                {
                    p_lista_productos[i].CantidadDeUnidades = p_lista_productos[i].CantidadDeUnidades - cant;
                }
            }
        }
    }
}
