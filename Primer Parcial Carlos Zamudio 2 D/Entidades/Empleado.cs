using System;
using System.CodeDom;
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

        public Empleado(string p_nombre, string p_apellido, int p_dni, string p_user, string p_pass) : base(p_nombre, p_apellido, p_dni)
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

        public static bool operator +(List<Empleado> list_empleado, Empleado p_empleado)
        {
            bool v_return = false;

            list_empleado.Add(p_empleado);
            v_return = true;

            return v_return;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se agrego el Empleado:");
            sb.AppendFormat("Nombre: {0}\r\n", this.nombre);
            sb.AppendFormat("Apellido : {0}\r\n", this.apellido);
            sb.AppendFormat("DNI : {0}\r\n", this.dni.ToString());

            return sb.ToString();
        }
    }
}
