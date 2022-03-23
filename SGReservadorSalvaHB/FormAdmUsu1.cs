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
    public partial class FormAdmUsu1 : Form
    {
        reservadorDataSet dsbd = new reservadorDataSet();

        public FormAdmUsu1()
        {
            InitializeComponent();
            CargarPerfiles();
        }

        private void CargarPerfiles()
        {
            reservadorDataSetTableAdapters.PERFILESTableAdapter taReservas = new reservadorDataSetTableAdapters.PERFILESTableAdapter();
            taReservas.Fill(dsbd.PERFILES);

            for (int i = 0; i < dsbd.PERFILES.Count; i++)
            {
                cmbPerfiles.Items.Add(dsbd.PERFILES[i].Descripcion);
            }
        }

        private void cmbPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargamos el grid view y le pasamos el perfil en numero que es mas comodo
            // en la BBDD los registros empiezan por 1 y en el cmb por 0 por eso le sumamos uno
            CargarDataGridView(cmbPerfiles.SelectedIndex +1);
            
        }

        private void CargarDataGridView(int perfil)
        {
            reservadorDataSetTableAdapters.USUARIOSTableAdapter taUsuarios = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
            taUsuarios.FillByPerfil(dsbd.USUARIOS, perfil, 0);
            
            dtgvUser.Rows.Clear();

            for (int i = 0; i < dsbd.USUARIOS.Count; i ++)
            {
                dtgvUser.Rows.Add("");
                dtgvUser.Rows[i].Cells[0].Value = dsbd.USUARIOS[i].Login;
                dtgvUser.Rows[i].Cells[1].Value = dsbd.USUARIOS[i].Password;
                dtgvUser.Rows[i].Cells[2].Value = dsbd.USUARIOS[i].Email;
                dtgvUser.Rows[i].Cells[3].Value = dsbd.USUARIOS[i].Perfil;
            }


        }

        private void FormAdmUsu1_Load(object sender, EventArgs e)
        {

        }

        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvUser.SelectedRows.Count > 0)
            {
                txtLogin.Text = dtgvUser.SelectedRows[0].Cells[0].Value.ToString();
                txtPassword.Text = dtgvUser.SelectedRows[0].Cells[1].Value.ToString();
                txtEmail.Text = dtgvUser.SelectedRows[0].Cells[2].Value.ToString();

            }
        }
    }
}
