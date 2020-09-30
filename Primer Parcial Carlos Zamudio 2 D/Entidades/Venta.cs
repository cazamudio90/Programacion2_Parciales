using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta : Cliente
    {
        int idVenta;
        List<Producto> listaDeProductos;
        string usernameVenta;
        DateTime fechaDeVenta;


        public Venta(string p_nombre, string p_apellido, int p_dni, List<Producto> p_listProductos, string p_user ):base (p_nombre, p_apellido, p_dni)
        {
            listaDeProductos = new List<Producto>();
            fechaDeVenta = DateTime.Now;
            this.idVenta = getID();
            this.listaDeProductos = p_listProductos;
            this.usernameVenta = p_user;
        }

        public List<Producto> ListaDeProductos 
        {
            get 
            { 
                return listaDeProductos;
            }
        }

        public int IdVenta 
        {
            get { return idVenta; }
        }

        public string UsernameVenta
        {
            get { return usernameVenta; }
        }

        public DateTime FechaDeVenta
        {
            get { return fechaDeVenta; }
        }


        private int getID()
        {
            int id = KwikEMart.ListaDeVentas.Count + 1;
            return id;
        }


        public static bool operator +(List<Venta> p_venta_lista, Venta p_venta)
        {
            bool v_return = false;

            /*if (p_producto_lista != null)
            {*/
            p_venta_lista.Add(p_venta);
            v_return = true;
            //  }

            return v_return;
        }
    }
}
