namespace Yumi
{
    partial class Procedimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Procedimento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditarProc = new System.Windows.Forms.Button();
            this.btnDeletetarProc = new System.Windows.Forms.Button();
            this.grdProcedimento = new System.Windows.Forms.DataGridView();
            this.btnLimparProc = new System.Windows.Forms.Button();
            this.btnSalvarProc = new System.Windows.Forms.Button();
            this.txtValorProcedimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescProcedimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorColabs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorSalao = new System.Windows.Forms.TextBox();
            this.rdoValorAbs = new System.Windows.Forms.RadioButton();
            this.rdoPorcentagem = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcedimento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditarProc
            // 
            this.btnEditarProc.Enabled = false;
            this.btnEditarProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProc.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProc.Image")));
            this.btnEditarProc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarProc.Location = new System.Drawing.Point(19, 363);
            this.btnEditarProc.Name = "btnEditarProc";
            this.btnEditarProc.Size = new System.Drawing.Size(78, 23);
            this.btnEditarProc.TabIndex = 20;
            this.btnEditarProc.Text = "Editar";
            this.btnEditarProc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProc.UseVisualStyleBackColor = true;
            this.btnEditarProc.Click += new System.EventHandler(this.BtnEditarProc_Click);
            // 
            // btnDeletetarProc
            // 
            this.btnDeletetarProc.Enabled = false;
            this.btnDeletetarProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletetarProc.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletetarProc.Image")));
            this.btnDeletetarProc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletetarProc.Location = new System.Drawing.Point(625, 358);
            this.btnDeletetarProc.Name = "btnDeletetarProc";
            this.btnDeletetarProc.Size = new System.Drawing.Size(78, 23);
            this.btnDeletetarProc.TabIndex = 17;
            this.btnDeletetarProc.Text = "Deletar";
            this.btnDeletetarProc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletetarProc.UseVisualStyleBackColor = true;
            this.btnDeletetarProc.Click += new System.EventHandler(this.BtnDeletetarProc_Click);
            // 
            // grdProcedimento
            // 
            this.grdProcedimento.AllowUserToAddRows = false;
            this.grdProcedimento.AllowUserToDeleteRows = false;
            this.grdProcedimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProcedimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProcedimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProcedimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProcedimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdProcedimento.Location = new System.Drawing.Point(17, 165);
            this.grdProcedimento.MultiSelect = false;
            this.grdProcedimento.Name = "grdProcedimento";
            this.grdProcedimento.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProcedimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProcedimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProcedimento.ShowEditingIcon = false;
            this.grdProcedimento.Size = new System.Drawing.Size(686, 187);
            this.grdProcedimento.TabIndex = 16;
            this.grdProcedimento.TabStop = false;
            this.grdProcedimento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProcedimento_CellClick);
            // 
            // btnLimparProc
            // 
            this.btnLimparProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparProc.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparProc.Image")));
            this.btnLimparProc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparProc.Location = new System.Drawing.Point(611, 68);
            this.btnLimparProc.Name = "btnLimparProc";
            this.btnLimparProc.Size = new System.Drawing.Size(92, 32);
            this.btnLimparProc.TabIndex = 15;
            this.btnLimparProc.Text = "Limpar";
            this.btnLimparProc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparProc.UseVisualStyleBackColor = true;
            this.btnLimparProc.Click += new System.EventHandler(this.BtnLimparProc_Click);
            // 
            // btnSalvarProc
            // 
            this.btnSalvarProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProc.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProc.Image")));
            this.btnSalvarProc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarProc.Location = new System.Drawing.Point(611, 20);
            this.btnSalvarProc.Name = "btnSalvarProc";
            this.btnSalvarProc.Size = new System.Drawing.Size(92, 32);
            this.btnSalvarProc.TabIndex = 14;
            this.btnSalvarProc.Text = "Salvar";
            this.btnSalvarProc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarProc.UseVisualStyleBackColor = true;
            this.btnSalvarProc.Click += new System.EventHandler(this.BtnSalvarProc_Click);
            // 
            // txtValorProcedimento
            // 
            this.txtValorProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProcedimento.Location = new System.Drawing.Point(43, 98);
            this.txtValorProcedimento.MaxLength = 50;
            this.txtValorProcedimento.Name = "txtValorProcedimento";
            this.txtValorProcedimento.Size = new System.Drawing.Size(151, 21);
            this.txtValorProcedimento.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Valor venda";
            // 
            // txtDescProcedimento
            // 
            this.txtDescProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProcedimento.Location = new System.Drawing.Point(17, 31);
            this.txtDescProcedimento.MaxLength = 100;
            this.txtDescProcedimento.Name = "txtDescProcedimento";
            this.txtDescProcedimento.Size = new System.Drawing.Size(512, 21);
            this.txtDescProcedimento.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Procedimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "R$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValorColabs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValorSalao);
            this.groupBox1.Controls.Add(this.rdoValorAbs);
            this.groupBox1.Controls.Add(this.rdoPorcentagem);
            this.groupBox1.Location = new System.Drawing.Point(226, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 101);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Financeiro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Colaboradores";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorColabs
            // 
            this.txtValorColabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorColabs.Location = new System.Drawing.Point(150, 72);
            this.txtValorColabs.MaxLength = 50;
            this.txtValorColabs.Name = "txtValorColabs";
            this.txtValorColabs.Size = new System.Drawing.Size(98, 21);
            this.txtValorColabs.TabIndex = 25;
            this.txtValorColabs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Salão";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorSalao
            // 
            this.txtValorSalao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorSalao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorSalao.Location = new System.Drawing.Point(150, 45);
            this.txtValorSalao.MaxLength = 50;
            this.txtValorSalao.Name = "txtValorSalao";
            this.txtValorSalao.Size = new System.Drawing.Size(98, 21);
            this.txtValorSalao.TabIndex = 22;
            this.txtValorSalao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoValorAbs
            // 
            this.rdoValorAbs.AutoSize = true;
            this.rdoValorAbs.Location = new System.Drawing.Point(156, 18);
            this.rdoValorAbs.Name = "rdoValorAbs";
            this.rdoValorAbs.Size = new System.Drawing.Size(92, 17);
            this.rdoValorAbs.TabIndex = 1;
            this.rdoValorAbs.TabStop = true;
            this.rdoValorAbs.Text = "Valor absoluto";
            this.rdoValorAbs.UseVisualStyleBackColor = true;
            this.rdoValorAbs.CheckedChanged += new System.EventHandler(this.rdoValorAbs_CheckedChanged);
            // 
            // rdoPorcentagem
            // 
            this.rdoPorcentagem.AutoSize = true;
            this.rdoPorcentagem.Location = new System.Drawing.Point(65, 18);
            this.rdoPorcentagem.Name = "rdoPorcentagem";
            this.rdoPorcentagem.Size = new System.Drawing.Size(88, 17);
            this.rdoPorcentagem.TabIndex = 0;
            this.rdoPorcentagem.TabStop = true;
            this.rdoPorcentagem.Text = "Porcentagem";
            this.rdoPorcentagem.UseVisualStyleBackColor = true;
            this.rdoPorcentagem.CheckedChanged += new System.EventHandler(this.rdoPorcentagem_CheckedChanged);
            // 
            // Procedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditarProc);
            this.Controls.Add(this.btnDeletetarProc);
            this.Controls.Add(this.grdProcedimento);
            this.Controls.Add(this.btnLimparProc);
            this.Controls.Add(this.btnSalvarProc);
            this.Controls.Add(this.txtValorProcedimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescProcedimento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 170);
            this.MaximizeBox = false;
            this.Name = "Procedimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Procedimento";
            this.Shown += new System.EventHandler(this.Procedimento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdProcedimento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarProc;
        private System.Windows.Forms.Button btnDeletetarProc;
        private System.Windows.Forms.DataGridView grdProcedimento;
        private System.Windows.Forms.Button btnLimparProc;
        private System.Windows.Forms.Button btnSalvarProc;
        private System.Windows.Forms.TextBox txtValorProcedimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescProcedimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorColabs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorSalao;
        private System.Windows.Forms.RadioButton rdoValorAbs;
        private System.Windows.Forms.RadioButton rdoPorcentagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}