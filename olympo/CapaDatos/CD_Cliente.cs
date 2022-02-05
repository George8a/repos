using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Cliente
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string documento, string tipoDoc, string nombre1, string nombre2,string apellido1, string apellido2, string direccion, string correo, string telefono, string contactoEmergencia, string telefonoContacto, string foto, string observacionesMedicas)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@tipoDo", tipoDoc);
            comando.Parameters.AddWithValue("@nombre1", nombre1);
            comando.Parameters.AddWithValue("@nombre2", nombre2);
            comando.Parameters.AddWithValue("@apellido1", apellido1);
            comando.Parameters.AddWithValue("@apellido2", apellido2);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@contactoEmergencia", contactoEmergencia);
            comando.Parameters.AddWithValue("@telefonoContacto", telefonoContacto);
            comando.Parameters.AddWithValue("@foto", foto);
            comando.Parameters.AddWithValue("@observacionesMedicas", observacionesMedicas);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        public void Editar(int idCliente, string documento, string tipoDoc, string nombre1, string nombre2, string apellido1, string apellido2, string direccion, string correo, string telefono, string contactoEmergencia, string telefonoContacto, string foto, string observacionesMedicas) {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@tipoDo", tipoDoc);
            comando.Parameters.AddWithValue("@nombre1", nombre1);
            comando.Parameters.AddWithValue("@nombre2", nombre2);
            comando.Parameters.AddWithValue("@apellido1", apellido1);
            comando.Parameters.AddWithValue("@apellido2", apellido2);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@contactoEmergencia", contactoEmergencia);
            comando.Parameters.AddWithValue("@telefonoContacto", telefonoContacto);
            comando.Parameters.AddWithValue("@foto", foto);
            comando.Parameters.AddWithValue("@observacionesMedicas", observacionesMedicas);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();


        }

        public void Eliminar(int idCliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", idCliente);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        

    }
}
