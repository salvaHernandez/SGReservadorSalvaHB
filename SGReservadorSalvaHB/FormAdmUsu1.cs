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
                cmbPerfil.Items.Add(dsbd.PERFILES[i].Descripcion);
            }
        }

        private void cmbPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargamos el grid view y le pasamos el perfil en numero que es mas comodo
            CargarDataGridView(cmbPerfiles.SelectedIndex);
            
        }

        private void CargarDataGridView(int perfil)
        {
            limpiarTXT();
            dtgvUser.Rows.Clear();
            // en la BBDD los registros empiezan por 1 y en el cmb por 0 por eso le sumamos uno
            perfil += 1;
            reservadorDataSetTableAdapters.USUARIOSTableAdapter taUsuarios = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
            taUsuarios.FillByPerfil(dsbd.USUARIOS, perfil, 0);
            

            for (int i = 0; i < dsbd.USUARIOS.Count; i ++)
            {
                dtgvUser.Rows.Add("");
                dtgvUser.Rows[i].Cells[0].Value = dsbd.USUARIOS[i].Login;
                dtgvUser.Rows[i].Cells[1].Value = dsbd.USUARIOS[i].Password;
                dtgvUser.Rows[i].Cells[2].Value = dsbd.USUARIOS[i].Email;
                dtgvUser.Rows[i].Cells[3].Value = dsbd.USUARIOS[i].Perfil;
            }


        }

        private void limpiarTXT()
        {
            txtLogin.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cmbPerfil.Text = "";
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dtgvUser.SelectedRows.Count > 0)
            {
                reservadorDataSetTableAdapters.USUARIOSTableAdapter taUsuarios = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
                taUsuarios.UpdateDelete(dsbd.USUARIOS, 1, dtgvUser.SelectedRows[0].Cells[0].Value.ToString());
                if (dsbd.USUARIOS.Count > 0)
                {
                    MessageBox.Show("Usuario " + dtgvUser.SelectedRows[0].Cells[0].Value.ToString() + " Borrado");
                    CargarDataGridView(0);
                }
            } else MessageBox.Show("Para borrar un usuario tienes que seleccionar uno de la tabla");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (compruebaTxt())
            {
                reservadorDataSetTableAdapters.USUARIOSTableAdapter taUsuarios = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
                int perf = cmbPerfil.SelectedIndex + 1;
                taUsuarios.UpdateUsuario(dsbd.USUARIOS, txtPassword.Text, txtEmail.Text, perf, txtLogin.Text);
                if (dsbd.USUARIOS.Count > 0)
                {
                    CargarDataGridView(cmbPerfiles.SelectedIndex);
                }
            }

        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvUser.SelectedRows.Count > 0)
            {
                txtLogin.Text = dtgvUser.SelectedRows[0].Cells[0].Value.ToString();
                txtPassword.Text = dtgvUser.SelectedRows[0].Cells[1].Value.ToString();
                txtEmail.Text = dtgvUser.SelectedRows[0].Cells[2].Value.ToString();
                int perfil = int.Parse(dtgvUser.SelectedRows[0].Cells[3].Value.ToString());
                perfil -= 1;
                cmbPerfil.SelectedIndex = perfil;

            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (compruebaTxt())
            {
                reservadorDataSetTableAdapters.USUARIOSTableAdapter taUsuarios = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
                taUsuarios.FillByAloneLogin(dsbd.USUARIOS, txtLogin.Text);

                if (dsbd.USUARIOS.Count < 1)
                {
                    int perfil = cmbPerfil.SelectedIndex + 1;
                    taUsuarios.InsertUsuario(txtLogin.Text, txtPassword.Text, txtEmail.Text, perfil, 0);
                    CargarDataGridView(0);
                }
                else MessageBox.Show("El usuario " + txtLogin.Text + " ya existe, cambialo");

            }
        }

        public bool compruebaTxt()
        {
            bool camposRellenados = true;
            if (!txtLogin.Text.Trim().Equals(""))
            {
                if (!txtPassword.Text.Trim().Equals(""))
                {
                    if (!txtEmail.Text.Trim().Equals(""))
                    {
                        if (cmbPerfil.Text.Trim().Equals(""))
                        {
                            camposRellenados = false;
                            MessageBox.Show("Selecciona un perfil, Tienes que rellenar todos los campos");
                        }
                    }
                    else
                    {
                        camposRellenados = false;
                        MessageBox.Show("El campo Email está vacio, Tienes que rellenar todos los campos");
                    }
                }
                else
                {
                    camposRellenados = false;
                    MessageBox.Show("El campo Password está vacio, Tienes que rellenar todos los campos");
                }
            } else
            {
                camposRellenados = false;
                MessageBox.Show("El campo login está vacio, Tienes que rellenar todos los campos");
            }

            return camposRellenados;
        }
    }
}
