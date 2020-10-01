using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Kwik_E_Mart
{
    public partial class FrmCliente : Form
    {
        Cliente cliente;
        List<Producto> listaDeVentas;
        Producto v_producto;
        Venta venta;
        public FrmCliente()
        {
            InitializeComponent();
        }

        public Cliente Cliente
        {
            get { return cliente; }
        }

        public Venta Venta
        {
            get { return venta; }
        }

        #region Alta Cliente
        private void chbExisteCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbExisteCliente.Checked == true)
            {
                this.txtApellidoCliente.Enabled = false;
                this.txtNombreCliente.Enabled = false;
                this.txtDniCliente.Enabled = false;
                this.txtNombreCliente.Text = null;
                this.txtApellidoCliente.Text = null;
                this.txtDniCliente.Text = null;
                this.lblClienteEnBase.Show();
                this.cbCliente.Show();
                this.btnAceptarCliente.Hide();
                this.cbCliente.DataSource = KwikEMart.ListaDeClientes;
                this.cbCliente.DisplayMember = "dni";
                this.cbCliente.Enabled = true;
            }
            else
            {
                this.txtApellidoCliente.Enabled = true;
                this.txtNombreCliente.Enabled = true;
                this.txtDniCliente.Enabled = true;
                this.cbCliente.DataSource = null;

                if (this.Text != "Ventas")
                {
                    this.lblClienteEnBase.Hide();
                    this.cbCliente.Hide();
                }
                else
                {
                    this.cbCliente.Enabled = false;
                }
            }
            

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            if (this.Text != "Ventas")
            {
                this.lblClienteEnBase.Hide();
                this.cbCliente.Hide();
                this.chbExisteCliente.Hide();
                this.lblClienteExistente.Hide();
            }
            else
            {
                this.btnAceptarCliente.Hide();
                this.lblClienteEnBase.Show();
                this.cbCliente.Show();
                this.cbCliente.Enabled = false;
                this.cbProductos.DataSource = KwikEMart.ListaDeProductos;
                this.cbProductos.DisplayMember = "nombreDeProducto";
                listaDeVentas = new List<Producto>();
            }
        }

        private void btnAceptarCliente_Click_1(object sender, EventArgs e)
        {
            int auxDni;
            
            if ( int.TryParse(this.txtDniCliente.Text, out auxDni) )
            {
                cliente = new Cliente(this.txtNombreCliente.Text, this.txtApellidoCliente.Text, auxDni);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Dni Incorrecto");
            }
        }
        #endregion

        #region Ventas

        private void btnAgregarProdVenta_Click(object sender, EventArgs e)
        {
            int indice = this.cbProductos.SelectedIndex;
            int v_cant;
            this.dgvProductoVentas.DataSource = null;
            StringBuilder sb = new StringBuilder();



            if (this.cbProductos.SelectedItem.ToString() != "" && this.nUpDUnidades.Value != 0 && int.TryParse(this.nUpDUnidades.Value.ToString(), out v_cant) )
            {
                foreach (Producto item in KwikEMart.ListaDeProductos)
                {
                    v_producto = (Producto)this.cbProductos.SelectedItem;

                    if (item.NombreDeProducto == v_producto.NombreDeProducto) 
                    {
                        if (v_cant <= v_producto.CantidadDeUnidades)
                        {
                            if ( this.listaDeVentas + new Producto("abc", v_producto.NombreDeProducto, v_producto.Precio * v_cant, v_cant))
                            {
                                KwikEMart.BajarStock(KwikEMart.ListaDeProductos, v_producto.NombreDeProducto, v_cant);
                                
                                MessageBox.Show("Se Agrego Un Producto");
                            }
                        }
                        else
                        {
                            sb.AppendFormat("Error, No hay tantas unidades de estre Producto, hay {0} unidades disponibles", v_producto.CantidadDeUnidades.ToString());
                            MessageBox.Show(sb.ToString());
                        }
                        
                    }
                }
                this.dgvProductoVentas.DataSource = this.listaDeVentas;
            }
        }

        private void btnAceptarCliente_Click(object sender, EventArgs e)
        {
            int auxDni;
            Cliente v_venta;

            if (this.chbExisteCliente.Checked == false)
            {
                if (int.TryParse(this.txtDniCliente.Text, out auxDni))
                {
                    cliente = new Cliente(this.txtNombreCliente.Text, this.txtApellidoCliente.Text, auxDni);
                    venta = new Venta(this.txtNombreCliente.Text, this.txtApellidoCliente.Text, auxDni, listaDeVentas, KwikEMart.empleadoLogIn.Username);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (this.cbCliente.SelectedItem.ToString() != "")
                {
                    foreach (Cliente item in KwikEMart.ListaDeClientes)
                    {
                        v_venta = (Cliente)this.cbCliente.SelectedItem;
                        
                        if (item.Dni == v_venta.Dni)
                        {
                            venta = new Venta(v_venta.Nombre, v_venta.Apellido, v_venta.Dni, this.listaDeVentas, KwikEMart.empleadoLogIn.Username);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
        }
        #endregion
    }
}
