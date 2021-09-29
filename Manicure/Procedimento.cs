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
    public partial class Procedimento : Form
    {
        Boolean is_editing = false;
        conexao c = new conexao();
        util ut = new util();
        int j;
        String sQueryCarregaGrid = @"select id as 'Cód.', descricao as 'Procedimento', 
                                    isnull(financTpValor,0) as financTpValor,
                                    cast(isnull(financValorSalao,0) as varchar) as 'Valor Salão',
                                    cast(isnull(financValorColab,0) as varchar) as 'Valor Colab',
                                    cast(valor as varchar) as 'Valor Venda' 
                                    from procedimento where deletado<> 1 order by id desc";

        public Procedimento()
        {
            InitializeComponent();

            ut.preencheGrid(grdProcedimento, sQueryCarregaGrid);

            grdProcedimento.Columns[2].Visible = false; // tipo valor finan 1- porcentagem, 2- valor absoluto

            montaGridProcedimentos();


        }


        private void BtnLimparProc_Click(object sender, EventArgs e)
        {
            txtDescProcedimento.Text = "";
            txtValorProcedimento.Text = "";
            grdProcedimento.ClearSelection();
            btnDeletetarProc.Enabled = false;
            btnEditarProc.Enabled = false;
            rdoValorAbs.Checked = false;
            rdoPorcentagem.Checked = false;
            label6.Visible = false;
            label7.Visible = false;
            txtValorSalao.Text = "";
            txtValorColabs.Text = "";
        }

        private void BtnDeletetarProc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar o Procedimento " + grdProcedimento[0, grdProcedimento.CurrentRow.Index].Value.ToString() + " - " + grdProcedimento[1, grdProcedimento.CurrentRow.Index].Value.ToString() + "?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.ExecutaQuery("update procedimento set deletado=1 where id =" + grdProcedimento[0, grdProcedimento.CurrentRow.Index].Value.ToString());
                ut.preencheGrid(grdProcedimento, sQueryCarregaGrid);

                montaGridProcedimentos();

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

                    if(financeiroTipoValor == 1)
                    {
                        if((financeiroValorColab + financeiroValorSalao) != 100)
                        {
                            MessageBox.Show("Porcentagem Valor Salão e Porcentagem Valor Colaboradores não somam 100%.\n\nVerifique ou mude para Valor Absoluto!", "Ooops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto BYE;
                        }
                    }else if (financeiroTipoValor == 2)
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
                        c.ExecutaQuery("insert into procedimento (descricao, valor, financTpValor, financValorSalao, financValorColab) values('" + procedimento + "', " + sValor + "," + financeiroTipoValor.ToString() + "," + sValorSalao + "," + sValoColabs + ")");
                        ut.preencheGrid(grdProcedimento, sQueryCarregaGrid);

                        montaGridProcedimentos();

                        MessageBox.Show("Procedimento salvo com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnLimparProc_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar procedimento: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update procedimento set descricao='" + procedimento + "', valor= " + sValor + ", financTpValor = " + financeiroTipoValor.ToString() + ", financValorSalao = " + sValorSalao + ", financValorColab = " + sValoColabs + " where id =" + grdProcedimento[0, grdProcedimento.CurrentRow.Index].Value.ToString());
                    ut.preencheGrid(grdProcedimento, sQueryCarregaGrid);

                    montaGridProcedimentos();

                    MessageBox.Show("Procedimento salvo com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnLimparProc_Click(new Object(), new EventArgs());
                }
            }
            is_editing = false;

        BYE: var a = 1;
        }

        private void BtnEditarProc_Click(object sender, EventArgs e)
        {
            txtDescProcedimento.Text = grdProcedimento[1, grdProcedimento.CurrentRow.Index].Value.ToString();
            txtValorProcedimento.Text = grdProcedimento[5, grdProcedimento.CurrentRow.Index].Value.ToString().Replace("R$","").Trim();

            txtValorSalao.Text = grdProcedimento[3, grdProcedimento.CurrentRow.Index].Value.ToString().Replace("R$", "").Replace("%", "").Trim();
            txtValorColabs.Text = grdProcedimento[4, grdProcedimento.CurrentRow.Index].Value.ToString().Replace("R$", "").Replace("%", "").Trim();

            if (grdProcedimento[2, grdProcedimento.CurrentRow.Index].Value.ToString() == "1")
            {
                rdoPorcentagem.Checked = true;
            }else if (grdProcedimento[2, grdProcedimento.CurrentRow.Index].Value.ToString() == "2")
            {
                rdoValorAbs.Checked = true;
            }
            else
            {
                rdoPorcentagem.Checked = false;
                rdoValorAbs.Checked = false;

                label6.Visible = false;
                label7.Visible = false;
            }


            is_editing = true;
        }

        private void rdoPorcentagem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPorcentagem.Checked)
            {
                label6.Visible = true;
                label7.Visible = true;
            }
        }

        private void rdoValorAbs_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoValorAbs.Checked)
            {
                label6.Visible = false;
                label7.Visible = false;
            }
        }

        private void montaGridProcedimentos()
        {
            for (j = 0; j < grdProcedimento.RowCount; j++)
            {

                grdProcedimento[5, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdProcedimento[5, j].Value.ToString().Replace(".", ",")));

                if (grdProcedimento[2, j].Value.ToString() == "1") // %
                {
                    grdProcedimento[3, j].Value = grdProcedimento[3, j].Value + "%";
                    grdProcedimento[4, j].Value = grdProcedimento[4, j].Value + "%";
                }
                else if (grdProcedimento[2, j].Value.ToString() == "2") //valor abs
                {
                    grdProcedimento[3, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdProcedimento[3, j].Value.ToString().Replace(".", ",")));
                    grdProcedimento[4, j].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdProcedimento[4, j].Value.ToString().Replace(".", ",")));
                }

            }
        }
    }
}
