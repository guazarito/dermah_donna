namespace Dermahdonna
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnVenda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnRels = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMnuCadastro = new System.Windows.Forms.ToolStripContainer();
            this.btnCadFunc = new System.Windows.Forms.Button();
            this.btnCadFormPgto = new System.Windows.Forms.Button();
            this.btnCadAdicionais = new System.Windows.Forms.Button();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.btnCadProc = new System.Windows.Forms.Button();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripContainer();
            this.btnRelVendas = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolMnuConsulta = new System.Windows.Forms.ToolStripContainer();
            this.btnConsultaClientes = new System.Windows.Forms.Button();
            this.btnConsultaVendas = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolMnuCadastro.ContentPanel.SuspendLayout();
            this.toolMnuCadastro.SuspendLayout();
            this.mnuRelatorios.ContentPanel.SuspendLayout();
            this.mnuRelatorios.SuspendLayout();
            this.toolMnuConsulta.ContentPanel.SuspendLayout();
            this.toolMnuConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 616);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnVenda
            // 
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenda.Location = new System.Drawing.Point(3, 20);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(118, 61);
            this.btnVenda.TabIndex = 4;
            this.btnVenda.Text = " Venda";
            this.btnVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.BtnVenda_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.btnRels);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.btnVenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 616);
            this.panel1.TabIndex = 6;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastro.Location = new System.Drawing.Point(3, 93);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(118, 61);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // btnRels
            // 
            this.btnRels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRels.Image = ((System.Drawing.Image)(resources.GetObject("btnRels.Image")));
            this.btnRels.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRels.Location = new System.Drawing.Point(3, 243);
            this.btnRels.Name = "btnRels";
            this.btnRels.Size = new System.Drawing.Size(118, 61);
            this.btnRels.TabIndex = 9;
            this.btnRels.Text = "Relatórios";
            this.btnRels.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRels.UseVisualStyleBackColor = true;
            this.btnRels.Click += new System.EventHandler(this.BtnRels_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.Location = new System.Drawing.Point(3, 167);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(118, 61);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // aaaaToolStripMenuItem
            // 
            this.aaaaToolStripMenuItem.Name = "aaaaToolStripMenuItem";
            this.aaaaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.aaaaToolStripMenuItem.Text = "aaaa";
            // 
            // toolMnuCadastro
            // 
            // 
            // toolMnuCadastro.ContentPanel
            // 
            this.toolMnuCadastro.ContentPanel.Controls.Add(this.btnCadFunc);
            this.toolMnuCadastro.ContentPanel.Controls.Add(this.btnCadFormPgto);
            this.toolMnuCadastro.ContentPanel.Controls.Add(this.btnCadAdicionais);
            this.toolMnuCadastro.ContentPanel.Controls.Add(this.btnCadCli);
            this.toolMnuCadastro.ContentPanel.Controls.Add(this.btnCadProc);
            this.toolMnuCadastro.ContentPanel.Size = new System.Drawing.Size(146, 154);
            this.toolMnuCadastro.Location = new System.Drawing.Point(128, 95);
            this.toolMnuCadastro.Name = "toolMnuCadastro";
            this.toolMnuCadastro.Size = new System.Drawing.Size(146, 154);
            this.toolMnuCadastro.TabIndex = 10;
            this.toolMnuCadastro.Text = "toolStripContainer1";
            this.toolMnuCadastro.Visible = false;
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnCadFunc.Image")));
            this.btnCadFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadFunc.Location = new System.Drawing.Point(0, 31);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Size = new System.Drawing.Size(144, 30);
            this.btnCadFunc.TabIndex = 5;
            this.btnCadFunc.Text = "Funcionários";
            this.btnCadFunc.UseVisualStyleBackColor = true;
            this.btnCadFunc.Click += new System.EventHandler(this.BtnCadFunc_Click);
            // 
            // btnCadFormPgto
            // 
            this.btnCadFormPgto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadFormPgto.Image")));
            this.btnCadFormPgto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadFormPgto.Location = new System.Drawing.Point(0, 122);
            this.btnCadFormPgto.Name = "btnCadFormPgto";
            this.btnCadFormPgto.Size = new System.Drawing.Size(144, 30);
            this.btnCadFormPgto.TabIndex = 4;
            this.btnCadFormPgto.Text = "Forma Pagamento";
            this.btnCadFormPgto.UseVisualStyleBackColor = true;
            this.btnCadFormPgto.Click += new System.EventHandler(this.BtnCadFormPgto_Click);
            // 
            // btnCadAdicionais
            // 
            this.btnCadAdicionais.Image = ((System.Drawing.Image)(resources.GetObject("btnCadAdicionais.Image")));
            this.btnCadAdicionais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadAdicionais.Location = new System.Drawing.Point(0, 91);
            this.btnCadAdicionais.Name = "btnCadAdicionais";
            this.btnCadAdicionais.Size = new System.Drawing.Size(144, 30);
            this.btnCadAdicionais.TabIndex = 3;
            this.btnCadAdicionais.Text = "Adicionais";
            this.btnCadAdicionais.UseVisualStyleBackColor = true;
            this.btnCadAdicionais.Click += new System.EventHandler(this.BtnCadAdicionais_Click);
            // 
            // btnCadCli
            // 
            this.btnCadCli.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCli.Image")));
            this.btnCadCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadCli.Location = new System.Drawing.Point(0, 0);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(144, 30);
            this.btnCadCli.TabIndex = 1;
            this.btnCadCli.Text = "Clientes";
            this.btnCadCli.UseVisualStyleBackColor = true;
            this.btnCadCli.Click += new System.EventHandler(this.BtnCadCli_Click);
            // 
            // btnCadProc
            // 
            this.btnCadProc.Image = ((System.Drawing.Image)(resources.GetObject("btnCadProc.Image")));
            this.btnCadProc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadProc.Location = new System.Drawing.Point(0, 61);
            this.btnCadProc.Name = "btnCadProc";
            this.btnCadProc.Size = new System.Drawing.Size(144, 30);
            this.btnCadProc.TabIndex = 0;
            this.btnCadProc.Text = "Procedimento";
            this.btnCadProc.UseVisualStyleBackColor = true;
            this.btnCadProc.Click += new System.EventHandler(this.BtnCadProc_Click);
            // 
            // mnuRelatorios
            // 
            // 
            // mnuRelatorios.ContentPanel
            // 
            this.mnuRelatorios.ContentPanel.Controls.Add(this.btnRelVendas);
            this.mnuRelatorios.ContentPanel.Size = new System.Drawing.Size(161, 39);
            this.mnuRelatorios.Location = new System.Drawing.Point(128, 255);
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(161, 39);
            this.mnuRelatorios.TabIndex = 12;
            this.mnuRelatorios.Text = "toolStripContainer1";
            this.mnuRelatorios.Visible = false;
            // 
            // btnRelVendas
            // 
            this.btnRelVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnRelVendas.Image")));
            this.btnRelVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelVendas.Location = new System.Drawing.Point(3, 6);
            this.btnRelVendas.Name = "btnRelVendas";
            this.btnRelVendas.Size = new System.Drawing.Size(158, 27);
            this.btnRelVendas.TabIndex = 0;
            this.btnRelVendas.Text = "Vendas";
            this.btnRelVendas.UseVisualStyleBackColor = true;
            this.btnRelVendas.Click += new System.EventHandler(this.BtnRelVendas_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // toolMnuConsulta
            // 
            // 
            // toolMnuConsulta.ContentPanel
            // 
            this.toolMnuConsulta.ContentPanel.Controls.Add(this.btnConsultaClientes);
            this.toolMnuConsulta.ContentPanel.Controls.Add(this.btnConsultaVendas);
            this.toolMnuConsulta.ContentPanel.Size = new System.Drawing.Size(147, 64);
            this.toolMnuConsulta.Location = new System.Drawing.Point(328, 168);
            this.toolMnuConsulta.Name = "toolMnuConsulta";
            this.toolMnuConsulta.Size = new System.Drawing.Size(147, 64);
            this.toolMnuConsulta.TabIndex = 14;
            this.toolMnuConsulta.Text = "toolStripContainer1";
            this.toolMnuConsulta.Visible = false;
            // 
            // btnConsultaClientes
            // 
            this.btnConsultaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaClientes.Image")));
            this.btnConsultaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultaClientes.Location = new System.Drawing.Point(0, 34);
            this.btnConsultaClientes.Name = "btnConsultaClientes";
            this.btnConsultaClientes.Size = new System.Drawing.Size(147, 27);
            this.btnConsultaClientes.TabIndex = 3;
            this.btnConsultaClientes.Text = "Clientes";
            this.btnConsultaClientes.UseVisualStyleBackColor = true;
            this.btnConsultaClientes.Click += new System.EventHandler(this.BtnConsultaClientes_Click);
            // 
            // btnConsultaVendas
            // 
            this.btnConsultaVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaVendas.Image")));
            this.btnConsultaVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultaVendas.Location = new System.Drawing.Point(0, 4);
            this.btnConsultaVendas.Name = "btnConsultaVendas";
            this.btnConsultaVendas.Size = new System.Drawing.Size(147, 27);
            this.btnConsultaVendas.TabIndex = 1;
            this.btnConsultaVendas.Text = "Vendas";
            this.btnConsultaVendas.UseVisualStyleBackColor = true;
            this.btnConsultaVendas.Click += new System.EventHandler(this.BtnConsultaVendas_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel1.Text = "v1.0";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1072, 638);
            this.Controls.Add(this.toolMnuConsulta);
            this.Controls.Add(this.mnuRelatorios);
            this.Controls.Add(this.toolMnuCadastro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Dermah Donna - Araraquara";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolMnuCadastro.ContentPanel.ResumeLayout(false);
            this.toolMnuCadastro.ResumeLayout(false);
            this.toolMnuCadastro.PerformLayout();
            this.mnuRelatorios.ContentPanel.ResumeLayout(false);
            this.mnuRelatorios.ResumeLayout(false);
            this.mnuRelatorios.PerformLayout();
            this.toolMnuConsulta.ContentPanel.ResumeLayout(false);
            this.toolMnuConsulta.ResumeLayout(false);
            this.toolMnuConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnRels;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolMnuCadastro;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Button btnCadProc;
        private System.Windows.Forms.ToolStripContainer mnuRelatorios;
        private System.Windows.Forms.Button btnRelVendas;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCadFormPgto;
        private System.Windows.Forms.Button btnCadAdicionais;
        private System.Windows.Forms.Button btnCadFunc;
        private System.Windows.Forms.ToolStripContainer toolMnuConsulta;
        private System.Windows.Forms.Button btnConsultaClientes;
        private System.Windows.Forms.Button btnConsultaVendas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}



