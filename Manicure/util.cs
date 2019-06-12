using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

using System.IO;


namespace Dermahdonna
{


    public class util
    {

        public void preencheGrid(DataGridView grd, String sQuery)
        {
            conexao c = new conexao();

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

            grd.ReadOnly = true;

            grd.DataSource = ds.Tables[0];

            grd.CurrentCell = null;

            // grd.Columns[0].Visible = false;

            grd.ClearSelection();

            conn.Close();
        }
    }
}