using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Yumi
{
    public partial class despesas : Form
    {

        conexao c = new conexao();
        util u = new util();

        public despesas()
        {
            InitializeComponent(); 
        }

        Boolean updating_despesas_gerais = false;

        private void btnSalvarDespesasGerais_Click(object sender, EventArgs e)
        {
            if (txtDescricaoDespesasGerais.Text != "" && txtValorDespesasGerais.Text != "")
            {
                txtValorDespesasGerais.Text = txtValorDespesasGerais.Text.Replace(",", ".");

            

                if (!updating_despesas_gerais) //salvando ....
                {
                    try
                    {
                        double price;
                        price = double.Parse(txtValorDespesasGerais.Text, System.Globalization.CultureInfo.InvariantCulture);
                        String sPrice = price.ToString().Replace(",", ".");
                        // MessageBox.Show(price.ToString());
                        // MessageBox.Show(price.ToString("#.#0"));
                        c.ExecutaQuery("insert into despesas (descricao, valor, data, deletado) values('" + txtDescricaoDespesasGerais.Text.ToString() + "'," + sPrice + ",cast('" + txtDataDespesasGerais.Value.ToString("yyyy-MM-dd") + "' as date), 0)");
                        preencheGridDespesasGerais(txtDataDespesasGerais.Value.ToString("yyyy-MM-dd"), txtDataDespesasGerais.Value.ToString("yyyy-MM-dd"));
                        btnLimparDespesasGerais_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Verifique se os campos estão preenchidos corretamente !");
                    }
                }
                else //atualizando....
                {
                    try
                    {
                        double price;
                        price = double.Parse(txtValorDespesasGerais.Text, System.Globalization.CultureInfo.InvariantCulture);
                        String sPrice = price.ToString().Replace(",", ".");
                        //   MessageBox.Show(sPrice);
                        //    MessageBox.Show(price.ToString("#.#0"));
                        c.ExecutaQuery("update despesas set descricao='" + txtDescricaoDespesasGerais.Text.ToString() + "', valor=" + sPrice + ", data=cast('" + txtDataDespesasGerais.Value.ToString("yyyy-MM-dd") + "' as date) where id=" + grdDespesasGerais[0, grdDespesasGerais.CurrentRow.Index].Value.ToString());
                        preencheGridDespesasGerais(txtDataDespesasGerais.Value.ToString("yyyy-MM-dd"), txtDataDespesasGerais.Value.ToString("yyyy-MM-dd"));
                        btnLimparDespesasGerais_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Verifique se os campos estão preenchidos corretamente !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void preencheGridDespesasGerais(String dtIni = null, String dtFim = null)
        {
            String sQuery;

            if (dtIni == null)
            {
                dtIni = dtPickerInicial.Value.ToString("yyyy-MM-dd");
            }
            else
            {
                dtPickerInicial.Value = new DateTime(int.Parse(dtIni.Split('-')[0]), int.Parse(dtIni.Split('-')[1]), int.Parse(dtIni.Split('-')[2]));
            }

            if (dtFim == null)
            {
                dtFim = dtPickerFinal.Value.ToString("yyyy-MM-dd");
            }
            else
            {
                dtPickerFinal.Value = new DateTime(int.Parse(dtFim.Split('-')[0]), int.Parse(dtFim.Split('-')[1]), int.Parse(dtFim.Split('-')[2]));
            }

            //total periodo
            String stotal = "select isnull(cast(sum(valor) as varchar),0) as 'valor' from despesas where convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "' and deletado <> 1";

            txtPrecoTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(c.RetornaQuery(stotal, "valor").Replace(",", "").Replace(".", ",")));

            txtPrecoTotal.Text = txtPrecoTotal.Text.Replace("R$ ", "");

            sQuery = "select id, descricao as 'Descrição', isnull(cast(valor as varchar),0) as 'Valor', convert(varchar,data,103) as 'Data Despesa' from despesas where convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "' and deletado <> 1 order by data";

            //PREENCHE O GRID..
            DataSet ds = null;
            string select = sQuery;
            var conn = new OdbcConnection();
            conn.ConnectionString = c.getConexaoString();
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            ds = new DataSet();

            dataAdapter.Fill(ds);

            grdDespesasGerais.ReadOnly = true;

            grdDespesasGerais.DataSource = ds.Tables[0];

            grdDespesasGerais.CurrentCell = null;



            grdDespesasGerais.Columns[0].Visible = false;

            int g;
            for (g = 0; g < grdDespesasGerais.RowCount; g++)
            {
                grdDespesasGerais[2, g].Value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Convert.ToDecimal(grdDespesasGerais[2, g].Value.ToString().Replace(".", ",")));
            }


            grdDespesasGerais.ClearSelection();




            conn.Close();
        }

        private void btnLimparDespesasGerais_Click(object sender, EventArgs e)
        {
            txtDataDespesasGerais.Text = DateTime.Today.ToShortDateString();
            txtDescricaoDespesasGerais.Text = "";
            txtValorDespesasGerais.Text = "";
            grdDespesasGerais.ClearSelection();
            btnDeletarDespesasGerais.Enabled = false;
            btnEditarDespesa.Enabled = false;
            updating_despesas_gerais = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            preencheGridDespesasGerais(dtPickerInicial.Value.ToString("yyyy-MM-dd"), dtPickerFinal.Value.ToString("yyyy-MM-dd"));
        }



        private void grdDespesasGerais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeletarDespesasGerais.Enabled = true;
            btnEditarDespesa.Enabled = true;
            updating_despesas_gerais = true;
        }

        private void btnDeletarDespesasGerais_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deletar a despesa '" + grdDespesasGerais[1, grdDespesasGerais.CurrentRow.Index].Value.ToString() + "' do dia " + grdDespesasGerais[3, grdDespesasGerais.CurrentRow.Index].Value.ToString() + "?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.ExecutaQuery("update despesas set deletado=1 where id =" + grdDespesasGerais[0, grdDespesasGerais.CurrentRow.Index].Value.ToString());
                preencheGridDespesasGerais(dtPickerInicial.Value.ToString("yyyy-MM-dd"), dtPickerFinal.Value.ToString("yyyy-MM-dd"));
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (grdDespesasGerais.RowCount > 0)
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                int i, j;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "Relatório Despesas Período";
                xlWorkSheet.Cells[1, 1].Font.Bold = true;
                xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 3]].Merge();
                xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 3]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                xlWorkSheet.Cells[1, 5] = "Data inicial: " + dtPickerInicial.Value.ToString("dd/MM/yyyy");
                xlWorkSheet.Cells[2, 5] = "Data Final: " + dtPickerFinal.Value.ToString("dd/MM/yyyy");

                xlWorkSheet.Cells[5, 1] = "Despesas: ";
                xlWorkSheet.Cells[5, 1].Font.Bold = true;
                xlWorkSheet.Range[xlWorkSheet.Cells[5, 1], xlWorkSheet.Cells[5, 3]].Merge();

                xlWorkSheet.Cells[6, 1] = grdDespesasGerais.Columns[1].HeaderText.ToString();
                xlWorkSheet.Cells[6, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[6, 1].Font.Bold = true;
                xlWorkSheet.Cells[6, 2] = grdDespesasGerais.Columns[2].HeaderText.ToString();
                xlWorkSheet.Cells[6, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[6, 2].Font.Bold = true;
                xlWorkSheet.Cells[6, 3] = grdDespesasGerais.Columns[3].HeaderText.ToString();
                xlWorkSheet.Cells[6, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[6, 3].Font.Bold = true;

                int NumLinhasGrd = 0;
                for (i = 6; i < grdDespesasGerais.RowCount + 6; i++)
                {
                    for (j = 1; j < grdDespesasGerais.ColumnCount; j++)
                    {

                        xlWorkSheet.Cells[i + 1, j] = grdDespesasGerais[j, i - 6].Value.ToString();
                        xlWorkSheet.Cells[i + 1, j].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }
                    NumLinhasGrd++;
                }

                xlWorkSheet.Cells[NumLinhasGrd + 8, 1] = "Valor Total Período: ";
                xlWorkSheet.Cells[NumLinhasGrd + 8, 1].Font.Bold = true;
                xlWorkSheet.Cells[NumLinhasGrd + 8, 2] = "R$ " + txtPrecoTotal.Text;

                xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[NumLinhasGrd + 10, 9]].Columns.AutoFit();


                if (result == DialogResult.OK)
                {
                    String sData;
                    sData = DateTime.Now.ToString("g").Replace("/", "");
                    sData = sData.Replace(" ", "_");
                    sData = sData.Replace(":", "");

                    // MessageBox.Show(folderBrowserDialog1.SelectedPath);
                    xlWorkBook.SaveAs(folderBrowserDialog1.SelectedPath + "/relatorioDespesasPorPeriodo_" + sData + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    MessageBox.Show("Concluído");
                    System.Diagnostics.Process.Start(folderBrowserDialog1.SelectedPath + "/relatorioDespesasPorPeriodo_" + sData + ".xls");
                }
            }
            else
            {
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

        private void despesas_Load(object sender, EventArgs e)
        {
        //    MessageBox.Show("loaded");
        //    btnLimpaFiltro.PerformClick();
        }

        private void despesas_Shown(object sender, EventArgs e)
        {
       //     MessageBox.Show("shown");
            btnVerDespesasHoje.PerformClick();
        }

        private void btnEditarDespesa_Click(object sender, EventArgs e)
        {
            txtDescricaoDespesasGerais.Text = grdDespesasGerais[1, grdDespesasGerais.CurrentRow.Index].Value.ToString();
            txtValorDespesasGerais.Text = grdDespesasGerais[2, grdDespesasGerais.CurrentRow.Index].Value.ToString().Replace("R$ ", "");

            txtDataDespesasGerais.Value = new DateTime(int.Parse(grdDespesasGerais[3, grdDespesasGerais.CurrentRow.Index].Value.ToString().Split('/')[2]), int.Parse(grdDespesasGerais[3, grdDespesasGerais.CurrentRow.Index].Value.ToString().Split('/')[1]), int.Parse(grdDespesasGerais[3, grdDespesasGerais.CurrentRow.Index].Value.ToString().Split('/')[0]));

            updating_despesas_gerais = true;
        }

        private void btnVerDespesasHoje_Click(object sender, EventArgs e)
        {
            preencheGridDespesasGerais(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
        }

        private void btnVerTodasDespesas_Click(object sender, EventArgs e)
        {
            String dtmin;
            dtmin = c.RetornaQuery("select convert(varchar,min(data), 23) as mindt from despesas", "mindt");
            preencheGridDespesasGerais(dtmin, DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
