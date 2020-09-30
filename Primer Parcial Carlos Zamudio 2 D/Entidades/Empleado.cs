using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        string username;
        string password;

        public Empleado(string p_nombre, string p_apellido, int p_dni, string p_user, string p_pass) :base ( p_nombre, p_apellido, p_dni)
        {
            this.username = p_user;
            this.password = p_pass;
        }

        public string Username 
        {
            get { return username; }
        }

        public string Password 
        {
            get { return password; } 
        }
    }
}
