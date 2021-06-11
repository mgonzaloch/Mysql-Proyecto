using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mysql_Proyecto.capaNegocio
{
    public partial class FormPre : System.Web.UI.Page
    {
        private capaNegocio.Prestamo prestamo = new capaNegocio.Prestamo();

        private void Listar()
        {
            gvPrestamo.DataSource = prestamo.Listar();
            gvPrestamo.DataBind();


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Prestamo l = new Prestamo();
            string codAutor = txtcodAutor.Text.Trim();
            string codLibro = txtcodLibro.Text.Trim();
            string FechaPrestamo = txtFecha.Text.Trim();
            l.Agregar(codAutor, codLibro, FechaPrestamo);
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string codAutor = txtcodAutor.Text.Trim();
            string codLibro = txtcodLibro.Text.Trim();

            prestamo.Eliminar(codAutor,codLibro);
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string codAutor = txtcodAutor.Text.Trim();
            string codLibro = txtcodLibro.Text.Trim();
            string Fecha = txtFecha.Text.Trim();

            if (prestamo.Actualizar(codAutor, codLibro, Fecha))
                Listar();
            else
                Response.Write("No se agrego");
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvPrestamo.DataSource = prestamo.Listar();
            gvPrestamo.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string busq = txtbusqueda.Text.Trim();
            Prestamo libro = new Prestamo();
            gvPrestamo.DataSource = libro.Buscar(busq);
            gvPrestamo.DataBind();
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            fecc();
        }
        private void fecc()
        {
           // txtFecha.Text = Convert.ToString(Calendar.SelectedDate);
            txtFecha.Text = Convert.ToString(Calendar.SelectedDate.ToString("yyyy-MM-dd"));
            txtbusqueda.Text = Convert.ToString(Calendar.SelectedDate.ToString("yyyy-MM-dd"));


        }
    }
}