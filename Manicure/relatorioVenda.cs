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
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace Yumi
{
    public partial class relatorioVenda : Form
    {

        conexao c = new conexao();
        int numero_de_pedidos;
        bool btemDesconto = false;
        int g;
        public relatorioVenda()
        {
            InitializeComponent();

            rdoSemana.CheckedChanged += new EventHandler(rdoSemana_CheckedChanged);
            rdoHoje.CheckedChanged += new EventHandler(rdoHoje_CheckedChanged);
            rdoMes.CheckedChanged += new EventHandler(rdoMes_CheckedChanged);

            rdoSemanaFunc.CheckedChanged += new EventHandler(rdoSemanaFunc_CheckedChanged);
            rdoHojeFunc.CheckedChanged += new EventHandler(rdoHojeFunc_CheckedChanged);
            rdoMesFunc.CheckedChanged += new EventHandler(rdoMesFunc_CheckedChanged);

            rdoSemanaFuncDet.CheckedChanged += new EventHandler(rdoSemanaFuncDet_CheckedChanged);
            rdoHojeFuncDet.CheckedChanged += new EventHandler(rdoHojeFuncDet_CheckedChanged);
            rdoMesFuncDet.CheckedChanged += new EventHandler(rdoMesFuncDet_CheckedChanged);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            var conn = new OdbcConnection();
            conn.ConnectionString = c.getConexaoString();
            conn.Open();

            String dtInic = dtIni.Value.ToString("yyyy-MM-dd");
            String dtFinal = dtFim.Value.ToString("yyyy-MM-dd");

            if (Convert.ToDateTime(dtInic) <= Convert.ToDateTime(dtFinal))
            {
                //grdResumoPgtos
                String sResumoPgtos;
                sResumoPgtos = "select fp.descricao as 'Forma Pagamento', count(id_forma_pgto) as 'Qtde. Vendas', cast(sum(valor_total - desconto) as varchar) as 'Valor Total Vendido', isnull(fp.naoSomaTotaisRelatorios,0) as naoSomaTotaisRelatorios from vendas left join forma_pgto fp on fp.id = vendas.id_forma_pgto";
                sResumoPgtos += " where isnull(cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";
                sResumoPgtos += " group by id_forma_pgto, fp.descricao, fp.naoSomaTotaisRelatorios ";

                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(sResumoPgtos, conn);

                OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
                ds = new DataSet();
                dataAdapter.Fill(ds);
                grdResumoPgtos.ReadOnly = true;
                grdResumoPgtos.DataSource = ds.Tables[0];

                grdResumoPgtos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoPgtos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoPgtos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grdResumoPgtos.Columns[3].Visible = false; //naoSomaTotaisRelatorios


                grdResumoPgtos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoPgtos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoPgtos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for (g = 0; g < grdResumoPgtos.RowCount; g++)
                {
                    grdResumoPgtos[2, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdResumoPgtos[2, g].Value.ToString().Replace(".", ",")));

                    if (grdResumoPgtos[3, g].Value.ToString() == "True" || grdResumoPgtos[3, g].Value.ToString() == "true")
                    {
                        grdResumoPgtos.Rows[g].Cells[0].Style.BackColor = Color.NavajoWhite;
                        grdResumoPgtos.Rows[g].Cells[1].Style.BackColor = Color.NavajoWhite;
                        grdResumoPgtos.Rows[g].Cells[2].Style.BackColor = Color.NavajoWhite;
                    }

                }

                grdResumoPgtos.ClearSelection();
                //fim grdResumoPgtos

                conn.Close();

                //grdRel
                String sRel;
                sRel = "RelatorioVendasItens '" + dtInic + "', '" + dtFinal + "'";

                OdbcDataAdapter dataAdapter2 = new OdbcDataAdapter(sRel, conn);

                OdbcCommandBuilder commandBuilder2 = new OdbcCommandBuilder(dataAdapter2);
                DataSet ds2 = new DataSet();
                dataAdapter2.Fill(ds2);
                grdRel.ReadOnly = true;
                grdRel.DataSource = ds2.Tables[0];

                grdRel.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;         

                grdRel.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRel.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
               
                grdRel.ClearSelection();
                //fim grdRel               
                
                //grdResumoItens
                String sResumoItens;
               // sResumoItens = "select p.descricao as 'Descrição', count(id_procedimento) as Quantidade, cast(sum(vl_total_item) as varchar) as 'Valor total', 'R$ 12,00' as 'Salão', 'R$ 8,00' as 'Colab' ";
               // sResumoItens += " from vendas_itens left join vendas v on v.id = vendas_itens.id_venda left join procedimento p on p.id = vendas_itens.id_procedimento";
               // sResumoItens += " where id_adicional is null and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";
               // sResumoItens += " group by id_procedimento,  p.descricao";

                sResumoItens = @"select p.descricao as 'Descrição', count(id_procedimento) as Quantidade, 
                            cast(sum(vl_total_item) as varchar) as 'Valor total', 
                            isnull(CASE 
	                            WHEN isnull(p.financTpValor,0) = 1 and isnull(f.naoSomaTotaisRelatorios,0) <> 1 then cast((sum(vl_total_item)*(p.financValorSalao/100)) as varchar)
	                            WHEN isnull(p.financTpValor,0) = 2 and isnull(f.naoSomaTotaisRelatorios,0) <> 1 then cast(p.financValorSalao as varchar)
                            end, '0') as 'Salão',
                            isnull(CASE 
	                            WHEN isnull(p.financTpValor,0) = 1  then cast((sum(vl_total_item)*(p.financValorColab/100)) as varchar)
	                            WHEN isnull(p.financTpValor,0) = 2  then cast(p.financValorColab as varchar)
                            end, '0') as 'Colab'
                            from vendas_itens 
                            left join vendas v on v.id = vendas_itens.id_venda
                            left join forma_pgto f on f.id = v.id_forma_pgto
                            left join procedimento p on p.id = vendas_itens.id_procedimento";
                sResumoItens += " where id_adicional is null and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";
                sResumoItens += " group by id_procedimento,  p.descricao, p.financTpValor, p.financValorColab, p.financValorSalao, f.naoSomaTotaisRelatorios";


                OdbcDataAdapter dataAdapter3 = new OdbcDataAdapter(sResumoItens, conn);

                OdbcCommandBuilder commandBuilder3 = new OdbcCommandBuilder(dataAdapter3);
                DataSet ds3 = new DataSet();

                dataAdapter3.Fill(ds3);
                grdResumoItens.ReadOnly = true;

                String sResumoItens2;
                //sResumoItens2 = "select 'adicional: ' + a.descricao as 'Descrição', count(id_adicional) as Quantidade, cast(sum(vl_total_item) as varchar) as 'Valor total', '0' as 'Salão', '0' as 'Colab' from vendas_itens ";
                //sResumoItens2 += " left join vendas v on v.id = vendas_itens.id_venda left join adicional a on a.id = vendas_itens.id_adicional";
                //sResumoItens2 += " where id_procedimento is null and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";
                //sResumoItens2 += " group by id_adicional,  a.descricao";

                sResumoItens2 = @"select 'adicional: ' + a.descricao as 'Descrição', count(id_adicional) as Quantidade, 
                                cast(sum(vl_total_item) as varchar) as 'Valor total', 
                                isnull(CASE 
	                                WHEN isnull(a.financTpValor,0) = 1 and isnull(f.naoSomaTotaisRelatorios,0) <> 1  then cast((count(id_adicional))*sum(vl_total_item)*(a.financValorSalao/100) as varchar)
	                                WHEN isnull(a.financTpValor,0) = 2 and isnull(f.naoSomaTotaisRelatorios,0) <> 1  then cast(count(id_adicional)*a.financValorSalao as varchar)
                                end, '0') as 'Salão',
                                isnull(CASE 
	                                WHEN isnull(a.financTpValor,0) = 1 and isnull(f.naoSomaTotaisRelatorios,0) <> 1  then cast((count(id_adicional))*sum(vl_total_item)*(a.financValorColab/100) as varchar)
	                                WHEN isnull(a.financTpValor,0) = 2 and isnull(f.naoSomaTotaisRelatorios,0) <> 1  then cast(count(id_adicional)*a.financValorColab as varchar)
                                end, '0') as 'Colab'
                                from vendas_itens 
                                left join vendas v on v.id = vendas_itens.id_venda 
                                left join forma_pgto f on f.id = v.id_forma_pgto
                                left join adicional a on a.id = vendas_itens.id_adicional";
                sResumoItens2 += " where id_procedimento is null and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";
                sResumoItens2 += " group by id_adicional,  a.descricao, a.financTpValor, a.financValorSalao, a.financValorColab, f.naoSomaTotaisRelatorios";

                OdbcDataAdapter dataAdapter4 = new OdbcDataAdapter(sResumoItens2, conn);

                OdbcCommandBuilder commandBuilder4 = new OdbcCommandBuilder(dataAdapter4);
                DataSet ds4 = new DataSet();
                dataAdapter4.Fill(ds4);

                String sResumoItens3;
                //sResumoItens3 = "select 'Desconto' as 'Descrição', count(desconto) as Quantidade , isnull(cast(sum(desconto) as varchar),0) as 'Valor total', '- R$ 0,50' as 'Salão', '- R$ 0,50' as 'Colab'  from vendas ";

                sResumoItens3 = @"select 'Desconto' as 'Descrição', count(desconto) as Quantidade, cast((isnull(sum(desconto),0)) as varchar) as 'Valor total', 
                cast((isnull(sum(desconto),0)/2) as varchar) as 'Salão', cast((isnull(sum(desconto),0)/2) as varchar) as 'Colab' from vendas";
                sResumoItens3 += " where isnull(cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and desconto <> 0";

                OdbcDataAdapter dataAdapter5 = new OdbcDataAdapter(sResumoItens3, conn);

                OdbcCommandBuilder commandBuilder5 = new OdbcCommandBuilder(dataAdapter5);
                DataSet ds5 = new DataSet();
                dataAdapter5.Fill(ds5);

                grdResumoItens.ReadOnly = true;

                DataTable datasource = ds3.Tables[0];
                datasource.Merge(ds4.Tables[0]);
                datasource.Merge(ds5.Tables[0]);

                grdResumoItens.DataSource = datasource;

                grdResumoItens.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoItens.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoItens.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoItens.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoItens.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                grdResumoItens.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoItens.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoItens.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoItens.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdResumoItens.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                Decimal valorSalao = 0;
                Decimal valorColab = 0;

                for (g = 0; g < grdResumoItens.RowCount; g++)
                {
                    if (grdResumoItens[0, g].Value.ToString() == "Desconto") { 
                        if(grdResumoItens[1, g].Value.ToString() == "0")
                        {
                            grdResumoItens.Rows.Remove(grdResumoItens.Rows[g]);
                        }
                        else
                        {
                            valorSalao -= Convert.ToDecimal(grdResumoItens[3, g].Value.ToString().Replace(".", ","));
                            valorColab -= Convert.ToDecimal(grdResumoItens[4, g].Value.ToString().Replace(".", ","));

                            grdResumoItens[2, g].Value = "- " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdResumoItens[2, g].Value.ToString().Replace(".", ",")));
                            grdResumoItens[3, g].Value = "- " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdResumoItens[3, g].Value.ToString().Replace(".", ",")));
                            grdResumoItens[4, g].Value = "- " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdResumoItens[4, g].Value.ToString().Replace(".", ",")));
                        }
                    }
                    else
                    {

                        valorSalao += Convert.ToDecimal(grdResumoItens[3, g].Value.ToString().Replace(".", ","));
                        valorColab += Convert.ToDecimal(grdResumoItens[4, g].Value.ToString().Replace(".", ","));

                        grdResumoItens[2, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdResumoItens[2, g].Value.ToString().Replace(".", ",")));
                        grdResumoItens[3, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdResumoItens[3, g].Value.ToString().Replace(".", ",")));
                        grdResumoItens[4, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdResumoItens[4, g].Value.ToString().Replace(".", ",")));
                    }
                }

                txtValorTotalSalao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valorSalao);
                txtValorTotalSalao.Text = txtValorTotalSalao.Text.Replace("R$ ", "");

                txtValorTotalColab.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valorColab);
                txtValorTotalColab.Text = txtValorTotalColab.Text.Replace("R$ ", "");

                grdResumoItens.ClearSelection();
                //fim grdRel

                //
                int j;

                numero_de_pedidos = 0;
               

                for (j = 0; j < grdRel.RowCount; j++)
                {
                    if (grdRel.RowCount > 0 && j == 1)
                    {
                        numero_de_pedidos = 1;
                    }
                    if (j > 0)
                    {
                        if (Convert.ToInt32(grdRel[1, j].Value) != Convert.ToInt32(grdRel[1, j - 1].Value))
                        {
                            numero_de_pedidos++;
                        }
                    }

                    if (grdRel[4, j].Value.ToString().Trim() == "Desconto")
                    {
                        btemDesconto = true;
                    }

                }

                if (grdRel.RowCount == 1 && numero_de_pedidos == 0)
                {
                    numero_de_pedidos = 1;
                }

                toolStripStatusLabel1.Text = "Número de vendas no período: " + numero_de_pedidos.ToString();

                String sQueryTotal = "select isnull(cast(sum(valor_total) as varchar),0) as 'total' from vendas v left join forma_pgto f on f.id = v.id_forma_pgto where isnull(f.naoSomaTotaisRelatorios,0) = 0 and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";
                txtTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(c.RetornaQuery(sQueryTotal, "total").Replace(",", "").Replace(".", ",").Replace("R$ ", "")));
                txtTotal.Text = txtTotal.Text.Replace("R$ ", "");



                if (btemDesconto)
                {
                    label22.Visible = true;
                    label23.Visible = true;
                    txtTotalDescApl.Visible = true;

                    String sQueryTotalDesconto = "select isnull(cast(sum(valor_total - (desconto)) as varchar),0) as 'total' from vendas v left join forma_pgto f on f.id = v.id_forma_pgto where isnull(f.naoSomaTotaisRelatorios,0) = 0 and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";
                    txtTotalDescApl.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(c.RetornaQuery(sQueryTotalDesconto, "total").Replace(",","").Replace(".",",").Replace("R$ ","")));
                    txtTotalDescApl.Text = txtTotalDescApl.Text.Replace("R$ ","");
                }


                
                //

            }
            else
            {
                MessageBox.Show("A data inicial deve ser MENOR OU IGUAL a data final !", "Erro datas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void rdoHoje_CheckedChanged(Object sender, EventArgs e)
        {
            if (rdoHoje.Checked == true)
            {

                dtIni.Value = DateTime.Parse(DateTime.Today.ToString("d"));
                dtFim.Value = DateTime.Parse(DateTime.Today.ToString("d"));

            }
        }

        private void rdoSemana_CheckedChanged(Object sender, EventArgs e)
        {
            DateTime dt_ini;

            int i = 7;

            dt_ini = DateTime.Parse(DateTime.Today.ToString("d"));

            if (rdoSemana.Checked == true)
            {
                dtIni.Value = DateTime.Parse(DateTime.Today.ToString("d"));
                dtFim.Value = DateTime.Parse(DateTime.Today.ToString("d"));

                while (i > 0)
                {

                    i--;

                    dt_ini = dt_ini.AddDays(-1);
                }
                dtIni.Value = dt_ini;
            }
        }

        private void rdoMes_CheckedChanged(Object sender, EventArgs e)
        {
            if (rdoMes.Checked == true)
            {
                dtIni.Value = DateTime.Parse(DateTime.Today.Year + "-" + DateTime.Today.Month + "-01");
            }
        }


        private void rdoHojeFunc_CheckedChanged(Object sender, EventArgs e)
        {
            if (rdoHojeFunc.Checked == true)
            {

                dtIniFunc.Value = DateTime.Parse(DateTime.Today.ToString("d"));
                dtFimFunc.Value = DateTime.Parse(DateTime.Today.ToString("d"));

            }
        }

        private void rdoSemanaFunc_CheckedChanged(Object sender, EventArgs e)
        {
            DateTime dt_ini;

            int i = 7;

            dt_ini = DateTime.Parse(DateTime.Today.ToString("d"));

            if (rdoSemanaFunc.Checked == true)
            {
                dtIniFunc.Value = DateTime.Parse(DateTime.Today.ToString("d"));
                dtFimFunc.Value = DateTime.Parse(DateTime.Today.ToString("d"));

                while (i > 0)
                {

                    i--;

                    dt_ini = dt_ini.AddDays(-1);
                }
                dtIniFunc.Value = dt_ini;
            }
        }

        private void rdoMesFunc_CheckedChanged(Object sender, EventArgs e)
        {

            if (rdoMesFunc.Checked == true)
            {
                dtIniFunc.Value = DateTime.Parse(DateTime.Today.Year + "-" + DateTime.Today.Month + "-01");
            }
        }


        private void rdoHojeFuncDet_CheckedChanged(Object sender, EventArgs e)
        {
            if (rdoHojeFuncDet.Checked == true)
            {

                dtIniFuncDet.Value = DateTime.Parse(DateTime.Today.ToString("d"));
                dtFimFuncDet.Value = DateTime.Parse(DateTime.Today.ToString("d"));

            }
        }

        private void rdoSemanaFuncDet_CheckedChanged(Object sender, EventArgs e)
        {
            DateTime dt_ini;

            int i = 7;

            dt_ini = DateTime.Parse(DateTime.Today.ToString("d"));

            if (rdoSemanaFuncDet.Checked == true)
            {
                dtIniFuncDet.Value = DateTime.Parse(DateTime.Today.ToString("d"));
                dtFimFuncDet.Value = DateTime.Parse(DateTime.Today.ToString("d"));

                while (i > 0)
                {

                    i--;

                    dt_ini = dt_ini.AddDays(-1);
                }
                dtIniFuncDet.Value = dt_ini;
            }
        }

        private void rdoMesFuncDet_CheckedChanged(Object sender, EventArgs e)
        {

            if (rdoMesFuncDet.Checked == true)
            {
                dtIniFuncDet.Value = DateTime.Parse(DateTime.Today.Year + "-" + DateTime.Today.Month + "-01");
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (grdRel.RowCount > 0) { 
            DialogResult result = folderBrowserDialog1.ShowDialog();

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;


            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            int i, j;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "Relatório Vendas por Período";
            xlWorkSheet.Cells[1, 1].Font.Bold = true;
            xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 3]].Merge();
            xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 3]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.Cells[1, 5] = "Data inicial: " + dtIni.Text;
            xlWorkSheet.Cells[2, 5] = "Data Final: " + dtFim.Text;

            xlWorkSheet.Cells[5, 1] = "Resumo Formas de Pagamento: ";
            xlWorkSheet.Cells[5, 1].Font.Bold = true;
            xlWorkSheet.Range[xlWorkSheet.Cells[5, 1], xlWorkSheet.Cells[5, 3]].Merge();
 
            xlWorkSheet.Cells[6, 1] = grdResumoPgtos.Columns[0].HeaderText.ToString();
            xlWorkSheet.Cells[6, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[6, 2] = grdResumoPgtos.Columns[1].HeaderText.ToString();
            xlWorkSheet.Cells[6, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[6, 3] = grdResumoPgtos.Columns[2].HeaderText.ToString();
            xlWorkSheet.Cells[6, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            int NumLinhasResumoPgtos = 0;
            for (i = 6; i < grdResumoPgtos.RowCount + 6; i++)
            {
                for (j = 0; j < grdResumoPgtos.ColumnCount; j++)
                {

                    xlWorkSheet.Cells[i + 1, j + 1] = grdResumoPgtos[j, i - 6].Value.ToString();
                    xlWorkSheet.Cells[i + 1, j + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
                NumLinhasResumoPgtos++;
            }

            NumLinhasResumoPgtos = NumLinhasResumoPgtos + 6 + 1;

            xlWorkSheet.Cells[NumLinhasResumoPgtos + 2, 1] = "Vendas detalhadas:";
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 2, 1].Font.Bold = true;
            xlWorkSheet.Range[xlWorkSheet.Cells[NumLinhasResumoPgtos + 2, 1], xlWorkSheet.Cells[NumLinhasResumoPgtos + 2, 3]].Merge();
 
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 1] = grdRel.Columns[0].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 2] = grdRel.Columns[1].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 3] = grdRel.Columns[2].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 4] = grdRel.Columns[3].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 5] = grdRel.Columns[4].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 6] = grdRel.Columns[5].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 7] = grdRel.Columns[6].HeaderText.ToString();
            //xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 8] = grdRel.Columns[7].HeaderText.ToString();
            //xlWorkSheet.Cells[NumLinhasResumoPgtos + 3, 8].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            int NumLinhasVendasDet = 0;
            for (i = NumLinhasResumoPgtos + 4; i < grdRel.RowCount + NumLinhasResumoPgtos + 4; i++)
            {
                for (j = 0; j < grdRel.ColumnCount; j++)
                {
                    xlWorkSheet.Cells[i, j + 1] = grdRel[j, i - (NumLinhasResumoPgtos + 4)].Value.ToString();
                    xlWorkSheet.Cells[i, j + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                }
                NumLinhasVendasDet++;
            }

            NumLinhasVendasDet = NumLinhasVendasDet + NumLinhasResumoPgtos + 4;

            xlWorkSheet.Cells[NumLinhasVendasDet + 2, 1] = "Resumo ítens vendidos: ";
            xlWorkSheet.Cells[NumLinhasVendasDet + 2, 1].Font.Bold = true;
            xlWorkSheet.Range[xlWorkSheet.Cells[NumLinhasVendasDet + 2, 1], xlWorkSheet.Cells[NumLinhasVendasDet + 2, 5]].Merge();

            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 1] = grdResumoItens.Columns[0].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 2] = grdResumoItens.Columns[1].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 3] = grdResumoItens.Columns[2].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 4] = grdResumoItens.Columns[3].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 5] = grdResumoItens.Columns[4].HeaderText.ToString();
            xlWorkSheet.Cells[NumLinhasVendasDet + 3, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                int NumLinhasResumoItens = 0;
            for (i = NumLinhasVendasDet + 4; i < grdResumoItens.RowCount + NumLinhasVendasDet + 4; i++)
            {
                for (j = 0; j < grdResumoItens.ColumnCount; j++)
                {
                    xlWorkSheet.Cells[i, j + 1] = grdResumoItens[j, i - (NumLinhasVendasDet + 4)].Value.ToString();
                    xlWorkSheet.Cells[i, j + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
                NumLinhasResumoItens++;
            }
            NumLinhasResumoItens = NumLinhasResumoItens + NumLinhasVendasDet + 4 +1;

           

            xlWorkSheet.Cells[NumLinhasResumoItens+ 1, 1] = "Total de pedidos: ";
            xlWorkSheet.Cells[NumLinhasResumoItens+ 1, 1].Font.Bold = true;
            xlWorkSheet.Cells[NumLinhasResumoItens+ 1, 2] =  numero_de_pedidos.ToString();
            xlWorkSheet.Cells[NumLinhasResumoItens+ 1, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[NumLinhasResumoItens+ 2, 1] = "Valor Total: ";
            xlWorkSheet.Cells[NumLinhasResumoItens+ 2, 1].Font.Bold = true;
            xlWorkSheet.Cells[NumLinhasResumoItens+ 2, 2] = "R$ " + txtTotal.Text;
            xlWorkSheet.Cells[NumLinhasResumoItens+ 2, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            if (btemDesconto)
            {
                xlWorkSheet.Cells[NumLinhasResumoItens + 3, 1] = "Valor Total c/ desc: ";
                xlWorkSheet.Cells[NumLinhasResumoItens + 3, 1].Font.Bold = true;
                xlWorkSheet.Cells[NumLinhasResumoItens + 3, 2] = "R$ " + txtTotalDescApl.Text;
                xlWorkSheet.Cells[NumLinhasResumoItens + 3, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }

                xlWorkSheet.Cells[NumLinhasResumoItens + 4, 1] = "Valor Total Salão: ";
                xlWorkSheet.Cells[NumLinhasResumoItens + 4, 1].Font.Bold = true;
                xlWorkSheet.Cells[NumLinhasResumoItens + 4, 2] = "R$ " + txtValorTotalSalao.Text;
                xlWorkSheet.Cells[NumLinhasResumoItens + 4, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                xlWorkSheet.Cells[NumLinhasResumoItens + 5, 1] = "Valor Total Colaboradores: ";
                xlWorkSheet.Cells[NumLinhasResumoItens + 5, 1].Font.Bold = true;
                xlWorkSheet.Cells[NumLinhasResumoItens + 5, 2] = "R$ " + txtValorTotalColab.Text;
                xlWorkSheet.Cells[NumLinhasResumoItens + 5, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[NumLinhasResumoItens + 3, 9]].Columns.AutoFit();



            if (result == DialogResult.OK)
            {
                String sData;
                sData = DateTime.Now.ToString("g").Replace("/", "");
                sData = sData.Replace(" ", "_");
                sData = sData.Replace(":", "");

                // MessageBox.Show(folderBrowserDialog1.SelectedPath);
                xlWorkBook.SaveAs(folderBrowserDialog1.SelectedPath + "/relatorioVendasPorPeriodo_" + sData + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
                    MessageBox.Show("Concluído");
                System.Diagnostics.Process.Start(folderBrowserDialog1.SelectedPath + "/relatorioVendasPorPeriodo_" + sData + ".xls");
            }
            }
            else{
                MessageBox.Show("Sem dados!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGeraRelFunc_Click(object sender, EventArgs e)
        {
            
            DataSet ds = null;
            var conn = new OdbcConnection();
            conn.ConnectionString = c.getConexaoString();
            conn.Open();

            String dtInic = dtIniFunc.Value.ToString("yyyy-MM-dd");
            String dtFinal = dtFimFunc.Value.ToString("yyyy-MM-dd");

            if (Convert.ToDateTime(dtInic) <= Convert.ToDateTime(dtFinal))
            {
                //grdRelFunc
                String sRelFunc;
                sRelFunc = "select f.nome as 'Nome',  count(id_func) 'Qtde. procedimentos',  cast(sum(vl_total_item) as varchar) as 'Valor Total' from vendas_itens left join ";
                sRelFunc += " funcionario f on f.id = vendas_itens.id_func left join vendas v on v.id = vendas_itens.id_venda";
                sRelFunc += " where id_adicional is null and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";
                sRelFunc += " group by id_func,f.nome";

                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(sRelFunc, conn);

                OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
                ds = new DataSet();
                dataAdapter.Fill(ds);
                grdRelFunc.ReadOnly = true;
                grdRelFunc.DataSource = ds.Tables[0];

                grdRelFunc.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRelFunc.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRelFunc.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
             
              
                grdRelFunc.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRelFunc.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdRelFunc.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for (g = 0; g < grdRelFunc.RowCount; g++)
                {
                    grdRelFunc[2, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdRelFunc[2, g].Value.ToString().Replace(".", ",")));
                }


                grdRelFunc.ClearSelection();
                //fim grdRelFunc

                String sQueryTotal = "select isnull(cast(sum(vl_total_item) as varchar),0) as 'valor total' from vendas_itens left join funcionario f on f.id = vendas_itens.id_func left join vendas v on v.id = vendas_itens.id_venda";
                sQueryTotal += " where id_adicional is null and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";

                txtTotFunc.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(c.RetornaQuery(sQueryTotal, "valor total").Replace(",", "").Replace(".", ",").Replace("R$ ", "")));
                txtTotFunc.Text = txtTotFunc.Text.Replace("R$ ", "");

                //String sTemDesconto = "select isnull(sum(desconto),0) as 'soma_desconto' from vendas_itens left join funcionario f on f.id = vendas_itens.id_func left join vendas v on v.id = vendas_itens.id_venda where id_adicional is null and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";

                //if((decimal.Parse(c.RetornaQuery(sTemDesconto, "soma_desconto")) > 0 ))
                //{
                //    //lblDescFunc.Visible = true;
                //    //lblFuncDesc2.Visible = true;
                //    //txtDescFunc.Visible = true;

                //    String sQueryTotalDesconto = "select sum(vl_total_item - (desconto*vl_total_item)) as 'valor total' from vendas_itens left join funcionario f on f.id = vendas_itens.id_func left join vendas v on v.id = vendas_itens.id_venda";
                //    sQueryTotalDesconto += " where id_adicional is null and isnull(v.cancelado,0) <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";

                //    txtDescFunc.Text = c.RetornaQuery(sQueryTotalDesconto, "valor total");
                //}


                conn.Close();

            }
    
        }
            

            private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2) 
            {
                c.fillCombo(cboFuncionarios, "select * from funcionario where isnull(deletado,0)<>1 order by nome", "id", "nome");
                if (grdFuncDet.RowCount <= 0)
                {
                    cboFuncionarios.SelectedIndex = -1;
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (cboFuncionarios.SelectedIndex != -1){
                String dtInic = dtIniFuncDet.Value.ToString("yyyy-MM-dd");
                String dtFinal = dtFimFuncDet.Value.ToString("yyyy-MM-dd");

                String sQueryDetFunc = "select  ROW_NUMBER() over(order by vi.id_venda) as ' Item',  right('00000' + cast(vi.id_venda as nvarchar),6) as 'Núm. da Venda', convert(varchar(11), v.data,103) as 'Data',";
                sQueryDetFunc += " p.descricao as 'Procedimento', v.nome_cliente as 'Cliente', fp.descricao as 'Forma Pagamento', cast(vi.vl_total_item as varchar) as 'Valor Total'";
                sQueryDetFunc += " from vendas_itens vi left join vendas v on v.id=vi.id_venda left join funcionario f on f.id= vi.id_func left join procedimento p on p.id = vi.id_procedimento";
                sQueryDetFunc += " left join forma_pgto fp on fp.id = v.id_forma_pgto";
                sQueryDetFunc += " where isnull(v.cancelado,0) <> 1 and id_func = " + cboFuncionarios.SelectedValue + " and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";


                DataSet ds = null;
                var conn = new OdbcConnection();
                conn.ConnectionString = c.getConexaoString();
                conn.Open();

                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(sQueryDetFunc, conn);

                OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
                ds = new DataSet();
                dataAdapter.Fill(ds);
                grdFuncDet.ReadOnly = true;
                grdFuncDet.DataSource = ds.Tables[0];

                grdFuncDet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                grdFuncDet.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdFuncDet.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                for (g = 0; g < grdFuncDet.RowCount; g++)
                {
                    grdFuncDet[6, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdFuncDet[6, g].Value.ToString().Replace(".", ",")));
                }

                grdFuncDet.ClearSelection();

                String sQueryTotalFuncDet = "select  isnull(cast(sum(vi.vl_total_item) as varchar),0) as 'valor total' from vendas_itens vi left join vendas v on v.id=vi.id_venda";
                sQueryTotalFuncDet += " where isnull(v.cancelado,0) <> 1 and id_func = " + cboFuncionarios.SelectedValue + " and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";

                txtValorTotalFuncDet.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(c.RetornaQuery(sQueryTotalFuncDet, "valor total").Replace(",", "").Replace(".", ",").Replace("R$ ", "")));
                txtValorTotalFuncDet.Text = txtValorTotalFuncDet.Text.Replace("R$ ", "");

            }
            else
            {
                MessageBox.Show("Selecione um funcioário.", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (grdRelFunc.RowCount > 0) { 
            DialogResult result = folderBrowserDialog1.ShowDialog();

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            int i, j;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "Relatório Vendas por Funcionário";
            xlWorkSheet.Cells[1, 1].Font.Bold = true;
            xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 5]].Merge();
            xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 5]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.Cells[1, 7] = "Data inicial: " + dtIniFunc.Text;
            xlWorkSheet.Cells[2, 7] = "Data Final: " + dtFimFunc.Text;

            xlWorkSheet.Cells[4, 1] = grdRelFunc.Columns[0].HeaderText.ToString();
            xlWorkSheet.Cells[4, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[4, 2] = grdRelFunc.Columns[1].HeaderText.ToString();
            xlWorkSheet.Cells[4, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[4, 3] = grdRelFunc.Columns[2].HeaderText.ToString();
            xlWorkSheet.Cells[4, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            int num_linhas = 0;
            for (i = 5; i < grdRelFunc.RowCount + 5; i++)
            {
                for (j = 0; j < grdRelFunc.ColumnCount; j++)
                {

                    xlWorkSheet.Cells[i, j + 1] = grdRelFunc[j, i - 5].Value.ToString();
                    xlWorkSheet.Cells[i, j + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
                num_linhas++;
            }

            xlWorkSheet.Cells[num_linhas + 6, 1] = "Valor Total: ";
            xlWorkSheet.Cells[num_linhas + 6, 1].Font.Bold = true;
            xlWorkSheet.Cells[num_linhas + 6, 2] = "R$ " + txtTotFunc.Text;
            xlWorkSheet.Cells[num_linhas + 6, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[num_linhas + 6 + 3, 9]].Columns.AutoFit();



            if (result == DialogResult.OK)
            {
                String sData;
                sData = DateTime.Now.ToString("g").Replace("/", "");
                sData = sData.Replace(" ", "_");
                sData = sData.Replace(":", "");

                // MessageBox.Show(folderBrowserDialog1.SelectedPath);
                xlWorkBook.SaveAs(folderBrowserDialog1.SelectedPath + "/relatorioVendasPorFuncionario_" + sData + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);


                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
                    MessageBox.Show("Concluído");
                System.Diagnostics.Process.Start(folderBrowserDialog1.SelectedPath + "/relatorioVendasPorFuncionario_" + sData + ".xls");

            }
            }
            else
            {
                MessageBox.Show("Sem dados!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if(grdFuncDet.RowCount > 0) { 
            DialogResult result = folderBrowserDialog1.ShowDialog();

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

                Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            int i, j;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "Relatório Vendas por Funcionário Detalhado";
            xlWorkSheet.Cells[1, 1].Font.Bold = true;
            xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 5]].Merge();
            xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 5]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;


            xlWorkSheet.Cells[1, 7] = c.RetornaQuery("select nome from funcionario where id = " + cboFuncionarios.SelectedValue, "nome");
            xlWorkSheet.Cells[1, 7].Font.Bold = true;
            xlWorkSheet.Cells[2, 7] = "Data inicial: " + dtIniFuncDet.Text;
            xlWorkSheet.Cells[3, 7] = "Data Final: " + dtFimFuncDet.Text;

            xlWorkSheet.Cells[5, 1] = grdFuncDet.Columns[0].HeaderText.ToString();
            xlWorkSheet.Cells[5, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[5, 2] = grdFuncDet.Columns[1].HeaderText.ToString();
            xlWorkSheet.Cells[5, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[5, 3] = grdFuncDet.Columns[2].HeaderText.ToString();
            xlWorkSheet.Cells[5, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[5, 4] = grdFuncDet.Columns[2].HeaderText.ToString();
            xlWorkSheet.Cells[5, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[5, 5] = grdFuncDet.Columns[2].HeaderText.ToString();
            xlWorkSheet.Cells[5, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[5, 6] = grdFuncDet.Columns[2].HeaderText.ToString();
            xlWorkSheet.Cells[5, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Cells[5, 7] = grdFuncDet.Columns[2].HeaderText.ToString();
            xlWorkSheet.Cells[5, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            int num_linhas = 0;
            for (i = 6; i < grdFuncDet.RowCount + 6; i++)
            {
                for (j = 0; j < grdFuncDet.ColumnCount; j++)
                {

                    xlWorkSheet.Cells[i, j + 1] = grdFuncDet[j, i - 6].Value.ToString();
                    xlWorkSheet.Cells[i, j + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
                num_linhas++;
            }

            xlWorkSheet.Cells[num_linhas + 8, 1] = "Valor Total: ";
            xlWorkSheet.Cells[num_linhas + 8, 1].Font.Bold = true;
            xlWorkSheet.Cells[num_linhas + 8, 2] = "R$ " + txtValorTotalFuncDet.Text;
            xlWorkSheet.Cells[num_linhas + 8, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[num_linhas + 8 + 3, 9]].Columns.AutoFit();



            if (result == DialogResult.OK)
            {
                String sData;
                sData = DateTime.Now.ToString("g").Replace("/", "");
                sData = sData.Replace(" ", "_");
                sData = sData.Replace(":", "");

                // MessageBox.Show(folderBrowserDialog1.SelectedPath);
                xlWorkBook.SaveAs(folderBrowserDialog1.SelectedPath + "/relatorioVendasPorFuncionarioDetalhado_" + sData + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
                    MessageBox.Show("Concluído");
                System.Diagnostics.Process.Start(folderBrowserDialog1.SelectedPath + "/relatorioVendasPorFuncionarioDetalhado_" + sData + ".xls");

            }
            }
            else
            {
                MessageBox.Show("Sem dados!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
     
}
