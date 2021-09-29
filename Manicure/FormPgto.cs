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
    public partial class FormPgto : Form
    {
        Boolean is_editing = false;
        conexao c = new conexao();
        util ut = new util();

        String sQueryCarregaGrid = "select id as 'Cód.', descricao as 'Forma de Pagamento' from forma_pgto where deletado <> 1 order by id desc";

        public FormPgto()
        {
            InitializeComponent();
            ut.preencheGrid(grdFPgto, sQueryCarregaGrid);
        }

        private void BtnSalvarFPgto_Click(object sender, EventArgs e)
        {
            if (txtFPgto.Text == "")
            {
                MessageBox.Show("O campo 'Forma de Pagamento' é obrigatório", "Preencha a forma de pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String fpgto = txtFPgto.Text.Replace("'", "''");
                int naoSomaTotaisRel = chkNaoSomaTotais.Checked ? 1 : 0;

                if (!is_editing) //salvando..    
                {
                    try
                    {
                        c.ExecutaQuery("insert into forma_pgto (descricao, naoSomaTotaisRelatorios) values('" + fpgto + "'," + naoSomaTotaisRel.ToString() + ")");
                        ut.preencheGrid(grdFPgto, sQueryCarregaGrid);
                        BtnLimparFPgto_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar forma de pagamento: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update forma_pgto set descricao='" + fpgto + "', naoSomaTotaisRelatorios="+ naoSomaTotaisRel.ToString() + "  where id =" + grdFPgto[0, grdFPgto.CurrentRow.Index].Value.ToString());
                    ut.preencheGrid(grdFPgto, sQueryCarregaGrid);
                    BtnLimparFPgto_Click(new Object(), new EventArgs());
                }
            }
            is_editing = false;
        }

        private void BtnLimparFPgto_Click(object sender, EventArgs e)
        {
            txtFPgto.Text = "";
            grdFPgto.ClearSelection();
            btnDeletetarFpgto.Enabled = false;
            btnEditarFpgto.Enabled = false;
            chkNaoSomaTotais.Checked = false;
        }

        private void BtnEditarFpgto_Click(object sender, EventArgs e)
        {
            txtFPgto.Text = grdFPgto[1, grdFPgto.CurrentRow.Index].Value.ToString();

            chkNaoSomaTotais.Checked = bool.Parse(c.RetornaQuery("select isnull(naoSomaTotaisRelatorios,0) as naoSomaTotaisRelatorios from forma_pgto where id=" + grdFPgto[0, grdFPgto.CurrentRow.Index].Value.ToString(), "naoSomaTotaisRelatorios"));

            is_editing = true;
        }

        private void BtnDeletetarFpgto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar a Forma de Pagamento " + grdFPgto[0, grdFPgto.CurrentRow.Index].Value.ToString() + " - " + grdFPgto[1, grdFPgto.CurrentRow.Index].Value.ToString() + "?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.ExecutaQuery("update forma_pgto set deletado=1 where id =" + grdFPgto[0, grdFPgto.CurrentRow.Index].Value.ToString());
                ut.preencheGrid(grdFPgto, sQueryCarregaGrid);
                BtnLimparFPgto_Click(new Object(), new EventArgs());
            }
        }

        private void GrdFPgto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeletetarFpgto.Enabled = true;
            btnEditarFpgto.Enabled = true;
        }

        private void FormPgto_Shown(object sender, EventArgs e)
        {
            grdFPgto.ClearSelection();
        }
    }
}
