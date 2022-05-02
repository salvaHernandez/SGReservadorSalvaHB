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
            using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
            {
                var perfi = from perf in objBD.PERFILES
                               select new
                               {
                                   perf.Descripcion,
                                   perf.Id_Perfil
                               };

                var totalPerf = perfi.ToList();
                perfiles = new string[totalPerf.Count];
                idPerfiles = new int[totalPerf.Count];

                for (int i = 0; i < totalPerf.Count; i++)
                {
                    cmbPerfil.Items.Add(totalPerf[i].Descripcion);
                    perfiles[i] = totalPerf[i].Descripcion;
                    idPerfiles[i] = totalPerf[i].Id_Perfil;
                }
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
                    using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
                    {
                        USUARIOS user = objBD.USUARIOS.Find(dtgvUser.SelectedRows[0].Cells[0].Value.ToString());
                        user.Borrado = -1;
                        objBD.SaveChanges();
                    }
                    MessageBox.Show("Usuario " + dtgvUser.SelectedRows[0].Cells[0].Value.ToString() + " Borrado");
                    CargaDtgv();
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
                    using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
                    {
                        USUARIOS user = objBD.USUARIOS.Find(dtgvUser.SelectedRows[0].Cells[0].Value.ToString());
                        user.Password = txtPassword.Text;
                        user.Email = txtEmail.Text;
                        int perfil = idPerfiles[cmbPerfil.SelectedIndex];
                        user.Perfil = perfil;
                        objBD.SaveChanges();
                    }
                    CargaDtgv();
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
                using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
                {
                    USUARIOS usuario = objBD.USUARIOS.Create();

                    var userExiste = from us in objBD.USUARIOS
                                     where us.Login == txtLogin.Text
                                     select us.Login;

                    if (userExiste.Count() > 0)
                    {
                        MessageBox.Show("El usuario "+ txtLogin.Text +" ya existe");
                    } else
                    {
                        usuario.Login = txtLogin.Text;
                        usuario.Password = txtPassword.Text;
                        MessageBox.Show(idPerfiles[cmbPerfil.SelectedIndex].ToString()+" "+ txtPassword.Text);
                        usuario.Perfil = idPerfiles[cmbPerfil.SelectedIndex];
                        usuario.Email = txtEmail.Text;
                        usuario.Borrado = 0;

                        objBD.USUARIOS.Add(usuario);
                        objBD.SaveChanges();
                        MessageBox.Show("Usuario registrado correctamente");
                        CargaDtgv();
                    }
                }
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

            using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
            {
                var usuariosNoBorrados = from us in objBD.USUARIOS
                                         from rol in objBD.PERFILES
                                         where us.Borrado == 0 && us.Perfil == rol.Id_Perfil
                                         select new
                                         {
                                             us.Login,
                                             us.Password,
                                             us.Email,
                                             rol.Descripcion
                                         };
            dtgvUser.DataSource = usuariosNoBorrados.ToList();
            }
        }
    }
}
