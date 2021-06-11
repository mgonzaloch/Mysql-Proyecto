using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;

namespace Mysql_Proyecto.capaNegocio
{
    public partial class FormLib : System.Web.UI.Page
    {
        private capaNegocio.Libro libro = new capaNegocio.Libro();
        private void Listar()
        {
            gvLibro.DataSource = libro.Listar();
            gvLibro.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Libro l = new Libro();
            string codLibro = txtcodLibro.Text.Trim();
            string titulo = txttitulo.Text.Trim();
            string editorial = txteditorial.Text.Trim();

            // Agregar
            l.Agregar(codLibro, titulo, editorial);
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string codlibro = txtcodLibro.Text.Trim();

            libro.Eliminar(codlibro);
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string codlibro = txtcodLibro.Text.Trim();
            string titulo = txttitulo.Text.Trim();
            string editorial = txteditorial.Text.Trim();

            if (libro.Actualizar(codlibro, titulo, editorial))
                Listar();
            else
                Response.Write("No se agrego");

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvLibro.DataSource = libro.Listar();
            gvLibro.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string busq = txtbusqueda.Text.Trim();
            Libro libro = new Libro();
            gvLibro.DataSource = libro.Buscar(busq);
            gvLibro.DataBind();
        }
    }
}