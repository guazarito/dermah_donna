namespace Yumi
{
    partial class Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFuncionarios = new System.Windows.Forms.ComboBox();
            this.cboProcedimento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAdicional = new System.Windows.Forms.ComboBox();
            this.chkDesconto = new System.Windows.Forms.CheckBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddDesconto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboFormaPgto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRSDesconto = new System.Windows.Forms.Label();
            this.lblTotDesconto = new System.Windows.Forms.Label();
            this.txtValorTotComDesconto = new System.Windows.Forms.TextBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.btnAddProcedimento = new System.Windows.Forms.Button();
            this.btnAddAdicional = new System.Windows.Forms.Button();
            this.btnConcluirPedido = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grdVenda = new System.Windows.Forms.DataGridView();
            this.ColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVenda)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda N°";
            // 
            // txtNumVenda
            // 
            this.txtNumVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumVenda.Location = new System.Drawing.Point(119, 31);
            this.txtNumVenda.Name = "txtNumVenda";
            this.txtNumVenda.ReadOnly = true;
            this.txtNumVenda.Size = new System.Drawing.Size(183, 31);
            this.txtNumVenda.TabIndex = 1;
            this.txtNumVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Funcionário";
            // 
            // cboFuncionarios
            // 
            this.cboFuncionarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboFuncionarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionarios.FormattingEnabled = true;
            this.cboFuncionarios.Location = new System.Drawing.Point(118, 151);
            this.cboFuncionarios.Name = "cboFuncionarios";
            this.cboFuncionarios.Size = new System.Drawing.Size(304, 24);
            this.cboFuncionarios.TabIndex = 5;
            // 
            // cboProcedimento
            // 
            this.cboProcedimento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProcedimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProcedimento.FormattingEnabled = true;
            this.cboProcedimento.Location = new System.Drawing.Point(118, 201);
            this.cboProcedimento.Name = "cboProcedimento";
            this.cboProcedimento.Size = new System.Drawing.Size(413, 24);
            this.cboProcedimento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Procedimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adicional";
            // 
            // cboAdicional
            // 
            this.cboAdicional.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAdicional.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdicional.FormattingEnabled = true;
            this.cboAdicional.Location = new System.Drawing.Point(118, 246);
            this.cboAdicional.Name = "cboAdicional";
            this.cboAdicional.Size = new System.Drawing.Size(413, 24);
            this.cboAdicional.TabIndex = 9;
            // 
            // chkDesconto
            // 
            this.chkDesconto.AutoSize = true;
            this.chkDesconto.Location = new System.Drawing.Point(9, 13);
            this.chkDesconto.Name = "chkDesconto";
            this.chkDesconto.Size = new System.Drawing.Size(72, 17);
            this.chkDesconto.TabIndex = 12;
            this.chkDesconto.Text = "Desconto";
            this.chkDesconto.UseVisualStyleBackColor = true;
            this.chkDesconto.CheckedChanged += new System.EventHandler(this.ChkDesconto_CheckedChanged);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(32, 41);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(55, 24);
            this.txtDesconto.TabIndex = 13;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "R$";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddDesconto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDesconto);
            this.panel1.Controls.Add(this.chkDesconto);
            this.panel1.Location = new System.Drawing.Point(439, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 80);
            this.panel1.TabIndex = 15;
            // 
            // btnAddDesconto
            // 
            this.btnAddDesconto.Enabled = false;
            this.btnAddDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDesconto.Image")));
            this.btnAddDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDesconto.Location = new System.Drawing.Point(92, 39);
            this.btnAddDesconto.Name = "btnAddDesconto";
            this.btnAddDesconto.Size = new System.Drawing.Size(95, 29);
            this.btnAddDesconto.TabIndex = 27;
            this.btnAddDesconto.Text = "Adicionar";
            this.btnAddDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDesconto.UseVisualStyleBackColor = true;
            this.btnAddDesconto.Click += new System.EventHandler(this.BtnAddDesconto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboFormaPgto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(439, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 76);
            this.panel2.TabIndex = 16;
            // 
            // cboFormaPgto
            // 
            this.cboFormaPgto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboFormaPgto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFormaPgto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboFormaPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPgto.FormattingEnabled = true;
            this.cboFormaPgto.Location = new System.Drawing.Point(16, 37);
            this.cboFormaPgto.Name = "cboFormaPgto";
            this.cboFormaPgto.Size = new System.Drawing.Size(168, 24);
            this.cboFormaPgto.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Forma de Pagamento";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(55, 497);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtValorTotal.Size = new System.Drawing.Size(90, 31);
            this.txtValorTotal.TabIndex = 17;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Valor Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "R$";
            // 
            // lblRSDesconto
            // 
            this.lblRSDesconto.AutoSize = true;
            this.lblRSDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSDesconto.Location = new System.Drawing.Point(172, 501);
            this.lblRSDesconto.Name = "lblRSDesconto";
            this.lblRSDesconto.Size = new System.Drawing.Size(33, 24);
            this.lblRSDesconto.TabIndex = 22;
            this.lblRSDesconto.Text = "R$";
            this.lblRSDesconto.Visible = false;
            // 
            // lblTotDesconto
            // 
            this.lblTotDesconto.AutoSize = true;
            this.lblTotDesconto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotDesconto.Location = new System.Drawing.Point(172, 478);
            this.lblTotDesconto.Name = "lblTotDesconto";
            this.lblTotDesconto.Size = new System.Drawing.Size(139, 16);
            this.lblTotDesconto.TabIndex = 21;
            this.lblTotDesconto.Text = "Valor com Desconto";
            this.lblTotDesconto.Visible = false;
            // 
            // txtValorTotComDesconto
            // 
            this.txtValorTotComDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorTotComDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotComDesconto.Location = new System.Drawing.Point(211, 497);
            this.txtValorTotComDesconto.Name = "txtValorTotComDesconto";
            this.txtValorTotComDesconto.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtValorTotComDesconto.Size = new System.Drawing.Size(90, 31);
            this.txtValorTotComDesconto.TabIndex = 20;
            this.txtValorTotComDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorTotComDesconto.Visible = false;
            // 
            // cboClientes
            // 
            this.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(118, 111);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(304, 26);
            this.cboClientes.TabIndex = 25;
            // 
            // btnAddProcedimento
            // 
            this.btnAddProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProcedimento.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProcedimento.Image")));
            this.btnAddProcedimento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProcedimento.Location = new System.Drawing.Point(537, 197);
            this.btnAddProcedimento.Name = "btnAddProcedimento";
            this.btnAddProcedimento.Size = new System.Drawing.Size(95, 29);
            this.btnAddProcedimento.TabIndex = 26;
            this.btnAddProcedimento.Text = "Adicionar";
            this.btnAddProcedimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProcedimento.UseVisualStyleBackColor = true;
            this.btnAddProcedimento.Click += new System.EventHandler(this.BtnAddProcedimento_Click);
            // 
            // btnAddAdicional
            // 
            this.btnAddAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdicional.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAdicional.Image")));
            this.btnAddAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAdicional.Location = new System.Drawing.Point(538, 243);
            this.btnAddAdicional.Name = "btnAddAdicional";
            this.btnAddAdicional.Size = new System.Drawing.Size(95, 29);
            this.btnAddAdicional.TabIndex = 27;
            this.btnAddAdicional.Text = "Adicionar";
            this.btnAddAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdicional.UseVisualStyleBackColor = true;
            this.btnAddAdicional.Click += new System.EventHandler(this.BtnAddAdicional_Click);
            // 
            // btnConcluirPedido
            // 
            this.btnConcluirPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluirPedido.Image")));
            this.btnConcluirPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConcluirPedido.Location = new System.Drawing.Point(515, 494);
            this.btnConcluirPedido.Name = "btnConcluirPedido";
            this.btnConcluirPedido.Size = new System.Drawing.Size(117, 34);
            this.btnConcluirPedido.TabIndex = 28;
            this.btnConcluirPedido.Text = "Concluir";
            this.btnConcluirPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConcluirPedido.UseVisualStyleBackColor = true;
            this.btnConcluirPedido.Click += new System.EventHandler(this.BtnConcluirPedido_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(375, 494);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 34);
            this.btnLimpar.TabIndex = 39;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // grdVenda
            // 
            this.grdVenda.AllowUserToAddRows = false;
            this.grdVenda.AllowUserToDeleteRows = false;
            this.grdVenda.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColItem,
            this.ColDescr,
            this.funcionario,
            this.ColPrecoItem,
            this.id_produto,
            this.tipo_produto,
            this.id_funcionario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdVenda.Location = new System.Drawing.Point(13, 288);
            this.grdVenda.MultiSelect = false;
            this.grdVenda.Name = "grdVenda";
            this.grdVenda.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVenda.Size = new System.Drawing.Size(620, 153);
            this.grdVenda.TabIndex = 40;
            this.grdVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdVenda_CellClick);
            // 
            // ColItem
            // 
            this.ColItem.HeaderText = "Item";
            this.ColItem.Name = "ColItem";
            this.ColItem.ReadOnly = true;
            this.ColItem.Width = 65;
            // 
            // ColDescr
            // 
            this.ColDescr.HeaderText = "Descrição";
            this.ColDescr.Name = "ColDescr";
            this.ColDescr.ReadOnly = true;
            this.ColDescr.Width = 270;
            // 
            // funcionario
            // 
            this.funcionario.HeaderText = "Funcionário";
            this.funcionario.Name = "funcionario";
            this.funcionario.ReadOnly = true;
            this.funcionario.Width = 140;
            // 
            // ColPrecoItem
            // 
            this.ColPrecoItem.HeaderText = "Preço Item";
            this.ColPrecoItem.Name = "ColPrecoItem";
            this.ColPrecoItem.ReadOnly = true;
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "id_produto";
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Visible = false;
            // 
            // tipo_produto
            // 
            this.tipo_produto.HeaderText = "tipo_produto";
            this.tipo_produto.Name = "tipo_produto";
            this.tipo_produto.ReadOnly = true;
            this.tipo_produto.Visible = false;
            // 
            // id_funcionario
            // 
            this.id_funcionario.HeaderText = "id_funcionario";
            this.id_funcionario.Name = "id_funcionario";
            this.id_funcionario.ReadOnly = true;
            this.id_funcionario.Visible = false;
            // 
            // btnDelItem
            // 
            this.btnDelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDelItem.Image")));
            this.btnDelItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelItem.Location = new System.Drawing.Point(489, 447);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(143, 25);
            this.btnDelItem.TabIndex = 41;
            this.btnDelItem.Text = "Deletar Item";
            this.btnDelItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Visible = false;
            this.btnDelItem.Click += new System.EventHandler(this.BtnDelItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(642, 25);
            this.toolStrip1.TabIndex = 42;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Atualizar";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 539);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDelItem);
            this.Controls.Add(this.grdVenda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConcluirPedido);
            this.Controls.Add(this.btnAddAdicional);
            this.Controls.Add(this.btnAddProcedimento);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.lblRSDesconto);
            this.Controls.Add(this.lblTotDesconto);
            this.Controls.Add(this.txtValorTotComDesconto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboAdicional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboProcedimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboFuncionarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumVenda);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVenda)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFuncionarios;
        private System.Windows.Forms.ComboBox cboProcedimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAdicional;
        private System.Windows.Forms.CheckBox chkDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboFormaPgto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRSDesconto;
        private System.Windows.Forms.Label lblTotDesconto;
        private System.Windows.Forms.TextBox txtValorTotComDesconto;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Button btnAddDesconto;
        private System.Windows.Forms.Button btnAddProcedimento;
        private System.Windows.Forms.Button btnAddAdicional;
        private System.Windows.Forms.Button btnConcluirPedido;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView grdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_funcionario;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}