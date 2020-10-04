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
    public partial class FrmEmpleado : Form
    {
        Empleado empleado;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        public Empleado Empleado
        {
            get { return empleado; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int auxDni;
            
            if (int.TryParse(this.txtDni.Text, out auxDni) )
            {
                empleado = new Empleado( this.txtNombre.Text, this.txtApellido.Text, auxDni, this.txtUsername.Text, this.txtPassword.Text);
                this.DialogResult =  DialogResult.OK;
            }
        }
    }
}
