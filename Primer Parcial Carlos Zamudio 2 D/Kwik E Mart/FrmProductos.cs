using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwik_E_Mart
{
    public partial class FrmProductos : Form
    {
        Producto producto;
        public FrmProductos()
        {
            InitializeComponent();
        }

        public Producto Producto
        {
            get { return producto; }  
        }

        private void btnAceptarProducto_Click(object sender, EventArgs e)
        {
            float auxPrecio;
            int auxUnidades;
            if (float.TryParse(this.txtPrecio.Text, out auxPrecio) && int.TryParse(this.txtUnidadesProducto.Text, out auxUnidades))
            {
                producto = new Producto(this.txtCodigo.Text, this.txtProducto.Text, auxPrecio, auxUnidades);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tienes el precio o las unidades incorrectas");
            }
        }
    }
}
