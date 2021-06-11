using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Mysql_Proyecto.capaNegocio
{
    public class Prestamo : IPrestamo
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);

        public bool Actualizar(string codAutor, string codLibro, string FechaPrestamo)
        {
            string consulta = "update tprestamo set FechaPrestamo = @FechaPrestamo WHERE codAutor=@codAutor " +
                " AND CodLibro=@CodLibro ";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@codAutor", codAutor);
            comando.Parameters.AddWithValue("@CodLibro", codLibro);
            comando.Parameters.AddWithValue("@FechaPrestamo", FechaPrestamo);
            conexion.Open();
            byte i = Convert.ToByte(comando.ExecuteNonQuery());
            conexion.Close();
            if (i == 1) return true;
            else
                return false;
        }

        public bool Agregar(string codAutor, string codLibro, string FechaPrestamo)
        {
            string consulta = "insert into tprestamo values(@CodAutor,@CodLibro,@FechaPrestamo)";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@CodAutor", codAutor);
            comando.Parameters.AddWithValue("@CodLibro", codLibro);
            comando.Parameters.AddWithValue("@FechaPrestamo", FechaPrestamo);

            conexion.Open();
            byte i = Convert.ToByte(comando.ExecuteNonQuery());
            conexion.Close();
            if (i == 1) return true;
            else
                return false;
        }

        public DataTable Buscar(string texto)
        {
            string consulta = $"select * from tprestamo where CodAutor like '%{texto}%' " +
                 $"or CodLibro like '%{texto}%' " +
                 $"or FechaPrestamo like '%{texto}%' ";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public bool Eliminar(string codAutor, string codLibro)
        {
            string consulta = "delete from tprestamo where codAutor ='" + codAutor + "' AND codLibro ='" + codLibro + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Open();
            byte i = Convert.ToByte(comando.ExecuteNonQuery());
            conexion.Close();
            if (i == 1) return true;
            else return false;
        }

        public DataTable Listar()
        {
            string consulta = "select *from TPrestamo";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}