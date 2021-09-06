using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClienteReniecWindows
{
    public partial class Form1 : Form
    {
        private BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            srReniec.wsReniecSoapClient servicio = new srReniec.wsReniecSoapClient();

            // servicio.BuscarDNI(txtDNI.Text.Trim());
            gvData.DataSource = bs;
            //Consultar el servicio y poner los datos sobre la grilla
            bs.DataSource = servicio.Buscar(txtDNI.Text.Trim()).Tables[0];
            
            gvData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            

        }
    }
}
