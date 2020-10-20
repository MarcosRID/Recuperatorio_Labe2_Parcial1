using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiwk_E_Mart
{
    public partial class frmTicket_de_Compra : Form
    {
        Factura auxFactura;


         

        public frmTicket_de_Compra(Factura auxF)
        {
            auxFactura = new Factura();
            this.auxFactura = auxF;

            InitializeComponent();
        }

        private void lsb_Ticket_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void frmTicket_de_Compra_Load(object sender, EventArgs e)
        {
        

            this.lsb_Ticket.DataSource = null;
            this.lsb_Ticket.DataSource = (List<string>)auxFactura;

        }
    }
}
