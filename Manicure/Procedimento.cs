using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Dermahdonna
{
    public partial class Procedimento : Form
    {
        Boolean is_editing = false;
        conexao c = new conexao();
        util ut = new util();
        int j;
        String sQueryCarregaGrid = "select id as 'Cód.', descricao as 'Procedimento', cast(valor as varchar) as 'Valor' from procedimento where deletado <> 1 order by id desc";

        public Procedimento()
        {
            InitializeComponent();

            ut.preencheGrid(grdProcedimento, sQueryCarregaGrid);


            for (j = 0; j < grdProcedimento.RowCount; j++)
            {

                grdProcedimento[2, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdProcedimento[2, j].Value.ToString().Replace(".", ",")));
            }


        }


        private void BtnLimparProc_Click(object sender, EventArgs e)
        {
            txtDescProcedimento.Text = "";
            txtValorProcedimento.Text = "";
            grdProcedimento.ClearSelection();
            btnDeletetarProc.Enabled = false;
            btnEditarProc.Enabled = false;
        }

        private void BtnDeletetarProc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar o Procedimento " + grdProcedimento[0, grdProcedimento.CurrentRow.Index].Value.ToString() + " - " + grdProcedimento[1, grdProcedimento.CurrentRow.Index].Value.ToString() + "?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.ExecutaQuery("update procedimento set deletado=1 where id =" + grdProcedimento[0, grdProcedimento.CurrentRow.Index].Value.ToString());
                ut.preencheGrid(grdProcedimento, sQueryCarregaGrid);

                for (j = 0; j < grdProcedimento.RowCount; j++)
                {

                    grdProcedimento[2, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdProcedimento[2, j].Value.ToString().Replace(".", ",")));
                }

                BtnLimparProc_Click(new Object(), new EventArgs());
            }
        }

        private void Procedimento_Shown(object sender, EventArgs e)
        {
            grdProcedimento.ClearSelection();
        }

        private void GrdProcedimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeletetarProc.Enabled = true;
            btnEditarProc.Enabled = true;
        }

        private void BtnSalvarProc_Click(object sender, EventArgs e)
        {
            if (txtDescProcedimento.Text == "")
            {
                MessageBox.Show("O campo 'Procedimento' é obrigatório", "Preencha o Procedimento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtValorProcedimento.Text = txtValorProcedimento.Text.Replace(".", ",");
                txtValorProcedimento.Text = string.Format("{0:C}", Convert.ToDecimal(txtValorProcedimento.Text.ToString()));
                txtValorProcedimento.Text = txtValorProcedimento.Text.Replace("R$ ", "");
                String procedimento = txtDescProcedimento.Text.Replace("'", "''");
                decimal Valor;
                String sValorProc;
                try
                {
                    if (Convert.ToDecimal(txtValorProcedimento.Text, CultureInfo.CurrentCulture) >= 1000)
                    {
                        sValorProc = txtValorProcedimento.Text.Replace(".", "");
                        sValorProc = sValorProc.Replace(",", "");
                        sValorProc = sValorProc.Insert(sValorProc.Length - 2, ".");
                    }

                    Valor = Convert.ToDecimal(txtValorProcedimento.Text, CultureInfo.CurrentCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("Formato de Valor inválido. Por favor, insira um valor válido. Ex: 12,50", "Ooops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto BYE;
                }

                String sValor = Valor.ToString().Replace(",", ".");

                if (!is_editing) //salvando..    
                {
                    try
                    {
                        c.ExecutaQuery("insert into procedimento (descricao, valor) values('" + procedimento + "', " + sValor + ")");
                        ut.preencheGrid(grdProcedimento, sQueryCarregaGrid);

                        for (j = 0; j < grdProcedimento.RowCount; j++)
                        {
                            
                            grdProcedimento[2, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdProcedimento[2, j].Value.ToString().Replace(".",",")));
                        }

                        BtnLimparProc_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar procedimento: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update procedimento set descricao='" + procedimento + "', valor= " + sValor + " where id =" + grdProcedimento[0, grdProcedimento.CurrentRow.Index].Value.ToString());
                    ut.preencheGrid(grdProcedimento, sQueryCarregaGrid);

                    for (j = 0; j < grdProcedimento.RowCount; j++)
                    {

                        grdProcedimento[2, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdProcedimento[2, j].Value.ToString().Replace(".", ",")));
                    }

                    BtnLimparProc_Click(new Object(), new EventArgs());
                }
            }
            is_editing = false;

        BYE: var a = 1;
        }

        private void BtnEditarProc_Click(object sender, EventArgs e)
        {
            txtDescProcedimento.Text = grdProcedimento[1, grdProcedimento.CurrentRow.Index].Value.ToString();
            txtValorProcedimento.Text = grdProcedimento[2, grdProcedimento.CurrentRow.Index].Value.ToString().Replace("R$","").Trim();

            is_editing = true;
        }
    }
}
