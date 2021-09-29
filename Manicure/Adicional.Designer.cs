namespace Yumi
{
    partial class Adicional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicional));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditarAdicional = new System.Windows.Forms.Button();
            this.btnDeletetarAdicional = new System.Windows.Forms.Button();
            this.grdAdicional = new System.Windows.Forms.DataGridView();
            this.btnLimparAdicional = new System.Windows.Forms.Button();
            this.btnSalvarAdicional = new System.Windows.Forms.Button();
            this.txtValorAdicional = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescAdicional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorColabs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorSalao = new System.Windows.Forms.TextBox();
            this.rdoValorAbs = new System.Windows.Forms.RadioButton();
            this.rdoPorcentagem = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdAdicional)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "R$";
            // 
            // btnEditarAdicional
            // 
            this.btnEditarAdicional.Enabled = false;
            this.btnEditarAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAdicional.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAdicional.Image")));
            this.btnEditarAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAdicional.Location = new System.Drawing.Point(20, 373);
            this.btnEditarAdicional.Name = "btnEditarAdicional";
            this.btnEditarAdicional.Size = new System.Drawing.Size(78, 23);
            this.btnEditarAdicional.TabIndex = 30;
            this.btnEditarAdicional.Text = "Editar";
            this.btnEditarAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAdicional.UseVisualStyleBackColor = true;
            this.btnEditarAdicional.Click += new System.EventHandler(this.BtnEditarAdicional_Click);
            // 
            // btnDeletetarAdicional
            // 
            this.btnDeletetarAdicional.Enabled = false;
            this.btnDeletetarAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletetarAdicional.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletetarAdicional.Image")));
            this.btnDeletetarAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletetarAdicional.Location = new System.Drawing.Point(465, 375);
            this.btnDeletetarAdicional.Name = "btnDeletetarAdicional";
            this.btnDeletetarAdicional.Size = new System.Drawing.Size(78, 23);
            this.btnDeletetarAdicional.TabIndex = 27;
            this.btnDeletetarAdicional.Text = "Deletar";
            this.btnDeletetarAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletetarAdicional.UseVisualStyleBackColor = true;
            this.btnDeletetarAdicional.Click += new System.EventHandler(this.BtnDeletetarAdicional_Click);
            // 
            // grdAdicional
            // 
            this.grdAdicional.AllowUserToAddRows = false;
            this.grdAdicional.AllowUserToDeleteRows = false;
            this.grdAdicional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAdicional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAdicional.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdAdicional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAdicional.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdAdicional.Location = new System.Drawing.Point(17, 165);
            this.grdAdicional.MultiSelect = false;
            this.grdAdicional.Name = "grdAdicional";
            this.grdAdicional.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAdicional.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdAdicional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAdicional.ShowEditingIcon = false;
            this.grdAdicional.Size = new System.Drawing.Size(537, 199);
            this.grdAdicional.TabIndex = 26;
            this.grdAdicional.TabStop = false;
            this.grdAdicional.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdAdicional_CellClick);
            // 
            // btnLimparAdicional
            // 
            this.btnLimparAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAdicional.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparAdicional.Image")));
            this.btnLimparAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparAdicional.Location = new System.Drawing.Point(465, 91);
            this.btnLimparAdicional.Name = "btnLimparAdicional";
            this.btnLimparAdicional.Size = new System.Drawing.Size(92, 32);
            this.btnLimparAdicional.TabIndex = 25;
            this.btnLimparAdicional.Text = "Limpar";
            this.btnLimparAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparAdicional.UseVisualStyleBackColor = true;
            this.btnLimparAdicional.Click += new System.EventHandler(this.BtnLimparAdicional_Click);
            // 
            // btnSalvarAdicional
            // 
            this.btnSalvarAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAdicional.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarAdicional.Image")));
            this.btnSalvarAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarAdicional.Location = new System.Drawing.Point(465, 43);
            this.btnSalvarAdicional.Name = "btnSalvarAdicional";
            this.btnSalvarAdicional.Size = new System.Drawing.Size(92, 32);
            this.btnSalvarAdicional.TabIndex = 24;
            this.btnSalvarAdicional.Text = "Salvar";
            this.btnSalvarAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAdicional.UseVisualStyleBackColor = true;
            this.btnSalvarAdicional.Click += new System.EventHandler(this.BtnSalvarAdicional_Click);
            // 
            // txtValorAdicional
            // 
            this.txtValorAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAdicional.Location = new System.Drawing.Point(43, 99);
            this.txtValorAdicional.MaxLength = 50;
            this.txtValorAdicional.Name = "txtValorAdicional";
            this.txtValorAdicional.Size = new System.Drawing.Size(151, 21);
            this.txtValorAdicional.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valor";
            // 
            // txtDescAdicional
            // 
            this.txtDescAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescAdicional.Location = new System.Drawing.Point(17, 31);
            this.txtDescAdicional.MaxLength = 100;
            this.txtDescAdicional.Name = "txtDescAdicional";
            this.txtDescAdicional.Size = new System.Drawing.Size(430, 21);
            this.txtDescAdicional.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Adicional";
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
            this.groupBox1.Location = new System.Drawing.Point(211, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 101);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Financeiro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 73);
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
            this.label6.Location = new System.Drawing.Point(210, 46);
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
            this.label4.Location = new System.Drawing.Point(2, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Colaboradores";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorColabs
            // 
            this.txtValorColabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorColabs.Location = new System.Drawing.Point(106, 70);
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
            this.label5.Location = new System.Drawing.Point(2, 46);
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
            this.txtValorSalao.Location = new System.Drawing.Point(106, 43);
            this.txtValorSalao.MaxLength = 50;
            this.txtValorSalao.Name = "txtValorSalao";
            this.txtValorSalao.Size = new System.Drawing.Size(98, 21);
            this.txtValorSalao.TabIndex = 22;
            this.txtValorSalao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoValorAbs
            // 
            this.rdoValorAbs.AutoSize = true;
            this.rdoValorAbs.Location = new System.Drawing.Point(122, 19);
            this.rdoValorAbs.Name = "rdoValorAbs";
            this.rdoValorAbs.Size = new System.Drawing.Size(92, 17);
            this.rdoValorAbs.TabIndex = 1;
            this.rdoValorAbs.TabStop = true;
            this.rdoValorAbs.Text = "Valor absoluto";
            this.rdoValorAbs.UseVisualStyleBackColor = true;
            // 
            // rdoPorcentagem
            // 
            this.rdoPorcentagem.AutoSize = true;
            this.rdoPorcentagem.Location = new System.Drawing.Point(23, 19);
            this.rdoPorcentagem.Name = "rdoPorcentagem";
            this.rdoPorcentagem.Size = new System.Drawing.Size(88, 17);
            this.rdoPorcentagem.TabIndex = 0;
            this.rdoPorcentagem.TabStop = true;
            this.rdoPorcentagem.Text = "Porcentagem";
            this.rdoPorcentagem.UseVisualStyleBackColor = true;
            // 
            // Adicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditarAdicional);
            this.Controls.Add(this.btnDeletetarAdicional);
            this.Controls.Add(this.grdAdicional);
            this.Controls.Add(this.btnLimparAdicional);
            this.Controls.Add(this.btnSalvarAdicional);
            this.Controls.Add(this.txtValorAdicional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescAdicional);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(180, 180);
            this.MaximizeBox = false;
            this.Name = "Adicional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Adicional";
            this.Shown += new System.EventHandler(this.Adicional_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdAdicional)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditarAdicional;
        private System.Windows.Forms.Button btnDeletetarAdicional;
        private System.Windows.Forms.DataGridView grdAdicional;
        private System.Windows.Forms.Button btnLimparAdicional;
        private System.Windows.Forms.Button btnSalvarAdicional;
        private System.Windows.Forms.TextBox txtValorAdicional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescAdicional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorColabs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorSalao;
        private System.Windows.Forms.RadioButton rdoValorAbs;
        private System.Windows.Forms.RadioButton rdoPorcentagem;
    }
}