using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Mysql_Proyecto.capaNegocio
{
    interface IPrestamo
    {
        DataTable Listar();
        bool Agregar(string codAutor, string codLibro, string FechaPrestamo);
        bool Eliminar(string codAutor, string codLibro);
        bool Actualizar(string codAutor, string codLibro, string FechaPrestamo);
        DataTable Buscar(string texto);
    }
}
