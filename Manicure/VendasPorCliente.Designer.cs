namespace Yumi
{
    partial class VendasPorCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdVendasClientes = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendasClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(89, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(601, 22);
            this.txtNome.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Cliente";
            // 
            // grdVendasClientes
            // 
            this.grdVendasClientes.AllowUserToAddRows = false;
            this.grdVendasClientes.AllowUserToDeleteRows = false;
            this.grdVendasClientes.AllowUserToOrderColumns = true;
            this.grdVendasClientes.AllowUserToResizeRows = false;
            this.grdVendasClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVendasClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVendasClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVendasClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdVendasClientes.Location = new System.Drawing.Point(14, 91);
            this.grdVendasClientes.MultiSelect = false;
            this.grdVendasClientes.Name = "grdVendasClientes";
            this.grdVendasClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVendasClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVendasClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdVendasClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVendasClientes.Size = new System.Drawing.Size(676, 223);
            this.grdVendasClientes.TabIndex = 72;
            this.grdVendasClientes.TabStop = false;
            this.grdVendasClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVendasClientes_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(588, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 50);
            this.btnClose.TabIndex = 76;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(22, 343);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtValorTotal.Size = new System.Drawing.Size(171, 29);
            this.txtValorTotal.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Filtro";
            // 
            // cboFiltro
            // 
            this.cboFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Ver últimas 3 visitas",
            "Ver últimas 5 visitas",
            "Ver últimas 10 visitas",
            "Ver todas visitas"});
            this.cboFiltro.Location = new System.Drawing.Point(89, 58);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(213, 24);
            this.cboFiltro.TabIndex = 78;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // VendasPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 383);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.grdVendasClientes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Location = new System.Drawing.Point(200, 100);
            this.MaximizeBox = false;
            this.Name = "VendasPorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vendas por Cliente";
            this.Shown += new System.EventHandler(this.VendasPorCliente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdVendasClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdVendasClientes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFiltro;
    }
}