using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dermahdonna
{
    public partial class despesas : Form
    {

        conexao c = new conexao();

        public despesas()
        {
            InitializeComponent();
        }

        Boolean updating_desdesas_gerais = false;

        private void btnSalvarDespesasGerais_Click(object sender, EventArgs e)
        {
            if (txtDescricaoDespesasGerais.Text != "" && txtValorDespesasGerais.Text != "")
            {
                txtValorDespesasGerais.Text = txtValorDespesasGerais.Text.Replace(",", ".");
                if (!updating_desdesas_gerais) //salvando ....
                {
                    try
                    {
                        double price;
                        price = double.Parse(txtValorDespesasGerais.Text, System.Globalization.CultureInfo.InvariantCulture);
                        String sPrice = price.ToString().Replace(",", ".");
                        // MessageBox.Show(price.ToString());
                        // MessageBox.Show(price.ToString("#.#0"));
                        c.ExecutaQuery("insert into despesas (descricao, valor, data) values('" + txtDescricaoDespesasGerais.Text.ToString() + "'," + sPrice + ",cast('" + txtDataDespesasGerais.Value.ToString("yyyy-MM-dd") + "' as date))");
                        preencheGridDespesasGerais(txtDataDespesasGerais.Value.ToString("yyyy-MM-dd"), txtDataDespesasGerais.Value.ToString("yyyy-MM-dd"));
                        btnLimparDespesasGerais_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
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
                        c.ExecutaQuery("update despesas set descricao='" + txtDescricaoDespesasGerais.Text.ToString() + "', valor=" + sPrice + ", data='" + txtDataDespesasGerais.Value.ToString("MM-dd-yyyy") + "' where id=" + grdDespesasGerais[0, grdDespesasGerais.CurrentRow.Index].Value.ToString());
                        preencheGridDespesasGerais();
                        btnLimparDespesasGerais_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
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
                dtPickerFinal.Value = new DateTime(int.Parse(dtIni.Split('-')[0]), int.Parse(dtIni.Split('-')[1]), int.Parse(dtIni.Split('-')[2]));
            }

            sQuery = "select id, descricao as 'Descrição', valor as 'Valor', convert(varchar,data,103) as 'Data Compra' from despesas where convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "' order by data";

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
            grdDespesasGerais.ClearSelection();







            conn.Close();
        }

        private void btnLimparDespesasGerais_Click(object sender, EventArgs e)
        {
            txtDataDespesasGerais.Text = DateTime.Today.ToShortDateString();
            txtDescricaoDespesasGerais.Text = "";
            txtValorDespesasGerais.Text = "";
            grdDespesasGerais.ClearSelection();
            btnDeletarDespesasGerais.Visible = false;
            updating_desdesas_gerais = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            preencheGridDespesasGerais(dtPickerInicial.Value.ToString("yyyy-MM-dd"), dtPickerFinal.Value.ToString("yyyy-MM-dd"));
        }
    }
}
