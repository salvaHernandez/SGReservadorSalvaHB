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
                administrarToolStripMenuItem.Visible = false;
                informesToolStripMenuItem.Visible = false;
                administrarToolStripMenuItem.Enabled = false;
                informesToolStripMenuItem.Enabled = false;
            }
            else
            {
                reservasToolStripMenuItem.Visible = false;
                reservasToolStripMenuItem.Enabled = false;
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
            if (this.MdiChildren.Length > 0 && this.MdiChildren[0].Name != "FormAdmUsu1")
            {
                    this.MdiChildren[0].Close();
            }
            FormAdmUsu1 s = new FormAdmUsu1();
            s.MdiParent = this;
            s.Dock = DockStyle.Fill;
            s.Show();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 && this.MdiChildren[0].Name != "FormReservas")
            {
                    this.MdiChildren[0].Close();
            }
            FormReservas s = new FormReservas();
            s.MdiParent = this;
            s.Dock = DockStyle.Fill;
            s.Show();

        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "FormInformes")
                {
                    this.MdiChildren[0].Close();
                    FormInformes infForm = new FormInformes();
                    infForm.MdiParent = this;
                    infForm.Dock = DockStyle.Fill;
                    infForm.Show();
                }
            } else
            {
                FormInformes infForm1 = new FormInformes();
                infForm1.MdiParent = this;
                infForm1.Dock = DockStyle.Fill;
                infForm1.Show();
            }


        }
    }
}
