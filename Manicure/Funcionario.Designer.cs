namespace Yumi
{
    partial class Funcionario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.btnDeletarFunc = new System.Windows.Forms.Button();
            this.grdFunc = new System.Windows.Forms.DataGridView();
            this.btnLimparCli = new System.Windows.Forms.Button();
            this.btnSalvarFunc = new System.Windows.Forms.Button();
            this.txtTelFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.Enabled = false;
            this.btnEditarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarFunc.Image")));
            this.btnEditarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarFunc.Location = new System.Drawing.Point(19, 324);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(78, 23);
            this.btnEditarFunc.TabIndex = 20;
            this.btnEditarFunc.Text = "Editar";
            this.btnEditarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarFunc.UseVisualStyleBackColor = true;
            this.btnEditarFunc.Click += new System.EventHandler(this.BtnEditarFunc_Click);
            // 
            // btnDeletarFunc
            // 
            this.btnDeletarFunc.Enabled = false;
            this.btnDeletarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarFunc.Image")));
            this.btnDeletarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletarFunc.Location = new System.Drawing.Point(475, 326);
            this.btnDeletarFunc.Name = "btnDeletarFunc";
            this.btnDeletarFunc.Size = new System.Drawing.Size(78, 23);
            this.btnDeletarFunc.TabIndex = 17;
            this.btnDeletarFunc.Text = "Deletar";
            this.btnDeletarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletarFunc.UseVisualStyleBackColor = true;
            this.btnDeletarFunc.Click += new System.EventHandler(this.BtnDeletarFunc_Click);
            // 
            // grdFunc
            // 
            this.grdFunc.AllowUserToAddRows = false;
            this.grdFunc.AllowUserToDeleteRows = false;
            this.grdFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdFunc.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdFunc.Location = new System.Drawing.Point(17, 110);
            this.grdFunc.MultiSelect = false;
            this.grdFunc.Name = "grdFunc";
            this.grdFunc.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFunc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFunc.ShowEditingIcon = false;
            this.grdFunc.Size = new System.Drawing.Size(537, 207);
            this.grdFunc.TabIndex = 16;
            this.grdFunc.TabStop = false;
            this.grdFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdFunc_CellClick);
            // 
            // btnLimparCli
            // 
            this.btnLimparCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCli.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCli.Image")));
            this.btnLimparCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCli.Location = new System.Drawing.Point(424, 68);
            this.btnLimparCli.Name = "btnLimparCli";
            this.btnLimparCli.Size = new System.Drawing.Size(92, 32);
            this.btnLimparCli.TabIndex = 15;
            this.btnLimparCli.Text = "Limpar";
            this.btnLimparCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCli.UseVisualStyleBackColor = true;
            this.btnLimparCli.Click += new System.EventHandler(this.BtnLimparCli_Click);
            // 
            // btnSalvarFunc
            // 
            this.btnSalvarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFunc.Image")));
            this.btnSalvarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarFunc.Location = new System.Drawing.Point(424, 20);
            this.btnSalvarFunc.Name = "btnSalvarFunc";
            this.btnSalvarFunc.Size = new System.Drawing.Size(92, 32);
            this.btnSalvarFunc.TabIndex = 14;
            this.btnSalvarFunc.Text = "Salvar";
            this.btnSalvarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarFunc.UseVisualStyleBackColor = true;
            this.btnSalvarFunc.Click += new System.EventHandler(this.btnSalvarFunc_Click);
            // 
            // txtTelFuncionario
            // 
            this.txtTelFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelFuncionario.Location = new System.Drawing.Point(17, 79);
            this.txtTelFuncionario.MaxLength = 50;
            this.txtTelFuncionario.Name = "txtTelFuncionario";
            this.txtTelFuncionario.Size = new System.Drawing.Size(226, 21);
            this.txtTelFuncionario.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Telefone";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(17, 31);
            this.txtNomeFuncionario.MaxLength = 50;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(337, 21);
            this.txtNomeFuncionario.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome";
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 363);
            this.Controls.Add(this.btnEditarFunc);
            this.Controls.Add(this.btnDeletarFunc);
            this.Controls.Add(this.grdFunc);
            this.Controls.Add(this.btnLimparCli);
            this.Controls.Add(this.btnSalvarFunc);
            this.Controls.Add(this.txtTelFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 100);
            this.MaximizeBox = false;
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Funcionários";
            this.Shown += new System.EventHandler(this.Funcionario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarFunc;
        private System.Windows.Forms.Button btnDeletarFunc;
        private System.Windows.Forms.DataGridView grdFunc;
        private System.Windows.Forms.Button btnLimparCli;
        private System.Windows.Forms.Button btnSalvarFunc;
        private System.Windows.Forms.TextBox txtTelFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label1;
    }
}

