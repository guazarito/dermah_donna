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

namespace Yumi
{
    public partial class Adicional : Form
    {
        Boolean is_editing = false;
        conexao c = new conexao();
        util ut = new util();
        int j;
        String sQueryCarregaGrid = @"select id as 'Cód.', descricao as 'Adicional', 
                                    isnull(financTpValor,0) as financTpValor,
                                    cast(isnull(financValorSalao,0) as varchar) as 'Valor Salão',
                                    cast(isnull(financValorColab,0) as varchar) as 'Valor Colab',
                                    cast(valor as varchar) as 'Valor Venda' 
                                    from adicional where deletado<> 1 order by id desc";

        public Adicional()
        {
            InitializeComponent();

            ut.preencheGrid(grdAdicional, sQueryCarregaGrid);

            montaGridAdicionais();
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

                int financeiroTipoValor = 0;

                decimal financeiroValorSalao = 0;
                decimal financeiroValorColab = 0;

                if (rdoPorcentagem.Checked)
                {
                    financeiroTipoValor = 1;
                }
                else if (rdoValorAbs.Checked)
                {
                    financeiroTipoValor = 2;
                }

                String sValorSalao = "0";
                String sValoColabs = "0";

                if (rdoValorAbs.Checked || rdoPorcentagem.Checked)
                {
                    try
                    {

                        if (txtValorSalao.Text != "")
                        {
                            financeiroValorSalao = Convert.ToDecimal(txtValorSalao.Text.Replace(".", ","), CultureInfo.CurrentCulture);
                        }
                        else
                        {
                            MessageBox.Show("Preencha o valor do Salão e/ou valor Colaborador");
                            goto BYE;
                        }
                        if (txtValorColabs.Text != "")
                        {
                            financeiroValorColab = Convert.ToDecimal(txtValorColabs.Text.Replace(".", ","), CultureInfo.CurrentCulture);
                        }
                        else
                        {
                            MessageBox.Show("Preencha o valor do Salão e/ou valor Colaborador");
                            goto BYE;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Formato de Valor inválido nos campos Valor Salão e/ou Valor Colabs.\nPor favor, insira um valor válido. Ex: 12,50", "Ooops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto BYE;
                    }

                    if (financeiroTipoValor == 1)
                    {
                        if ((financeiroValorColab + financeiroValorSalao) != 100)
                        {
                            MessageBox.Show("Porcentagem Valor Salão e Porcentagem Valor Colaboradores não somam 100%.\n\nVerifique ou troque para Valor Absoluto!", "Ooops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto BYE;
                        }
                    }
                    else if (financeiroTipoValor == 2)
                    {
                        if ((financeiroValorColab + financeiroValorSalao) != Valor && (financeiroValorColab + financeiroValorSalao) != 0)
                        {
                            MessageBox.Show("Valor Salão e Valor Colaboradores não somam " + sValor + ".\nVerifique!", "Ooops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto BYE;
                        }
                    }
                    sValorSalao = financeiroValorSalao.ToString().Replace(",", ".");
                    sValoColabs = financeiroValorColab.ToString().Replace(",", ".");
                }

                if (!is_editing) //salvando..    
                {
                    try
                    {
                        c.ExecutaQuery("insert into adicional (descricao, valor, financTpValor, financValorSalao, financValorColab) values('" + adicional + "', " + sValor + "," + financeiroTipoValor.ToString() + "," + sValorSalao + "," + sValoColabs + ")");
                        ut.preencheGrid(grdAdicional, sQueryCarregaGrid);

                        montaGridAdicionais();

                        MessageBox.Show("Salvo com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BtnLimparAdicional_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar adicional: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update adicional set descricao='" + adicional + "', valor= " + sValor + ", financTpValor = " + financeiroTipoValor.ToString() + ", financValorSalao = " + sValorSalao + ", financValorColab = " + sValoColabs + " where id =" + grdAdicional[0, grdAdicional.CurrentRow.Index].Value.ToString());
                    ut.preencheGrid(grdAdicional, sQueryCarregaGrid);

                    montaGridAdicionais();

                    MessageBox.Show("Salvo com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            rdoValorAbs.Checked = false;
            rdoPorcentagem.Checked = false;
            label6.Visible = false;
            label7.Visible = false;
            txtValorSalao.Text = "";
            txtValorColabs.Text = "";
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
                montaGridAdicionais();
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

        private void montaGridAdicionais()
        {
            for (j = 0; j < grdAdicional.RowCount; j++)
            {

                grdAdicional[5, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdAdicional[5, j].Value.ToString().Replace(".", ",")));

                if (grdAdicional[2, j].Value.ToString() == "1") // %
                {
                    grdAdicional[3, j].Value = grdAdicional[3, j].Value + "%";
                    grdAdicional[4, j].Value = grdAdicional[4, j].Value + "%";
                }
                else if (grdAdicional[2, j].Value.ToString() == "2") //valor abs
                {
                    grdAdicional[3, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdAdicional[3, j].Value.ToString().Replace(".", ",")));
                    grdAdicional[4, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdAdicional[4, j].Value.ToString().Replace(".", ",")));
                }

            }
        }


    }
}
