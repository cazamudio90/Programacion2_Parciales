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
using System.Media;

namespace Kwik_E_Mart
{
    public partial class LogIn : Form
    {
        SoundPlayer player;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
             Bitmap fondoMenu = new Bitmap(Application.StartupPath+@"\img\apu.jpg");
             this.BackgroundImage = fondoMenu;
             this.BackgroundImageLayout = ImageLayout.Stretch;

            player = new SoundPlayer(Application.StartupPath + @"\sonidos\burp-barney-simpson.WAV");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool v_user_enter = false;
            foreach (Empleado item in KwikEMart.ListaEmleados)
            {
                if (item.Username == this.txtUsername.Text && item.Password == this.txtPass.Text)
                {
                    this.DialogResult = DialogResult.OK;
                    v_user_enter = true;
                    KwikEMart.empleadoLogIn = item;
                    player.Play();
                    break;
                }
            }
            if (v_user_enter == false)
            {
                MessageBox.Show("Usuarname / Password incorrecta");
            }
        }
    }
}
