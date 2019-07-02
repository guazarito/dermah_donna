using System;
using System.Windows.Forms;

namespace Dermahdonna
{

    public partial class Venda : Form
    {
        conexao c = new conexao();
        private decimal descontoAplicado =0; //global -> usado em toda tela, é o deconto aplicado, caso exista..

        public Venda()
        {
            InitializeComponent();


            int id = c.RetornaIdVendaAtual();
            txtNumVenda.Text = id.ToString().PadLeft(6, '0');
            txtNumVenda.Select(txtNumVenda.Text.Length, txtNumVenda.Text.Length);

            c.fillCombo(cboClientes, "select * from cliente where deletado <> 1 order by nome ", "id", "nome");
            cboClientes.SelectedValue = 0;

            c.fillCombo(cboFuncionarios, "select * from funcionario where deletado <> 1 order by nome", "id", "nome");
            cboFuncionarios.SelectedValue = 0;

            c.fillCombo(cboProcedimento, "select * from procedimento where deletado <> 1 order by descricao", "id", "descricao");
            cboProcedimento.SelectedValue = 0;

            c.fillCombo(cboAdicional, "select * from adicional where deletado <> 1 order by descricao", "id", "descricao");
            cboAdicional.SelectedValue = 0;

            c.fillCombo(cboFormaPgto, "select * from forma_pgto where deletado <> 1 order by descricao", "id", "descricao");
            cboFormaPgto.SelectedValue = 0;

            int idVenda = int.Parse(txtNumVenda.Text); //global, para ser usado nos inserts

            DataGridViewCellStyle aligncenter = new DataGridViewCellStyle();
            aligncenter.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdVenda.Columns[0].DefaultCellStyle = aligncenter;
            grdVenda.Columns[1].DefaultCellStyle = aligncenter;
            grdVenda.Columns[2].DefaultCellStyle = aligncenter;
            grdVenda.Columns[3].DefaultCellStyle = aligncenter;


        }

        private void BtnAddProcedimento_Click(object sender, EventArgs e)
        {
            if (cboFuncionarios.SelectedIndex != -1)
            {
                if (cboProcedimento.SelectedIndex != -1)
                {
                    int procId = Convert.ToInt32(cboProcedimento.SelectedValue.ToString());

                    int idFunc = Convert.ToInt32(cboFuncionarios.SelectedValue.ToString());

                    string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), c.RetornaQuery("select descricao from procedimento where id=" + procId.ToString(), "descricao").ToString(), c.RetornaQuery("select nome from funcionario where id=" + idFunc.ToString(), "nome"), string.Format("{0:C}", Convert.ToDecimal(c.RetornaQuery("select valor from procedimento where id=" + procId.ToString(), "valor").ToString())), procId.ToString(), "procedimento", idFunc.ToString() };
                    grdVenda.Rows.Add(row1);

                    CalculaPrecoTotal();

                    cboProcedimento.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Selecione um procedimento da lista!", "Procedimento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("Selecione um funcionário para este procedimento!", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

     
        private void BtnAddAdicional_Click(object sender, EventArgs e)
        {
            if (cboAdicional.SelectedIndex != -1)
            {
                int adicId = Convert.ToInt32(cboAdicional.SelectedValue.ToString());

                string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), "Adicional: " + c.RetornaQuery("select descricao from adicional where id=" + adicId.ToString(), "descricao").ToString(), "", string.Format("{0:C}", Convert.ToDecimal(c.RetornaQuery("select valor from adicional where id=" + adicId.ToString(), "valor").ToString())), adicId.ToString(), "adicional", "" };
                grdVenda.Rows.Add(row1);

                CalculaPrecoTotal();

                cboAdicional.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Selecione um adicional da lista!", "Adicional", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAddDesconto_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < grdVenda.Rows.Count; i++)
            {
                if (grdVenda.Rows[i].Cells[5].Value.ToString() == "desconto")
                {
                    MessageBox.Show("Já existem um desconto de " + grdVenda.Rows[i].Cells[3].Value.ToString() + " adicionado.\n\nPara adicionar outro valor de desconto, primeiro remova o desconto existente.", "Já existe desconto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto FIMDESC;
                }
            }

            if (txtDesconto.Text != "" && float.Parse(txtDesconto.Text)> 0)
            {
                txtDesconto.Text = txtDesconto.Text.Replace(".", ",");
                string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), "Desconto", "", string.Format("{0:C}", Convert.ToDecimal(txtDesconto.Text.ToString())), "", "desconto", "" };
                grdVenda.Rows.Add(row1);

                CalculaPrecoTotal();
            }
            else
            {
                MessageBox.Show("Insira um desconto válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FIMDESC: int a = 1; //do nothing
        }

        public void CalculaPrecoTotal()
        {
            int rowscount = grdVenda.Rows.Count;
            decimal preco_total;
            bool bTemDesconto = false;
            
            preco_total = 0;
            descontoAplicado = 0;

            for (int i = 0; i < rowscount; i++)
            {
                if(grdVenda.Rows[i].Cells[5].Value.ToString() == "desconto")
                {
                    bTemDesconto = true;
                    descontoAplicado = decimal.Parse(grdVenda.Rows[i].Cells[3].Value.ToString().Replace("R$ ", ""));
                }
                else
                {
                    preco_total = preco_total + Convert.ToDecimal(grdVenda.Rows[i].Cells[3].Value.ToString().Replace("R$ ", ""));
                }
                grdVenda[0, i].Value = i + 1;
            }

            txtValorTotal.Text = preco_total.ToString();

            if (bTemDesconto)
            {
                txtValorTotComDesconto.Text = Math.Round(preco_total - descontoAplicado, 2).ToString();
                lblRSDesconto.Visible = true;
                lblTotDesconto.Visible = true;
                txtValorTotComDesconto.Visible = true;
            }
            else
            {
                txtValorTotComDesconto.Text = "";
                lblRSDesconto.Visible = false;
                lblTotDesconto.Visible = false;
                txtValorTotComDesconto.Visible = false;
                chkDesconto.Checked = false;
                txtDesconto.Text = "";
                txtDesconto.Enabled = false;
            }

            grdVenda.ClearSelection();

        }

        private void ChkDesconto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesconto.Checked)
            {
                txtDesconto.Enabled = true;
                btnAddDesconto.Enabled = true;
            }
            else
            {
                txtDesconto.Enabled = false;
                btnAddDesconto.Enabled = false;
                txtDesconto.Text = "";
            }
        }

        private void GrdVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelItem.Visible = true;
            btnDelItem.Enabled = true;
        }

        private void BtnDelItem_Click(object sender, EventArgs e)
        {
            if (grdVenda.Rows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja remover o ítem " + grdVenda[0, grdVenda.CurrentRow.Index].Value + " ?", "Certeza?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    grdVenda.Rows.RemoveAt(grdVenda.CurrentRow.Index);
                    btnDelItem.Enabled = false;
                    btnDelItem.Visible = false;

                    CalculaPrecoTotal();
                }
            }
        }

        private void BtnConcluirPedido_Click(object sender, EventArgs e)
        {
            if (grdVenda.Rows.Count > 0)
            {
                if (cboFormaPgto.SelectedIndex != -1)
                {
                    //salvando..
                    if (MessageBox.Show("Concluir venda " + txtNumVenda.Text.ToString() + "?", "Concluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idCliente = 0;
                        if (cboClientes.SelectedValue != null)
                        {
                            if (Convert.ToInt32(cboClientes.SelectedValue.ToString()) > 0)
                            {
                                idCliente = Convert.ToInt32(cboClientes.SelectedValue.ToString());
                            }
                        }

                        int idFormaPgto = 0;
                        if (Convert.ToInt32(cboFormaPgto.SelectedValue.ToString()) > 0)
                        {
                            idFormaPgto = Convert.ToInt32(cboFormaPgto.SelectedValue.ToString());
                        }

                        String vl_total = txtValorTotal.Text; //nunca salvo o valor com desconto.. devo sempre fazer a multiplicacao para saber o valor do pedido.
                                                              //descontoAplicado vai com 0 se nao tiver..

                        if (decimal.Parse(vl_total) >= 1000)
                        {
                            vl_total = vl_total.Replace(".", "");
                            vl_total = vl_total.Replace(",", "");
                            vl_total = vl_total.Insert(vl_total.Length - 2, ".");
                        }

                        String sQuerySalvar = "insert into vendas(id_cliente, id_forma_pgto, desconto, nome_cliente, valor_total, data)";
                        sQuerySalvar += " values (" + idCliente.ToString() + "," + idFormaPgto.ToString() + "," + descontoAplicado.ToString().Replace(",", ".") + ",'" + cboClientes.Text + "'," + vl_total.Replace(",", ".") + ", getdate())";
                        sQuerySalvar += " SELECT SCOPE_IDENTITY() as idVenda";

                        int num_ped = 0;
                        try
                        {
                            num_ped = int.Parse(c.RetornaQuery(sQuerySalvar, "idVenda"));
                        }
                        catch(Exception ex)
                        {
                          //  MessageBox.Show("Erro ao concluir venda:\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto DEUERRO;
                        }

                        if (num_ped != 0)
                        {
                            String idProcedimento = "null";
                            String idAdicional = "null";
                            String idFuncionario = "null";

                            String sQuerySalvarItens = "";

                            for (int i = 0; i < grdVenda.Rows.Count; i++)
                            {
                                if (grdVenda.Rows[i].Cells[5].Value.ToString() != "desconto")
                                {
                                    if (grdVenda.Rows[i].Cells[5].Value.ToString() == "procedimento")
                                    {
                                        idProcedimento = grdVenda.Rows[i].Cells[4].Value.ToString();
                                        idFuncionario = grdVenda.Rows[i].Cells[6].Value.ToString();
                                    }
                                    else if (grdVenda.Rows[i].Cells[5].Value.ToString() == "adicional")
                                    {
                                        idAdicional = grdVenda.Rows[i].Cells[4].Value.ToString();
                                    }

                                    String sItenVl;
                                    if (decimal.Parse(grdVenda.Rows[i].Cells[3].Value.ToString().Replace("R$ ","")) >= 1000)
                                    {
                                        sItenVl = grdVenda.Rows[i].Cells[3].Value.ToString().Replace(".", "");
                                        sItenVl = sItenVl.Replace(",", "");
                                        sItenVl = sItenVl.Replace("R$ ", "");
                                        sItenVl = sItenVl.Insert(sItenVl.Length - 2, ".");
                                    }
                                    else
                                    {
                                        sItenVl = grdVenda.Rows[i].Cells[3].Value.ToString().Replace(",", ".");
                                        sItenVl = sItenVl.Replace("R$ ", "");
                                    }

                                    sQuerySalvarItens = "insert into vendas_itens(id_venda, id_procedimento, id_adicional, id_func, vl_total_item)";
                                    sQuerySalvarItens += " values (" + num_ped.ToString() + "," + idProcedimento + "," + idAdicional + "," + idFuncionario + "," + sItenVl + ")";

                                    idProcedimento = "null";
                                    idAdicional = "null";
                                    idFuncionario = "null";

                                    c.ExecutaQuery(sQuerySalvarItens);
                                }
                            }

                            MessageBox.Show("Venda gravada com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cboClientes.SelectedIndex = -1;
                            cboFuncionarios.SelectedIndex = -1;
                            cboProcedimento.SelectedIndex = -1;
                            cboAdicional.SelectedIndex = -1;
                            cboFormaPgto.SelectedIndex = -1;
                            chkDesconto.Checked = false;
                            txtDesconto.Text = "";
                            txtDesconto.Enabled = false;
                            btnAddDesconto.Enabled = false;
                            grdVenda.Rows.Clear();
                            txtValorTotal.Text = "";
                            txtValorTotComDesconto.Text = "";
                            lblRSDesconto.Visible = false;
                            lblTotDesconto.Visible = false;
                            txtValorTotComDesconto.Visible = false;
                            btnDelItem.Enabled = false;
                            btnDelItem.Visible = false;

                            int id = c.RetornaIdVendaAtual();
                            txtNumVenda.Text = id.ToString().PadLeft(6, '0');
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Selecione uma forma de pagamento.", "Forma de Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Insira pelo menos um ítem.", "Insira um ítem.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        DEUERRO: int a = 0; //do nothing
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Limpar tudo ? ", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cboClientes.SelectedIndex = -1;
                cboFuncionarios.SelectedIndex = -1;
                cboProcedimento.SelectedIndex = -1;
                cboAdicional.SelectedIndex = -1;
                cboFormaPgto.SelectedIndex = -1;
                chkDesconto.Checked = false;
                txtDesconto.Text = "";
                txtDesconto.Enabled = false;
                btnAddDesconto.Enabled = false;
                grdVenda.Rows.Clear();
                txtValorTotal.Text = "";
                txtValorTotComDesconto.Text = "";
                lblRSDesconto.Visible = false;
                lblTotDesconto.Visible = false;
                txtValorTotComDesconto.Visible = false;
                btnDelItem.Enabled = false;
                btnDelItem.Visible = false;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            int id = c.RetornaIdVendaAtual();
            txtNumVenda.Text = id.ToString().PadLeft(6, '0');
            txtNumVenda.Select(txtNumVenda.Text.Length, txtNumVenda.Text.Length);

            c.fillCombo(cboClientes, "select * from cliente where deletado <> 1 order by nome ", "id", "nome");
            cboClientes.SelectedValue = 0;

            c.fillCombo(cboFuncionarios, "select * from funcionario where deletado <> 1 order by nome", "id", "nome");
            cboFuncionarios.SelectedValue = 0;

            c.fillCombo(cboProcedimento, "select * from procedimento where deletado <> 1 order by descricao", "id", "descricao");
            cboProcedimento.SelectedValue = 0;

            c.fillCombo(cboAdicional, "select * from adicional where deletado <> 1 order by descricao", "id", "descricao");
            cboAdicional.SelectedValue = 0;

            c.fillCombo(cboFormaPgto, "select * from forma_pgto where deletado <> 1 order by descricao", "id", "descricao");
            cboFormaPgto.SelectedValue = 0;

            int idVenda = int.Parse(txtNumVenda.Text); //global, para ser usado nos inserts

            DataGridViewCellStyle aligncenter = new DataGridViewCellStyle();
            aligncenter.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdVenda.Columns[0].DefaultCellStyle = aligncenter;
            grdVenda.Columns[1].DefaultCellStyle = aligncenter;
            grdVenda.Columns[2].DefaultCellStyle = aligncenter;
            grdVenda.Columns[3].DefaultCellStyle = aligncenter;
        }
    }
}
