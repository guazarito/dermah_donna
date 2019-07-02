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
    public partial class Adicional : Form
    {
        Boolean is_editing = false;
        conexao c = new conexao();
        util ut = new util();
        int j;
        String sQueryCarregaGrid = "select id as 'Cód.', descricao as 'Adicional', cast(valor as varchar) as 'Valor' from adicional where deletado <> 1 order by id desc";

        public Adicional()
        {
            InitializeComponent();

            ut.preencheGrid(grdAdicional, sQueryCarregaGrid);

            for (j = 0; j < grdAdicional.RowCount; j++)
            {
                grdAdicional[2, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdAdicional[2, j].Value.ToString().Replace(".", ",")));
            }
        }

        private void BtnSalvarAdicional_Click(object sender, EventArgs e)
        {
            if (txtDescAdicional.Text == "")
            {
                MessageBox.Show("O campo 'Adicional' é obrigatório", "Preencha o Adicional", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtValorAdicional.Text = txtValorAdicional.Text.Replace(".", ",");
                txtValorAdicional.Text = string.Format("{0:C}", Convert.ToDecimal(txtValorAdicional.Text.ToString()));
                txtValorAdicional.Text = txtValorAdicional.Text.Replace("R$ ", "");
                String adicional = txtDescAdicional.Text.Replace("'", "''");
                decimal Valor;
                String sValorAdic;

                try
                {
                    if (Convert.ToDecimal(txtValorAdicional.Text, CultureInfo.CurrentCulture) >= 1000)
                    {
                        sValorAdic = txtValorAdicional.Text.Replace(".", "");
                        sValorAdic = sValorAdic.Replace(",", "");
                        sValorAdic = sValorAdic.Insert(sValorAdic.Length - 2, ".");
                    }

                    Valor = Convert.ToDecimal(txtValorAdicional.Text, CultureInfo.CurrentCulture);
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
                        c.ExecutaQuery("insert into adicional (descricao, valor) values('" + adicional + "', " + sValor + ")");
                        ut.preencheGrid(grdAdicional, sQueryCarregaGrid);
                        for (j = 0; j < grdAdicional.RowCount; j++)
                        {
                            grdAdicional[2, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdAdicional[2, j].Value.ToString().Replace(".", ",")));
                        }
                        BtnLimparAdicional_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar adicional: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update adicional set descricao='" + adicional + "', valor= " + sValor + " where id =" + grdAdicional[0, grdAdicional.CurrentRow.Index].Value.ToString());
                    ut.preencheGrid(grdAdicional, sQueryCarregaGrid);
                    for (j = 0; j < grdAdicional.RowCount; j++)
                    {
                        grdAdicional[2, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdAdicional[2, j].Value.ToString().Replace(".", ",")));
                    }
                    BtnLimparAdicional_Click(new Object(), new EventArgs());
                }
            }
            is_editing = false;

        BYE: var a = 1;
        }

        private void BtnLimparAdicional_Click(object sender, EventArgs e)
        {
            txtDescAdicional.Text = "";
            txtValorAdicional.Text = "";
            grdAdicional.ClearSelection();
            btnDeletetarAdicional.Enabled = false;
            btnEditarAdicional.Enabled = false;
        }

        private void BtnEditarAdicional_Click(object sender, EventArgs e)
        {
            txtDescAdicional.Text = grdAdicional[1, grdAdicional.CurrentRow.Index].Value.ToString();
            txtValorAdicional.Text = grdAdicional[2, grdAdicional.CurrentRow.Index].Value.ToString().Replace("R$", "").Trim();

            is_editing = true;
        }

        private void BtnDeletetarAdicional_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar o Adicional " + grdAdicional[0, grdAdicional.CurrentRow.Index].Value.ToString() + " - " + grdAdicional[1, grdAdicional.CurrentRow.Index].Value.ToString() + "?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.ExecutaQuery("update adicional set deletado=1 where id =" + grdAdicional[0, grdAdicional.CurrentRow.Index].Value.ToString());
                ut.preencheGrid(grdAdicional, sQueryCarregaGrid);
                for (j = 0; j < grdAdicional.RowCount; j++)
                {
                    grdAdicional[2, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdAdicional[2, j].Value.ToString().Replace(".", ",")));
                }
                BtnLimparAdicional_Click(new Object(), new EventArgs());
            }
        }

        private void Adicional_Shown(object sender, EventArgs e)
        {
            grdAdicional.ClearSelection();
        }

        private void GrdAdicional_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeletetarAdicional.Enabled = true;
            btnEditarAdicional.Enabled = true;
        }
    }
}
