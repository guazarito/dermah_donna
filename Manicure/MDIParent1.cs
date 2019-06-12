using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;
using System.Collections.Generic;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Dermahdonna
{

    public partial class MDIParent1 : Form
    {


        public MDIParent1()
        {

            InitializeComponent();

            ChecaLicenca();

        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            toggleVisibleSubMenus(toolMnuCadastro);
        }

        private void BtnRels_Click(object sender, EventArgs e)
        {
            toggleVisibleSubMenus(mnuRelatorios);
        }

        public void toggleVisibleSubMenus(ToolStripContainer tsc)
        {


            if (tsc != null)
            {
                if (tsc.Visible)
                {
                    tsc.Visible = false;
                }
                else
                {
                    tsc.Visible = true;
                    if (tsc.Name == "mnuRelatorios")
                    {
                        toolMnuCadastro.Visible = false;
                        toolMnuConsulta.Visible = false;
                    }
                    else if (tsc.Name == "toolMnuCadastro")
                    {
                        mnuRelatorios.Visible = false;
                        toolMnuConsulta.Visible = false;
                    }else if (tsc.Name == "toolMnuConsulta")
                    {
                        mnuRelatorios.Visible = false;
                        toolMnuCadastro.Visible = false;
                    }
                }
            }
            else
            {
                toolMnuCadastro.Visible = false;
                mnuRelatorios.Visible = false;
                toolMnuConsulta.Visible = false;
            }

        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            Venda newMDIChild = new Venda();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            toggleVisibleSubMenus(toolMnuConsulta);
            toolMnuConsulta.Location = new Point(toolMnuCadastro.Location.X, 168);

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;
        }

        private void BtnCadCli_Click(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            Cliente newMDIChild = new Cliente();

            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void BtnCadFunc_Click(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            Funcionario newMDIChild = new Funcionario();

            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void BtnCadProc_Click(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            Procedimento newMDIChild = new Procedimento();

            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void BtnCadAdicionais_Click(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            Adicional newMDIChild = new Adicional();

            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void BtnCadFormPgto_Click(object sender, EventArgs e)
        {

            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            FormPgto newMDIChild = new FormPgto();

            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void BtnRelVendas_Click(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            relatorioVenda newMDIChild = new relatorioVenda();

            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        public class DataObject
        {
            public string Name { get; set; }
        }


      
        async private void ChecaLicenca()
        {
            try
            {

                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync("http://justicaararaquara.com.br/api/licenca/dermahdonna");
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("sucesso");
                }
                else
                {
                    MessageBox.Show("Licença expirada! Entre em contato com o desenvolvedor.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception)
            {
                //faca nada..
            }
        }

        private void BtnConsultaVendas_Click(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            ConsultaPedidos newMDIChild = new ConsultaPedidos(this);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void BtnConsultaClientes_Click(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            ConsultaClientes newMDIChild = new ConsultaClientes();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
