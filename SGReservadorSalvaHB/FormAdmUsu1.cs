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
        String[] perfiles;
        int[] idPerfiles;

        public FormAdmUsu1()
        {
            InitializeComponent();
            CargarPerfiles();
        }

        private void CargarPerfiles()
        {
            reservadorDataSetTableAdapters.PERFILESTableAdapter taReservas = new reservadorDataSetTableAdapters.PERFILESTableAdapter();
            taReservas.FillByOrdenAlfa(dsbd.PERFILES);
            perfiles = new string[dsbd.PERFILES.Count];
            idPerfiles = new int[dsbd.PERFILES.Count];
            for (int i = 0; i < dsbd.PERFILES.Count; i++)
            {
                perfiles[i] = dsbd.PERFILES[i].Descripcion;
                idPerfiles[i] = dsbd.PERFILES[i].Id_Perfil;
                cmbPerfil.Items.Add(perfiles[i]);
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
                DialogResult resp = MessageBox.Show("¿Esta seguro de querer eliminar este Usuario?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (resp == DialogResult.Yes)
                {
                    reservadorDataSetTableAdapters.USUARIOSTableAdapter taUsuarios = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
                    taUsuarios.UpdateDelete(-1, dtgvUser.SelectedRows[0].Cells[0].Value.ToString());
                    if (dsbd.USUARIOS.Count > 0)
                    {
                        MessageBox.Show("Usuario " + dtgvUser.SelectedRows[0].Cells[0].Value.ToString() + " Borrado");
                        CargaDtgv();
                    }
                }
            } else MessageBox.Show("Para borrar un usuario tienes que seleccionar uno de la tabla");
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (compruebaTxt())
            {
                DialogResult resp = MessageBox.Show("¿Esta seguro de querer modificar este Usuario?", "MODIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    reservadorDataSetTableAdapters.USUARIOSTableAdapter taUsuarios = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
                    int perf = idPerfiles[cmbPerfil.SelectedIndex];
                    taUsuarios.UpdateUsuario(txtPassword.Text, txtEmail.Text, perf, txtLogin.Text);
                    if (dsbd.USUARIOS.Count > 0)
                    {
                        CargaDtgv();
                    }
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
                cmbPerfil.SelectedItem = dtgvUser.SelectedRows[0].Cells[3].Value.ToString();
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
                    CargaDtgv();
                }
                else MessageBox.Show("El usuario " + txtLogin.Text + " ya existe, cambialo");

            }
        }

        public bool compruebaTxt()
        {
            bool camposRellenados = true;
            txtLogin.Text.Trim();
            if (!txtLogin.Text.Equals(""))
            {
                txtPassword.Text.Trim();
                if (!txtPassword.Text.Equals(""))
                {
                    txtEmail.Text.Trim();
                    if (!txtEmail.Text.Equals(""))
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

        private void btnMostrartodos_Click(object sender, EventArgs e)
        {
            limpiarTXT();

            CargaDtgv();

        }


        private void CargaDtgv ()
        {
            dtgvUser.Rows.Clear();

            reservadorDataSetTableAdapters.USUARIOSTableAdapter taUsuarios = new reservadorDataSetTableAdapters.USUARIOSTableAdapter();
            taUsuarios.Fill(dsbd.USUARIOS, 0);

            for (int i = 0; i < dsbd.USUARIOS.Count; i++)
            {
                dtgvUser.Rows.Add("");
                dtgvUser.Rows[i].Cells[0].Value = dsbd.USUARIOS[i].Login;
                dtgvUser.Rows[i].Cells[1].Value = dsbd.USUARIOS[i].Password;
                dtgvUser.Rows[i].Cells[2].Value = dsbd.USUARIOS[i].Email;


                reservadorDataSetTableAdapters.PERFILESTableAdapter taPerfiles = new reservadorDataSetTableAdapters.PERFILESTableAdapter();
                

                dtgvUser.Rows[i].Cells[3].Value = taPerfiles.SQLnombrePerfil(dsbd.USUARIOS[i].Perfil);
            }

        }
    }
}
