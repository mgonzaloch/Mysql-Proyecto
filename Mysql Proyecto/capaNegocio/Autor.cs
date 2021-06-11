using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

using System.Configuration;
using MySql.Data.MySqlClient;

namespace Mysql_Proyecto.capaNegocio
{
    public class Autor : IAutor
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);

        public bool Actualizar(string codAutor, string Apellidos, string Nombres, string Nacionalidad, string Profesion)
        {
            string consulta = "update tautor set apellidos=@apellidos,nombres=@nombres,nacionalidad=@nacionalidad where codautor=@codautor";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@codautor", codAutor);
            comando.Parameters.AddWithValue("@apellidos", Apellidos);
            comando.Parameters.AddWithValue("@nombres", Nombres);
            comando.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
            conexion.Open();
            byte i = Convert.ToByte(comando.ExecuteNonQuery());
            conexion.Close();
            if (i == 1) return true;
            else
                return false;
        }

        public bool Agregar(string codAutor, string Apellidos, string Nombres, string Nacionalidad, string Profesion)
        {
            throw new NotImplementedException();
        }

        public DataTable Buscar(string texto, string criterio)
        {
            string consulta = $"select * from tautor where codAutor like '%{texto}%' ";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public bool Eliminar(string codAutor)
        {
            throw new NotImplementedException();
        }

        public DataTable Listar()
        {
            string consulta = "select * from Tautor";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}