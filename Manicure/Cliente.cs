using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yumi
{
    public partial class Cliente : Form
    {

        Boolean is_editing = false;
        conexao c = new conexao();
        util ut = new util();

        String sQueryCarregaGrid = "select id as 'Cód.', nome as 'Nome', telefone as 'Telefone' from cliente where deletado <> 1 order by id desc";

        public Cliente()
        {
            InitializeComponent();

            ut.preencheGrid(grdClientes, sQueryCarregaGrid);
        }

        private void BtnSalvarCli_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("O campo 'Nome' é obrigatório", "Preencha o Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String nome = txtNomeCliente.Text.Replace("'","''");
                String telefone = txtTelCliente.Text.Replace("'", "''");

                if (!is_editing) //salvando..    
                {
                    try
                    {
                        c.ExecutaQuery("insert into cliente (nome, telefone) values('" + nome + "', '" + telefone + "')");
                        ut.preencheGrid(grdClientes, sQueryCarregaGrid);
                        BtnLimparCli_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar cliente: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update cliente set nome='" + nome + "', telefone= '" + telefone + "' where id =" + grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString());
                    ut.preencheGrid(grdClientes, sQueryCarregaGrid);
                    BtnLimparCli_Click(new Object(), new EventArgs());
                }
            }

            is_editing = false;
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = grdClientes[1, grdClientes.CurrentRow.Index].Value.ToString();
            txtTelCliente.Text = grdClientes[2, grdClientes.CurrentRow.Index].Value.ToString();

            is_editing = true;
        }

        private void Cliente_Shown(object sender, EventArgs e)
        {
            grdClientes.ClearSelection();
        }

        private void GrdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                btnDeletarCli.Enabled = true;
                btnEditarCliente.Enabled = true;
        }

        private void BtnDeletarCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar o Cliente " + grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString() + " - " + grdClientes[1, grdClientes.CurrentRow.Index].Value.ToString()  + "?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.ExecutaQuery("update cliente set deletado=1 where id =" + grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString());
                ut.preencheGrid(grdClientes, sQueryCarregaGrid);
                BtnLimparCli_Click(new Object(), new EventArgs());
            }
        }

        private void BtnLimparCli_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
            txtTelCliente.Text = "";
            grdClientes.ClearSelection();
            btnDeletarCli.Enabled = false;
            btnEditarCliente.Enabled = false;
            is_editing = false;
        }
    }

}
