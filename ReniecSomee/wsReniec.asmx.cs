using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ReniecSomee
{

    /// <summary>
    /// Descripción breve de wsReniec
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsReniec : System.Web.Services.WebService
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);
        [WebMethod(Description = "Buscar en el registro de la Reniec")]
        public DataSet Buscar(string dni)
        {
            SqlCommand comando = new SqlCommand("spBuscarDNI", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DNI", dni);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adaptador.Fill(data);
            return data;

        }
    }
}
