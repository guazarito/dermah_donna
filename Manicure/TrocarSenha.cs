using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yumi
{
    public partial class TrocarSenha : Form
    {
        public TrocarSenha()
        {
            InitializeComponent();
        }

        private void btnSalvarAdicional_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            conexao c = new conexao();
            if (txtSenhaAtual.Text == c.RetornaQuery("select senha from senha where id=1", "senha"))
            {
                if(txtNovaSenha.Text != txtConfirmaNovaSenha.Text)
                {
                    MessageBox.Show("Nova senha não confere com Confirmar nova senha!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        c.ExecutaQuery("update senha set senha = '" + txtNovaSenha.Text + "' where id=1");
                        MessageBox.Show("Senha alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSenhaAtual.Text = "";
                        txtNovaSenha.Text = "";
                        txtConfirmaNovaSenha.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro! Entre em contato com o desenvolvedor\n" + ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Senha atual incorreta", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
        }
    }
}
