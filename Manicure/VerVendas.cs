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
            txtValorTotal.Text = string.Format("{0:C}", Convert.ToDecimal(c.RetornaQuery("select valor_total from vendas where id=" + idvenda.ToString(), "valor_total"))).Replace("R$ ", "");

            //preenche grid ... 

            string select = "select ROW_NUMBER() over(order by vi.id_venda) as 'Item', (select case when p.descricao is not null then p.descricao else 'adicional: ' + a.descricao end) as 'Descrição', f.nome as 'Funcionário', format(vi.vl_total_item, 'c', 'pt-br') as 'Valor Ítem' from vendas_itens vi left outer join procedimento p on p.id = vi.id_procedimento left outer join adicional a on a.id = vi.id_adicional left outer join vendas v on v.id = vi.id_venda left outer join funcionario f on f.id = vi.id_func where vi.id_venda = " + idvenda;

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
                decimal auxTotal = decimal.Parse(txtValorTotal.Text) - desconto;

                lblDesconto.Visible = true;
                txtDesconto.Text = string.Format("{0:C}", Convert.ToDecimal(desconto.ToString()));
                txtDesconto.Visible = true;
                
                txtValorTotComDesconto.Text = string.Format("{0:C}", Convert.ToDecimal(auxTotal.ToString())).Replace("R$ ","");

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
