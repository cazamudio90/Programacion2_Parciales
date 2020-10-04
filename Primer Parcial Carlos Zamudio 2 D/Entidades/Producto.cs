using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string codigo;
        string nombreDeProducto;
        float precio;
        int cantidadDeUnidades;

        public Producto(string p_codigo, string p_NombreDeProducto, float p_precio, int p_cant_unidades)
        {
            this.codigo = p_codigo;
            this.nombreDeProducto = p_NombreDeProducto;
            this.precio = p_precio;
            this.cantidadDeUnidades = p_cant_unidades;
        }

        public string NombreDeProducto 
        { 
          get { return nombreDeProducto; } 
        }

        public float Precio 
        {
            get { return precio; }
        }
        public int CantidadDeUnidades
        {
            get { return cantidadDeUnidades; }
        }

        public static bool operator +(List<Producto> p_producto_lista, Producto p_producto)
        {
            bool v_return = false;

             p_producto_lista.Add(p_producto);
             v_return = true;

            return v_return;
        }

        public void BajarStock(List<Producto> p_lista_productos, Producto p_producto)
        {
            for (int i = 0; i < p_lista_productos.Count; i++)
            {
                if (p_lista_productos[i].NombreDeProducto == p_producto.NombreDeProducto)
                {
                    p_lista_productos[i].cantidadDeUnidades = p_lista_productos[i].cantidadDeUnidades - p_producto.CantidadDeUnidades;
                }
            }
        }
    }
}
