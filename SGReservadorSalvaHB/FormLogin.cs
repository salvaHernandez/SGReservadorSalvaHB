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
    
    public partial class FormLogin : Form
    {
        reservadorDataSet dsbd = new reservadorDataSet();
        public FormLogin()
        {
            InitializeComponent();
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void entrar()
        {
            reservadorDataSetTableAdapters.USUARIOSTableAdapter taUsuarios = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
            taUsuarios.Fill(dsbd.USUARIOS, 0);
            bool existeUsusario = false;
            int perfil = 0;

            for (int i = 0; i < dsbd.USUARIOS.Count; i++)
            {
                if (dsbd.USUARIOS[i].Login == txtUsuario.Text && dsbd.USUARIOS[i].Password == txtPass.Text)
                {
                    existeUsusario = true;
                    perfil = dsbd.USUARIOS[i].Perfil;
                }
            }
            if (existeUsusario)
            {
                GlobalVaribleClass.userName = txtUsuario.Text;
                this.Hide();
                txtPass.Clear();
                txtUsuario.Clear();
                FormPrincipal f = new FormPrincipal(this, perfil);
                
                f.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
                txtPass.Clear();
                txtUsuario.Clear();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            entrar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entrar();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entrar();
            }
        }
    }
}
