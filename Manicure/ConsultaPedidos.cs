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
    public partial class ConsultaPedidos : Form
    {
        conexao c = new conexao();
        private MDIParent1 Form;

        int g;
        public ConsultaPedidos(MDIParent1 mdi)
        {
            InitializeComponent();
            Form = mdi; //mdiparent
            
        }

        private void preencheGrid(bool vercancelados)
        {
            string select;

            if (!vercancelados)
            {
                select = "select right('000000' + cast(id as nvarchar),6) as 'Núm. Venda', nome_cliente as 'Cliente', cast((valor_total - (desconto)) as varchar) as 'Valor Total', convert(varchar(5),data, 114) as 'Hora do Pedido' from vendas where convert(varchar(11),data,103)=convert(varchar(11),'" + dtConsulta.Text.ToString() + "',103) and isnull(cancelado,0)<>1";
            }
            else
            {
                select = "select right('000000' + cast(id as nvarchar),6) as 'Núm. Venda', nome_cliente as 'Cliente', cast((valor_total - (desconto)) as varchar) as 'Valor Total', convert(varchar(5),data, 114) as 'Hora do Pedido' from vendas where convert(varchar(11),data,103)=convert(varchar(11),'" + dtConsulta.Text.ToString() + "',103) and isnull(cancelado,0)=1";
            }

            var conn = new OdbcConnection();
            conn.ConnectionString = c.getConexaoString();
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            grdConsultaVendas.ReadOnly = true;
            grdConsultaVendas.DataSource = ds.Tables[0];

            grdConsultaVendas.Columns[0].Width = 100;
            grdConsultaVendas.Columns[1].Width = 320;
            grdConsultaVendas.Columns[2].Width = 100;
            grdConsultaVendas.Columns[3].Width = 100;


            if (vercancelados)
            {
                int i;
                int j;
                for (i = 0; i < grdConsultaVendas.RowCount; i++)
                {
                    for (j = 0; j < grdConsultaVendas.ColumnCount; j++)
                    {
                        grdConsultaVendas[j, i].Style.BackColor = Color.Salmon;
                    }
                }
            }

            for (g = 0; g < grdConsultaVendas.RowCount; g++)
            {
                grdConsultaVendas[2, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdConsultaVendas[2, g].Value.ToString().Replace(".", ",")));
            }

            grdConsultaVendas.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdConsultaVendas.ClearSelection();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            
            if (chkVerCancelados.Checked)
            {
                preencheGrid(true);
            }
            else
            {
                preencheGrid(false);
            }

        }

        private void GrdConsultaVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idvenda = Convert.ToInt32(grdConsultaVendas[0, grdConsultaVendas.CurrentRow.Index].Value);

            VerVendas newMDIChild = new VerVendas(idvenda);

            newMDIChild.MdiParent = Form;
            newMDIChild.Show();
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdConsultaVendas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    if (txtBusca.Text != "")
                    {
                        if (cell.Value.ToString().Trim().ToUpper().Contains(txtBusca.Text.Trim().ToUpper()))
                        {
                            //MessageBox.Show(row.Index.ToString());
                            cell.Style.BackColor = Color.DarkGreen;
                        }
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void ConsultaPedidos_Shown(object sender, EventArgs e)
        {
            preencheGrid(false);
        }

        private void ChkVerCancelados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerCancelados.Checked)
            {
                preencheGrid(true);
            }
            else
            {
                preencheGrid(false);
            }
        }
    }
}
