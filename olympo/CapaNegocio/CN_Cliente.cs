using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Cliente
    {


        private CD_Cliente objCD = new CD_Cliente();

        public DataTable MostrarClie()
        {
            DataTable tabla = new DataTable();
            tabla = objCD.Mostrar();
            return tabla;
        }

        public void InsertarClie(string documento, string tipoDoc, string nombre1, string nombre2, string apellido1, string apellido2, string direccion, string correo, string telefono, string contactoEmergencia, string telefonoContacto, string foto, string observacionesMedicas)
        {
            objCD.Insertar(documento, tipoDoc, nombre1, nombre2, apellido1, apellido2, direccion, correo, telefono, contactoEmergencia, telefonoContacto, foto, observacionesMedicas);
        }

        public void EditarClie(string idCliente, string documento, string tipoDoc, string nombre1, string nombre2, string apellido1, string apellido2, string direccion, string correo, string telefono, string contactoEmergencia, string telefonoContacto, string foto, string observacionesMedicas)
        {
            objCD.Editar(Convert.ToInt32(idCliente), documento, tipoDoc, nombre1, nombre2, apellido1, apellido2, direccion, correo, telefono, contactoEmergencia, telefonoContacto, foto, observacionesMedicas);
        }
        public void EliminarClie(string idCliente)
        {
            objCD.Eliminar(Convert.ToInt32(idCliente));
        }


    }
}
