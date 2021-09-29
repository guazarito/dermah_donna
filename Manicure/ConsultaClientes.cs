using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Yumi
{
    public partial class ConsultaClientes : Form
    {
        conexao c = new conexao();
        private MDIParent1 Form;

        public ConsultaClientes(MDIParent1 mdi)
        {
            InitializeComponent();
            Form = mdi; //mdiparent
        }

        private void BtnBuscarCli_Click(object sender, EventArgs e)
        {
            String sQuery = "select id as 'Código', nome as 'Nome', telefone as 'Telefone' from cliente where deletado <> 1 and nome like '%"+ txtBuscaCli.Text +"%'";

            var conn = new OdbcConnection();
            conn.ConnectionString = c.getConexaoString();
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(sQuery, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            grdConsultaClientes.ReadOnly = true;
            grdConsultaClientes.DataSource = ds.Tables[0];

            grdConsultaClientes.ClearSelection();

        }

        private void grdConsultaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idcliente = Convert.ToInt32(grdConsultaClientes[0, grdConsultaClientes.CurrentRow.Index].Value);

            VendasPorCliente newMDIChild = new VendasPorCliente(idcliente, Form);

            newMDIChild.MdiParent = Form;
            newMDIChild.Show();
        }
    }
}
