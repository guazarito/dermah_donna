namespace Yumi
{
    partial class TrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocarSenha));
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmaNovaSenha = new System.Windows.Forms.TextBox();
            this.btnSalvarAdicional = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.Location = new System.Drawing.Point(44, 38);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(251, 24);
            this.txtSenhaAtual.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha atual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nova senha";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(44, 92);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(251, 24);
            this.txtNovaSenha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar nova senha";
            // 
            // txtConfirmaNovaSenha
            // 
            this.txtConfirmaNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaNovaSenha.Location = new System.Drawing.Point(45, 149);
            this.txtConfirmaNovaSenha.Name = "txtConfirmaNovaSenha";
            this.txtConfirmaNovaSenha.PasswordChar = '*';
            this.txtConfirmaNovaSenha.Size = new System.Drawing.Size(251, 24);
            this.txtConfirmaNovaSenha.TabIndex = 5;
            // 
            // btnSalvarAdicional
            // 
            this.btnSalvarAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAdicional.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarAdicional.Image")));
            this.btnSalvarAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarAdicional.Location = new System.Drawing.Point(120, 197);
            this.btnSalvarAdicional.Name = "btnSalvarAdicional";
            this.btnSalvarAdicional.Size = new System.Drawing.Size(92, 32);
            this.btnSalvarAdicional.TabIndex = 25;
            this.btnSalvarAdicional.Text = "Salvar";
            this.btnSalvarAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarAdicional.UseVisualStyleBackColor = true;
            this.btnSalvarAdicional.Click += new System.EventHandler(this.btnSalvarAdicional_Click);
            // 
            // TrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 262);
            this.Controls.Add(this.btnSalvarAdicional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmaNovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaAtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trocar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmaNovaSenha;
        private System.Windows.Forms.Button btnSalvarAdicional;
    }
}