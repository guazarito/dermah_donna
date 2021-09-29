namespace Yumi
{
    partial class ConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaCli = new System.Windows.Forms.TextBox();
            this.grdConsultaClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome do Cliente:";
            // 
            // txtBuscaCli
            // 
            this.txtBuscaCli.Location = new System.Drawing.Point(133, 12);
            this.txtBuscaCli.Name = "txtBuscaCli";
            this.txtBuscaCli.Size = new System.Drawing.Size(319, 20);
            this.txtBuscaCli.TabIndex = 9;
            // 
            // grdConsultaClientes
            // 
            this.grdConsultaClientes.AllowUserToAddRows = false;
            this.grdConsultaClientes.AllowUserToDeleteRows = false;
            this.grdConsultaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaClientes.Location = new System.Drawing.Point(12, 48);
            this.grdConsultaClientes.MultiSelect = false;
            this.grdConsultaClientes.Name = "grdConsultaClientes";
            this.grdConsultaClientes.ReadOnly = true;
            this.grdConsultaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultaClientes.Size = new System.Drawing.Size(663, 422);
            this.grdConsultaClientes.TabIndex = 10;
            this.grdConsultaClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaClientes_CellDoubleClick);
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCli.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCli.Image")));
            this.btnBuscarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCli.Location = new System.Drawing.Point(470, 4);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(104, 35);
            this.btnBuscarCli.TabIndex = 12;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.BtnBuscarCli_Click);
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 486);
            this.Controls.Add(this.btnBuscarCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaCli);
            this.Controls.Add(this.grdConsultaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(200, 100);
            this.MaximizeBox = false;
            this.Name = "ConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consulta de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaCli;
        private System.Windows.Forms.DataGridView grdConsultaClientes;
        private System.Windows.Forms.Button btnBuscarCli;
    }
}