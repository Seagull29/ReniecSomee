using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteReniecASP
{
    public partial class indexaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            // Llamar al servicio a traves de un objeto
            srReniec.wsReniecSoapClient servicio = new srReniec.wsReniecSoapClient();
            // servicio.BuscarDNI(txtDNI.Text.Trim());
            //Consultar el servicio y poner los datos sobre la grilla
            gvDatosDni.DataSource = servicio.Buscar(txtDNI.Text.Trim());
            gvDatosDni.DataBind();
        }
    }
}