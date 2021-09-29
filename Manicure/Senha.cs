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
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

            conexao c = new conexao();
            //if (1==1)
            if (textBox1.Text == c.RetornaQuery("select senha from senha where id=1", "senha"))
            {
                relatorioVenda newMDIChild = new relatorioVenda();
                newMDIChild.Show();

                this.Visible = false;

                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;

            }
            else
            {
                MessageBox.Show("Senha incorreta", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Arrow;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button1_Click(sender, e);
            }
        }
    }
}
