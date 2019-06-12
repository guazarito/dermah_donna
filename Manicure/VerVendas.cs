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

namespace Dermahdonna
{
    public partial class VerVendas : Form
    {
        conexao c = new conexao();
        private int idvenda;
        public VerVendas(int id_venda)
        {
            InitializeComponent();
            idvenda = id_venda;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerVendas_Shown(object sender, EventArgs e)
        {
            txtNumVenda.Text = idvenda.ToString().PadLeft(5, '0');
            txtNumVenda.Select(txtNumVenda.Text.Length, txtNumVenda.Text.Length);

            txtNome.Text = c.RetornaQuery("select nome_cliente from vendas where id=" + idvenda.ToString(), "nome_cliente");
            txtFpgto.Text = c.RetornaQuery("select fp.descricao from vendas left join forma_pgto fp on fp.id = vendas.id_forma_pgto where vendas.id=" + idvenda.ToString(), "descricao");

            decimal desconto = decimal.Parse(c.RetornaQuery("select desconto from vendas where id=" + idvenda.ToString(), "desconto"));
            txtValorTotal.Text = c.RetornaQuery("select valor_total from vendas where id=" + idvenda.ToString(), "valor_total");

            //preenche grid ... 

            string select = "select ROW_NUMBER() over(order by vi.id_venda) as 'Item', p.descricao as 'Descrição',concat('R$ ', convert(varchar, vi.vl_total_item) as 'Valor Ítem', f.nome from vendas_itens vi left outer join procedimento p on p.id = vi.id_procedimento left outer join adicional a on a.id = vi.id_adicional left outer join vendas v on v.id = vi.id_venda left outer join funcionario f on f.id = vi.id_func where vi.id_venda = " + idvenda;

            var conn = new OdbcConnection();
            conn.ConnectionString = c.getConexaoString();
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            grdItens.ReadOnly = true;
            grdItens.DataSource = ds.Tables[0];

            this.grdItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grdItens.MultiSelect = false;

            grdItens.ClearSelection();

            

            if (desconto > 0)
            {
                txtValorTotComDesconto.Visible = true;
                lblRSDesconto.Visible = true;
                lblTotDesconto.Visible = true;
                decimal auxTotal = Math.Round(decimal.Parse(txtValorTotal.Text) - (decimal.Parse(txtValorTotal.Text) * desconto), 2);
                txtValorTotComDesconto.Text = auxTotal.ToString().Replace(".", ",");

                lblDesconto.Visible = true;
                txtDesconto.Visible = true;

                
                txtDesconto.Text = Math.Round((desconto * 100),1).ToString() + "%" ;

            }



        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a venda?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                c.ExecutaQuery("update vendas set cancelado=1 where id=" + idvenda.ToString());
                MessageBox.Show("CANCELADO!", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblCancelado.Visible = true;
            }
        }
    }
}
