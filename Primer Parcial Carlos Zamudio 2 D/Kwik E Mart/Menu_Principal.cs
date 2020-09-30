using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using System.Media;

namespace Kwik_E_Mart
{
    public partial class Menu_Principal : Form
    {

        Venta ventaDescargar;
        SoundPlayer player;
        
        public Menu_Principal()
        {
            InitializeComponent();
            KwikEMart.CargarProductos();
            KwikEMart.CargaClientes();
            KwikEMart.CargaVentas();
            KwikEMart.CargarEmpleados();

        }
        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            LogIn login = new LogIn();

            if (login.ShowDialog() == DialogResult.OK)
            {
                this.dgvMostar.Hide();
                this.lblDataGrid.Hide();
                this.lblTotalVentas.Hide();
                this.lblItems.Hide();
                this.txtTotal.Hide();
                this.txtItems.Hide();
                this.btnDescargartxt.Hide();
                this.cbUsuarios.DataSource = KwikEMart.ListaEmleados;
                this.cbUsuarios.DisplayMember = "username";
                this.lblUsuario.Hide();
                this.cbUsuarios.Hide();
            }
            else
            {
                this.Close();
            }
        }
        private void dgvMostar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            double totalPrecio = 0;
            int cantidad = 0;
            this.dgvListaVentasProd.DataSource = null;
            this.lblTotalVentas.Show();
            this.lblItems.Show();
            this.txtTotal.Show();
            this.txtItems.Show();
            this.btnDescargartxt.Show();


            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvMostar.Rows[e.RowIndex];

                foreach (Venta item in KwikEMart.ListaDeVentas)
                {
                    if (item.IdVenta == int.Parse(row.Cells["IdVenta"].Value.ToString()))
                    {
                        ventaDescargar = item;
                        
                        foreach (Producto item2 in item.ListaDeProductos)
                        {
                            totalPrecio = totalPrecio + item2.Precio;
                            cantidad = cantidad + item2.CantidadDeUnidades;

                        }

                        if (item.Apellido == "Simpson")
                        {
                            totalPrecio = totalPrecio - (totalPrecio * 0.13);
                        }
                        //item.ListaDeProductos.Add(new Producto("", "Total", totalPrecio, cantidad));
                        this.txtTotal.Text = "$"+totalPrecio.ToString();
                        this.txtItems.Text = cantidad.ToString();
                        this.dgvListaVentasProd.DataSource = item.ListaDeProductos;
                        this.dgvListaVentasProd.Show();
                        break;
                    }
                }
            }
        }

        #region Productos

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();

            this.lblDataGrid.Hide();
            this.dgvMostar.Hide();
            this.btnDescargartxt.Hide();
            this.dgvMostar.DataSource = null;
            this.dgvListaVentasProd.Hide();
            this.lblUsuario.Hide();
            this.cbUsuarios.Hide();

            if (frmProductos.ShowDialog() == DialogResult.OK)
            {
                if (KwikEMart.ListaDeProductos + frmProductos.Producto)
                {
                    if (MessageBox.Show("Se agrego un Producto, Desea Agregar mas", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        agregarToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        this.lblDataGrid.Text = "Listado De Productos";
                        this.dgvMostar.DataSource = KwikEMart.ListaDeProductos;
                        this.dgvMostar.AutoResizeColumns();
                        this.dgvMostar.Show();
                        this.lblDataGrid.Show();
                    }
                        
                }
            }
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lblDataGrid.Text = "Lista de Productos";
            this.lblDataGrid.Show();
            this.dgvMostar.DataSource = KwikEMart.ListaDeProductos;
            this.dgvMostar.Show();
            this.btnDescargartxt.Hide();
            this.dgvListaVentasProd.Hide();
            this.lblUsuario.Hide();
            this.cbUsuarios.Hide();
        }

        #endregion

       
        
        #region Clientes

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();

            frmCliente.Size = new Size(500, 450);

            frmCliente.MaximizeBox = false;
            frmCliente.MaximumSize = this.Size;
            frmCliente.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            frmCliente.Text = "Alta Cliente";
            this.dgvMostar.Hide();
            this.lblDataGrid.Hide();
            this.btnDescargartxt.Hide();
            this.dgvListaVentasProd.Hide();
            this.dgvMostar.DataSource = null;
            this.lblUsuario.Hide();
            this.cbUsuarios.Hide();

            if (frmCliente.ShowDialog() == DialogResult.OK)
            {
                if (KwikEMart.ListaDeClientes + frmCliente.Cliente)
                {
                    if(MessageBox.Show("Se agrego el Cliente, Desea Agregar mas", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        agregarToolStripMenuItem1_Click(sender, e);
                    } 
                    this.dgvMostar.DataSource = KwikEMart.ListaDeClientes;
                    this.dgvMostar.AutoResizeColumns();
                    this.dgvMostar.Show();
                    this.lblDataGrid.Show();
                }
            }
        }
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lblDataGrid.Text = "Lista de Clientes";
            this.lblDataGrid.Show();
            this.dgvMostar.DataSource = KwikEMart.ListaDeClientes;
            this.dgvMostar.Show();
            this.btnDescargartxt.Hide();
            this.dgvListaVentasProd.Hide();
            this.lblUsuario.Hide();
            this.cbUsuarios.Hide();
        }

        #endregion

        #region Ventas

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();

            frmCliente.Text = "Ventas";
            this.lblDataGrid.Hide();
            this.dgvMostar.Hide();
            this.dgvListaVentasProd.Hide();
            this.btnDescargartxt.Hide();
            this.lblUsuario.Hide();
            this.cbUsuarios.Hide();

            if (frmCliente.ShowDialog() == DialogResult.OK)
            {
                if(KwikEMart.ListaDeVentas + frmCliente.Venta)
                {

                    player = new SoundPlayer(Application.StartupPath + @"\sonidos\gracias-vuelvas-prontos.WAV");
                    player.Play();
                    MessageBox.Show("“Gracias!! Vuelva prontosss");
                    mostarToolStripMenuItem_Click(sender, e);
                    this.lblUsuario.Show();
                    this.cbUsuarios.Show();
                }
            }


        }

        private void mostarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lblDataGrid.Text = "Lista de Ventas";
            this.dgvMostar.DataSource = null;
           this.lblDataGrid.Show();
            this.dgvMostar.DataSource = KwikEMart.ListaDeVentas;
            this.dgvMostar.Show();
            this.lblUsuario.Show();
            this.cbUsuarios.Show();
        }

        public void HacerFactura(Venta p_venta)
        {

            StringBuilder sb = new StringBuilder();

            TextWriter txt = new StreamWriter(Application.StartupPath + @"\facturas\Factura.txt");
            int v_total_unidades = 0;
            double totalPrecio = 0;

            sb.AppendFormat("Kwik E Mart");
            sb.AppendLine();
            sb.AppendFormat("Nombre  : {0}", p_venta.Nombre);
            sb.AppendLine();
            sb.AppendFormat("Apellido: {0}", p_venta.Apellido);
            sb.AppendLine();
            sb.AppendFormat("Dni     : {0}", p_venta.Dni);
            sb.AppendLine();
            sb.AppendFormat("Fecha   : {0}", p_venta.FechaDeVenta);
            sb.AppendLine();
            sb.AppendFormat("Productos                              Cantidad                              Precio");
            sb.AppendLine();
            foreach (Producto item in p_venta.ListaDeProductos)
            {
                v_total_unidades = v_total_unidades + item.CantidadDeUnidades;
                totalPrecio = totalPrecio + item.Precio;
                sb.AppendFormat("{0}", item.NombreDeProducto);

                for (int i = 0; i < (39 - item.NombreDeProducto.Length); i++)
                {
                    sb.Append(" ");
                }
                sb.AppendFormat("{0}", item.CantidadDeUnidades);
                for (int i = 0; i < (39 - item.CantidadDeUnidades.ToString().Length); i++)
                {
                    sb.Append(" ");
                }
                sb.AppendFormat("{0}", item.Precio);
                for (int i = 0; i < (39 - item.Precio.ToString().Length); i++)
                {
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            if (p_venta.Apellido == "Simpson")
            {
                totalPrecio = totalPrecio - (totalPrecio * 0.13);
            }
            sb.AppendFormat("                                   Unidades {0}                                 Total {1}", v_total_unidades, totalPrecio);

            txt.Write(sb.ToString());
            txt.Close();

            MessageBox.Show("Factura Descargada");
        }
        #endregion

        private void btnDescargartxt_Click(object sender, EventArgs e)
        {
            HacerFactura(ventaDescargar);
        }

        private void cbUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Venta> listaPorUsuarios = new List<Venta>();
            Empleado v_empleado = (Empleado)cbUsuarios.SelectedItem; 

            this.dgvMostar.DataSource = null;

            foreach (Venta item in KwikEMart.ListaDeVentas)
            {
                if (item.UsernameVenta == v_empleado.Username)
                {
                    listaPorUsuarios.Add(item);
                }
            }
            this.dgvMostar.DataSource = listaPorUsuarios;
        }
    }

}
