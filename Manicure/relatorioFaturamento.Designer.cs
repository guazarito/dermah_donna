namespace Yumi
{
    partial class relatorioFaturamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatorioFaturamento));
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoMes = new System.Windows.Forms.RadioButton();
            this.rdoSemana = new System.Windows.Forms.RadioButton();
            this.rdoHoje = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtIni = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(12, 107);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(650, 379);
            this.treeView1.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoMes);
            this.groupBox3.Controls.Add(this.rdoSemana);
            this.groupBox3.Controls.Add(this.rdoHoje);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtFim);
            this.groupBox3.Controls.Add(this.dtIni);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 98);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // rdoMes
            // 
            this.rdoMes.AutoSize = true;
            this.rdoMes.Location = new System.Drawing.Point(6, 73);
            this.rdoMes.Name = "rdoMes";
            this.rdoMes.Size = new System.Drawing.Size(84, 20);
            this.rdoMes.TabIndex = 42;
            this.rdoMes.Text = "Mês atual";
            this.rdoMes.UseVisualStyleBackColor = true;
            // 
            // rdoSemana
            // 
            this.rdoSemana.AutoSize = true;
            this.rdoSemana.Location = new System.Drawing.Point(6, 47);
            this.rdoSemana.Name = "rdoSemana";
            this.rdoSemana.Size = new System.Drawing.Size(109, 20);
            this.rdoSemana.TabIndex = 41;
            this.rdoSemana.Text = "Semana atual";
            this.rdoSemana.UseVisualStyleBackColor = true;
            // 
            // rdoHoje
            // 
            this.rdoHoje.AutoSize = true;
            this.rdoHoje.Checked = true;
            this.rdoHoje.Location = new System.Drawing.Point(6, 21);
            this.rdoHoje.Name = "rdoHoje";
            this.rdoHoje.Size = new System.Drawing.Size(55, 20);
            this.rdoHoje.TabIndex = 40;
            this.rdoHoje.TabStop = true;
            this.rdoHoje.Text = "Hoje";
            this.rdoHoje.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Data Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Data Inicial";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(148, 70);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(108, 22);
            this.dtFim.TabIndex = 37;
            // 
            // dtIni
            // 
            this.dtIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIni.Location = new System.Drawing.Point(148, 28);
            this.dtIni.Name = "dtIni";
            this.dtIni.Size = new System.Drawing.Size(108, 22);
            this.dtIni.TabIndex = 36;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(383, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 35);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Gerar Relatório";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // relatorioFaturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 523);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.Name = "relatorioFaturamento";
            this.ShowIcon = false;
            this.Text = "Relatório faturamento por período";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoMes;
        private System.Windows.Forms.RadioButton rdoSemana;
        private System.Windows.Forms.RadioButton rdoHoje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtIni;
        private System.Windows.Forms.Button btnBuscar;
    }
}