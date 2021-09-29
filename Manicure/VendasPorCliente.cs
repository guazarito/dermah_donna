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
using System.Globalization;


namespace Yumi
{
    public partial class VendasPorCliente : Form
    {
        conexao c = new conexao();
        private MDIParent1 Form;
        private int _idCliente;

        public VendasPorCliente(int idcliente, MDIParent1 mdi)
        {
            _idCliente = idcliente;
            InitializeComponent();
            Form = mdi; //mdiparent
        }

        

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string filtroSelecionado = (string)cboFiltro.SelectedItem;

            /*
                0 - Ver últimas 3 visitas
                1 - Ver últimas 5 visitas
                2 - Ver últimas 10 visitas
                3 - Ver todas visitas
             */

            int resultIndex = cboFiltro.FindStringExact(filtroSelecionado);

            string top = "";

            switch(resultIndex){
                case 0:
                    top = " top 3 ";
                    break;
                case 1:
                    top = " top 5 ";
                    break;
                case 2:
                    top = " top 10 ";
                    break;
                case 3:
                    top = " ";
                    break;
            }

            string q = "select " + top + " v.id as 'Num. Venda', fp.descricao as 'Form. Pgto.',";
                   q += @" concat(CONVERT(varchar, data, 103), ' ', CONVERT(varchar, data, 8)) as 'Data/Hora', 
                        cast(v.valor_total as varchar) as 'Valor s/ desc.', 
                        cast(v.desconto as varchar) as 'Desc.', 
                        cast((valor_total - desconto) as varchar) as 'Valor total'
                        from vendas v
                        left
                        join cliente c on c.id = v.id_cliente
                        left
                        join forma_pgto fp on fp.id = v.id_forma_pgto
                        where isnull(v.id_cliente, 0) <> 0
                              and isnull(cancelado, 0) = 0
                              and v.id_cliente = " + _idCliente.ToString();
                    q += " order by v.data desc ";

            preencheGrid(q);

            grdVendasClientes.Focus();

        }

        private void preencheGrid(string query)
        {
            Cursor.Current = Cursors.WaitCursor;

            var conn = new OdbcConnection();
            conn.ConnectionString = c.getConexaoString();
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            grdVendasClientes.ReadOnly = true;
            grdVendasClientes.DataSource = ds.Tables[0];

            int g;
            decimal soma_filtro = 0;

            for (g = 0; g < grdVendasClientes.RowCount; g++)
            {
                soma_filtro += Convert.ToDecimal(grdVendasClientes[5, g].Value.ToString().Replace(".", ","));

                grdVendasClientes[3, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdVendasClientes[3, g].Value.ToString().Replace(".", ",")));
                grdVendasClientes[4, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdVendasClientes[4, g].Value.ToString().Replace(".", ",")));
                grdVendasClientes[5, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdVendasClientes[5, g].Value.ToString().Replace(".", ",")));
            }

            txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(soma_filtro.ToString().Replace(".", ",")));
            
            grdVendasClientes.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdVendasClientes.ClearSelection();

            Cursor.Current = Cursors.Default;
        }

        private void VendasPorCliente_Shown(object sender, EventArgs e)
        {
            txtNome.Text = c.RetornaQuery("select concat(id, ' - ', nome) as 'cliente' from cliente where id=" + _idCliente.ToString(), "cliente");
            grdVendasClientes.Focus();

            cboFiltro.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdVendasClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idvenda = Convert.ToInt32(grdVendasClientes[0, grdVendasClientes.CurrentRow.Index].Value);

            VerVendas newMDIChild = new VerVendas(idvenda);

            newMDIChild.MdiParent = Form;
            newMDIChild.Show();
        }
    }
}
