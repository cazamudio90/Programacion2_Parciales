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
            ListaDeProductos.Add(new Producto("abc", "Zucaritas 500 grm", 10, 200) );
            ListaDeProductos.Add(new Producto("abc", "Azucar 500 grm", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Mentos", 10, 35) );
            ListaDeProductos.Add(new Producto("abc", "Beldent", 10, 20) );
            ListaDeProductos.Add(new Producto("abc", "Halls", 10, 20) );
            ListaDeProductos.Add(new Producto("abc", "Levite Pomelo", 10, 85) );
            ListaDeProductos.Add(new Producto("abc", "Levite Manzana", 10, 85) );
            ListaDeProductos.Add(new Producto("abc", "Yerba Mate Rosamonte 1 k", 10, 175) );
            ListaDeProductos.Add(new Producto("abc", "Coca-Cola 2.25 lts", 10, 175) );
            ListaDeProductos.Add(new Producto("abc", "Cafe Dolca ", 10, 275) );
            ListaDeProductos.Add(new Producto("abc", "Alfajor Jorgito negro", 10, 55) );
            ListaDeProductos.Add(new Producto("abc", "Alfajor Jorgito blanco", 10, 55) );
            ListaDeProductos.Add(new Producto("abc", "Alfajor Jorgelin blanco", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Alfajor Jorgelin negro", 10, 75) );
            ListaDeProductos.Add(new Producto("abc", "Queso Rallado 500 grm", 10, 255) );
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
            List<Producto> listaVentaProd = new List<Producto>();

            for (int i = 0; i < ListaDeProductos.Count; i++)
            {
                if (i == 1)
                {
                    if (listaVentaProd + (new Producto("abc", ListaDeProductos[1].NombreDeProducto, (ListaDeProductos[1].Precio * 2), 2)) &&
                        listaVentaProd + (new Producto("abc", ListaDeProductos[2].NombreDeProducto, ListaDeProductos[2].Precio * 3, 3)) &&
                        listaVentaProd + (new Producto("abc", ListaDeProductos[4].NombreDeProducto, ListaDeProductos[3].Precio * 4, 4)) &&
                        listaVentaProd + (new Producto("abc", ListaDeProductos[4].NombreDeProducto, ListaDeProductos[4].Precio * 5, 5)))
                    {
                        ListaDeVentas.Add(new Venta("Juan", "Perez", 18356888, listaVentaProd, "czamudio"));
                        listaVentaProd.Clear();
                    }
                }
                if (i == 2)
                {
                    if (listaVentaProd + (new Producto("abc", ListaDeProductos[5].NombreDeProducto, (ListaDeProductos[5].Precio * 2), 2)) &&
                        listaVentaProd + (new Producto("abc", ListaDeProductos[6].NombreDeProducto, ListaDeProductos[6].Precio * 3, 3)) &&
                        listaVentaProd + (new Producto("abc", ListaDeProductos[7].NombreDeProducto, ListaDeProductos[7].Precio * 4, 4)) &&
                        listaVentaProd + (new Producto("abc", ListaDeProductos[8].NombreDeProducto, ListaDeProductos[8].Precio * 5, 5)))
                    {
                        ListaDeVentas.Add(new Venta("Roman", "Martinez", 18356888, listaVentaProd, "czamudio"));
                        listaVentaProd.Clear();
                    }
                }
                if (i == 3)
                {
                    if (listaVentaProd + (new Producto("abc", ListaDeProductos[9].NombreDeProducto, (ListaDeProductos[9].Precio * 2), 2)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[10].NombreDeProducto, ListaDeProductos[10].Precio * 3, 3)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[11].NombreDeProducto, ListaDeProductos[11].Precio * 4, 4)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[12].NombreDeProducto, ListaDeProductos[12].Precio * 5, 5)))
                    {
                        ListaDeVentas.Add(new Venta("Diego", "Forlan", 18356888, listaVentaProd, "Admin"));
                        listaVentaProd.Clear();
                    }
                }
                if (i == 4)
                {
                    if (listaVentaProd + (new Producto("abc", ListaDeProductos[13].NombreDeProducto, (ListaDeProductos[13].Precio * 2), 2)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[14].NombreDeProducto, ListaDeProductos[14].Precio * 3, 3)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[15].NombreDeProducto, ListaDeProductos[15].Precio * 4, 4)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[16].NombreDeProducto, ListaDeProductos[16].Precio * 5, 5)))
                    {
                        ListaDeVentas.Add(new Venta("Sergio", "Aguero", 18356888, listaVentaProd, "Admin"));
                        listaVentaProd = null;
                        break;
                    }
                }
              /*  if (i >= 17 && i <= 20)
                {
                    if (listaVentaProd + (new Producto("abc", ListaDeProductos[i + 1].NombreDeProducto, (ListaDeProductos[i + 1].Precio * 2), 2)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i + 1].NombreDeProducto, ListaDeProductos[i + 1].Precio * 3, 3)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i + 1].NombreDeProducto, ListaDeProductos[i + 1].Precio * 4, 4)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i + 1].NombreDeProducto, ListaDeProductos[i + 1].Precio * 5, 5)))
                    {
                        ListaDeVentas.Add(new Venta("Silvio", "Romero", 18356888, listaVentaProd));
                        listaVentaProd = null;
                    }
                }
                if (i >= 4)
                {
                    if (listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, (ListaDeProductos[i+1].Precio * 2), 2)) &&
                          listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 3, 3)) &&
                          listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 4, 4)) &&
                          listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 5, 5)))
                    {
                        ListaDeVentas.Add(new Venta("Alan", "Velazco", 18356888, listaVentaProd));
                        listaVentaProd = null;
                    }
                }
                if (i >= 5 && i <= 12)
                {
                    if (listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, (ListaDeProductos[i+1].Precio * 2), 2)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 3, 3)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 4, 4)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 5, 5))&&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, (ListaDeProductos[i+1].Precio * 2), 2)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 3, 3)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 4, 4)) &&
                       listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 4, 4)))
                    {
                        ListaDeVentas.Add(new Venta("Pablo", "Hernandez", 18356888, listaVentaProd));
                        listaVentaProd = null;
                    }
                }
                if (i >= 13 && i <= 16)
                {
                    if (listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, (ListaDeProductos[i+1].Precio * 2), 2)) &&
                          listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 3, 3)) &&
                          listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 4, 4)) &&
                          listaVentaProd + (new Producto("abc", ListaDeProductos[i+1].NombreDeProducto, ListaDeProductos[i+1].Precio * 5, 5)))
                    {
                        ListaDeVentas.Add(new Venta("Roman", "Martinez", 18356888, listaVentaProd));
                        listaVentaProd = null;
                    }
                 }*/
            }
        }
       /* public static bool AgregarProducto(List<Producto> p_lista_prod, Producto p_producto)
        {
            bool v_return = false;

            if (p_lista_prod + p_producto)
            {
                v_return = true;
            }

            return v_return;
        }*/
       
        public static void CargarEmpleados()
        {
            ListaEmleados.Add(new Empleado("Carlos", "Zamudio", 35127002, "czamudio", "pass1234"));
            ListaEmleados.Add(new Empleado("Admin", "Admin", 12345678, "Admin", "pass1234"));
        }
    }
}
