namespace Dermahdonna
{
    partial class FormPgto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPgto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFPgto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarFPgto = new System.Windows.Forms.Button();
            this.btnEditarFpgto = new System.Windows.Forms.Button();
            this.btnDeletetarFpgto = new System.Windows.Forms.Button();
            this.grdFPgto = new System.Windows.Forms.DataGridView();
            this.btnLimparFPgto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdFPgto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFPgto
            // 
            this.txtFPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFPgto.Location = new System.Drawing.Point(14, 35);
            this.txtFPgto.MaxLength = 100;
            this.txtFPgto.Name = "txtFPgto";
            this.txtFPgto.Size = new System.Drawing.Size(361, 21);
            this.txtFPgto.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Forma de Pagamento";
            // 
            // btnSalvarFPgto
            // 
            this.btnSalvarFPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFPgto.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFPgto.Image")));
            this.btnSalvarFPgto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarFPgto.Location = new System.Drawing.Point(283, 69);
            this.btnSalvarFPgto.Name = "btnSalvarFPgto";
            this.btnSalvarFPgto.Size = new System.Drawing.Size(92, 32);
            this.btnSalvarFPgto.TabIndex = 34;
            this.btnSalvarFPgto.Text = "Salvar";
            this.btnSalvarFPgto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarFPgto.UseVisualStyleBackColor = true;
            this.btnSalvarFPgto.Click += new System.EventHandler(this.BtnSalvarFPgto_Click);
            // 
            // btnEditarFpgto
            // 
            this.btnEditarFpgto.Enabled = false;
            this.btnEditarFpgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFpgto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarFpgto.Image")));
            this.btnEditarFpgto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarFpgto.Location = new System.Drawing.Point(15, 304);
            this.btnEditarFpgto.Name = "btnEditarFpgto";
            this.btnEditarFpgto.Size = new System.Drawing.Size(78, 23);
            this.btnEditarFpgto.TabIndex = 35;
            this.btnEditarFpgto.Text = "Editar";
            this.btnEditarFpgto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarFpgto.UseVisualStyleBackColor = true;
            this.btnEditarFpgto.Click += new System.EventHandler(this.BtnEditarFpgto_Click);
            // 
            // btnDeletetarFpgto
            // 
            this.btnDeletetarFpgto.Enabled = false;
            this.btnDeletetarFpgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletetarFpgto.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletetarFpgto.Image")));
            this.btnDeletetarFpgto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletetarFpgto.Location = new System.Drawing.Point(297, 304);
            this.btnDeletetarFpgto.Name = "btnDeletetarFpgto";
            this.btnDeletetarFpgto.Size = new System.Drawing.Size(78, 23);
            this.btnDeletetarFpgto.TabIndex = 36;
            this.btnDeletetarFpgto.Text = "Deletar";
            this.btnDeletetarFpgto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletetarFpgto.UseVisualStyleBackColor = true;
            this.btnDeletetarFpgto.Click += new System.EventHandler(this.BtnDeletetarFpgto_Click);
            // 
            // grdFPgto
            // 
            this.grdFPgto.AllowUserToAddRows = false;
            this.grdFPgto.AllowUserToDeleteRows = false;
            this.grdFPgto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFPgto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFPgto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdFPgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdFPgto.DefaultCellStyle = dataGridViewCellStyle17;
            this.grdFPgto.Location = new System.Drawing.Point(12, 107);
            this.grdFPgto.MultiSelect = false;
            this.grdFPgto.Name = "grdFPgto";
            this.grdFPgto.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFPgto.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grdFPgto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFPgto.ShowEditingIcon = false;
            this.grdFPgto.Size = new System.Drawing.Size(365, 191);
            this.grdFPgto.TabIndex = 37;
            this.grdFPgto.TabStop = false;
            this.grdFPgto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdFPgto_CellClick);
            // 
            // btnLimparFPgto
            // 
            this.btnLimparFPgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFPgto.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparFPgto.Image")));
            this.btnLimparFPgto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparFPgto.Location = new System.Drawing.Point(185, 69);
            this.btnLimparFPgto.Name = "btnLimparFPgto";
            this.btnLimparFPgto.Size = new System.Drawing.Size(92, 32);
            this.btnLimparFPgto.TabIndex = 38;
            this.btnLimparFPgto.Text = "Limpar";
            this.btnLimparFPgto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparFPgto.UseVisualStyleBackColor = true;
            this.btnLimparFPgto.Click += new System.EventHandler(this.BtnLimparFPgto_Click);
            // 
            // FormPgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 340);
            this.Controls.Add(this.btnLimparFPgto);
            this.Controls.Add(this.grdFPgto);
            this.Controls.Add(this.btnDeletetarFpgto);
            this.Controls.Add(this.btnEditarFpgto);
            this.Controls.Add(this.btnSalvarFPgto);
            this.Controls.Add(this.txtFPgto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.MaximizeBox = false;
            this.Name = "FormPgto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Forma de Pagamento";
            this.Shown += new System.EventHandler(this.FormPgto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdFPgto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFPgto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarFPgto;
        private System.Windows.Forms.Button btnEditarFpgto;
        private System.Windows.Forms.Button btnDeletetarFpgto;
        private System.Windows.Forms.DataGridView grdFPgto;
        private System.Windows.Forms.Button btnLimparFPgto;
    }
}