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
using System.ServiceProcess;
using System.Linq;

namespace Yumi
{

    public partial class MDIParent1 : Form
    {


        public MDIParent1()
        {

            InitializeComponent();

            ChecaAtualizacaoVersao();

            // ChecaLicenca();

            /*if (serviceExists("Dermahdonna_SincronizaBancos") && !serviceIsRunning("Dermahdonna_SincronizaBancos"))
            {
                Console.WriteLine("Service exists");
                startService("Dermahdonna_SincronizaBancos");
            }
            else
            {
                Console.WriteLine("Service doesn't exists");
            }*/

        }

        public bool serviceExists(string ServiceName)
        {
            return ServiceController.GetServices().Any(serviceController => serviceController.ServiceName.Equals(ServiceName));
        }

        public void startService(string ServiceName)
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = ServiceName;

            Console.WriteLine("The {0} service status is currently set to {1}", ServiceName, sc.Status.ToString());

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                // Start the service if the current status is stopped.
                Console.WriteLine("Starting the {0} service ...", ServiceName);
                try
                {
                    // Start the service, and wait until its status is "Running".
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);

                    // Display the current service status.
                    Console.WriteLine("The {0} service status is now set to {1}.", ServiceName, sc.Status.ToString());
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Could not start the {0} service.", ServiceName);
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Service {0} already running.", ServiceName);
            }
        }

        public bool serviceIsRunning(string ServiceName)
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = ServiceName;

            if (sc.Status == ServiceControllerStatus.Running)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            toolMnuConsulta.Location = new Point(toolMnuCadastro.Location.X, 198);

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

            //relatorioVenda newMDIChild = new relatorioVenda();
            Senha newMDIChild = new Senha();

            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        public class DataObject
        {
            public string Name { get; set; }
        }


        async private void ChecaAtualizacaoVersao()
        {
            
            HttpClient client = new HttpClient();
            
            try
            {
                    HttpResponseMessage response = await client.GetAsync("http://justicaararaquara.com.br/api/dermahdonna/atualizaversao");

                    if (response.StatusCode == HttpStatusCode.Continue) return;

                    if (response.IsSuccessStatusCode)
                    {
                    conexao c = new conexao();
                        try
                        {
                            pnlAtualizaVersao.Visible = true;
                            String receiveStream = response.Content.ReadAsStringAsync().Result.Replace("\n", "").Trim();
                            String[] scripts = receiveStream.Split('#');

                            int i;
                            for (i = 0; i < scripts.Length; i++)
                            {
                                Console.Write(scripts[i]);
                            try
                            {
                                c.ExecutaQuery(scripts[i]);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Erro ao alterar versão!\nEntre em contato com o desenvolvedor.\n" + e.Message, "Opss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //this.Close();
                            }

                        }
                            pnlAtualizaVersao.Visible = false;
                            MessageBox.Show("Versão atualizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show("Erro ao alterar versão!\nEntre em contato com o desenvolvedor.\n" + e.Message, "Opss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show(response.StatusCode + ": Erro ao alterar versão!\nVerifique sua conexão com internet e/ou entre em contato com o desenvolvedor.", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //this.Close();
                    }
            }
            catch (Exception ex)
            {

            }
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

            ConsultaClientes newMDIChild = new ConsultaClientes(this);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = "timer executou " + DateTime.Now.ToString();
            if (serviceExists("Dermahdonna_SincronizaBancos") && !serviceIsRunning("Dermahdonna_SincronizaBancos"))
            {
                Console.WriteLine("Service exists");
                startService("Dermahdonna_SincronizaBancos");
            }
            else
            {
                Console.WriteLine("Service doesn't exists");
            }
        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
            mnuRelatorios.Visible = false;
            toolMnuConsulta.Visible = false;

            despesas newMDIChild = new despesas();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }


        private void trocarSenhaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TrocarSenha newMDIChild = new TrocarSenha();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

    }
}
