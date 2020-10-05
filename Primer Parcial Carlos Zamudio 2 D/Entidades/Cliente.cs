using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
       
        public Cliente(string p_nombre, string p_apellido, int p_dni) : base(p_nombre, p_apellido, p_dni)
        {
           
        }

        public static bool operator +(List<Cliente> p_cliente_lista, Cliente p_cliente)
        {
            bool v_return = false;

            p_cliente_lista.Add(p_cliente);
            v_return = true;

            return v_return;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se agrego el Cliente:");
            sb.AppendFormat("Nombre: {0}\r\n", this.nombre);
            sb.AppendFormat("Apellido : {0}\r\n", this.apellido);
            sb.AppendFormat("DNI : {0}\r\n", this.dni.ToString());
            sb.AppendLine("Desea Agregar Otro");

            return sb.ToString();
        }
    }
}
