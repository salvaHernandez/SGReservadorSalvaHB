using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGReservadorSalvaHB
{
    public partial class FormPrincipal : Form
    {
        private FormLogin formLogin;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(FormLogin formLogin, int perfil)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            if (perfil == 1)
            {
                usuariosToolStripMenuItem.Visible = false;
            }
        }

        private void tslSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FormAdmAulas")
                {
                    this.MdiChildren[0].Close();

                    FormAdmAulas s = new FormAdmAulas();
                    s.MdiParent = this;
                    s.Dock = DockStyle.Fill;
                    s.Show();
                }

            }
            else
            {
                FormAdmAulas s = new FormAdmAulas();
                s.MdiParent = this;
                s.Dock = DockStyle.Fill;
                s.Show();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FormAdmUsu1")
                {
                    this.MdiChildren[0].Close();

                    FormAdmUsu1 s = new FormAdmUsu1();
                    s.MdiParent = this;
                    s.Dock = DockStyle.Fill;
                    s.Show();
                }

            }
            else
            {
                FormAdmUsu1 s = new FormAdmUsu1();
                s.MdiParent = this;
                s.Dock = DockStyle.Fill;
                s.Show();
            }
        }
    }
}
