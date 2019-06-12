namespace Dermahdonna
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdAdicional)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 83);
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
            this.btnEditarAdicional.Location = new System.Drawing.Point(19, 324);
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
            this.btnDeletetarAdicional.Location = new System.Drawing.Point(475, 326);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAdicional.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdAdicional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAdicional.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdAdicional.Location = new System.Drawing.Point(17, 110);
            this.grdAdicional.MultiSelect = false;
            this.grdAdicional.Name = "grdAdicional";
            this.grdAdicional.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAdicional.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdAdicional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAdicional.ShowEditingIcon = false;
            this.grdAdicional.Size = new System.Drawing.Size(537, 207);
            this.grdAdicional.TabIndex = 26;
            this.grdAdicional.TabStop = false;
            this.grdAdicional.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdAdicional_CellClick);
            // 
            // btnLimparAdicional
            // 
            this.btnLimparAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAdicional.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparAdicional.Image")));
            this.btnLimparAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparAdicional.Location = new System.Drawing.Point(424, 68);
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
            this.btnSalvarAdicional.Location = new System.Drawing.Point(424, 20);
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
            this.txtValorAdicional.Location = new System.Drawing.Point(43, 81);
            this.txtValorAdicional.MaxLength = 50;
            this.txtValorAdicional.Name = "txtValorAdicional";
            this.txtValorAdicional.Size = new System.Drawing.Size(151, 21);
            this.txtValorAdicional.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 61);
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
            this.txtDescAdicional.Size = new System.Drawing.Size(371, 21);
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
            // Adicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 363);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(180, 180);
            this.MaximizeBox = false;
            this.Name = "Adicional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Adicional";
            this.Shown += new System.EventHandler(this.Adicional_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdAdicional)).EndInit();
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
    }
}