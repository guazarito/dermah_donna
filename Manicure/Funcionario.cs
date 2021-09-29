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
    public partial class Funcionario : Form
    {
        Boolean is_editing = false;
        conexao c = new conexao();
        util ut = new util();

        String sQueryCarregaGrid = "select id as 'Cód.', nome as 'Nome', telefone as 'Telefone' from funcionario where deletado <> 1 order by id desc";

        public Funcionario()
        {
            InitializeComponent();

            ut.preencheGrid(grdFunc, sQueryCarregaGrid);
        }

        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            if (txtNomeFuncionario.Text == "")
            {
                MessageBox.Show("O campo 'Nome' é obrigatório", "Preencha o Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String nome = txtNomeFuncionario.Text.Replace("'", "''");
                String telefone = txtTelFuncionario.Text.Replace("'", "''");

                if (!is_editing) //salvando..    
                {
                    try
                    {
                        c.ExecutaQuery("insert into funcionario (nome, telefone) values('" + nome + "', '" + telefone + "')");
                        ut.preencheGrid(grdFunc, sQueryCarregaGrid);
                        BtnLimparCli_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar funcionário: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update funcionario set nome='" + nome + "', telefone= '" + telefone + "' where id =" + grdFunc[0, grdFunc.CurrentRow.Index].Value.ToString());
                    ut.preencheGrid(grdFunc, sQueryCarregaGrid);
                    BtnLimparCli_Click(new Object(), new EventArgs());
                }
            }

            is_editing = false;
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            txtNomeFuncionario.Text = grdFunc[1, grdFunc.CurrentRow.Index].Value.ToString();
            txtTelFuncionario.Text = grdFunc[2, grdFunc.CurrentRow.Index].Value.ToString();

            is_editing = true;
        }

        private void Cliente_Shown(object sender, EventArgs e)
        {
            grdFunc.ClearSelection();
        }


        private void BtnLimparCli_Click(object sender, EventArgs e)
        {
            txtNomeFuncionario.Text = "";
            txtTelFuncionario.Text = "";
            grdFunc.ClearSelection();
            btnDeletarFunc.Enabled = false;
            btnEditarFunc.Enabled = false;
        }

        private void Funcionario_Shown(object sender, EventArgs e)
        {
            grdFunc.ClearSelection();
        }

        private void GrdFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeletarFunc.Enabled = true;
            btnEditarFunc.Enabled = true;
        }

        private void BtnDeletarFunc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar o Funcionário " + grdFunc[0, grdFunc.CurrentRow.Index].Value.ToString() + " - " + grdFunc[1, grdFunc.CurrentRow.Index].Value.ToString() + "?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.ExecutaQuery("update funcionario set deletado = 1 where id =" + grdFunc[0, grdFunc.CurrentRow.Index].Value.ToString());
                ut.preencheGrid(grdFunc, sQueryCarregaGrid);
                BtnLimparCli_Click(new Object(), new EventArgs());
            }
        }

        private void BtnEditarFunc_Click(object sender, EventArgs e)
        {
            txtNomeFuncionario.Text = grdFunc[1, grdFunc.CurrentRow.Index].Value.ToString();
            txtTelFuncionario.Text = grdFunc[2, grdFunc.CurrentRow.Index].Value.ToString();

            is_editing = true;
        }
    }

}
