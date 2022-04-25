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
    public partial class FormAdmAulas : Form
    {
        public FormAdmAulas()
        {
            InitializeComponent();
            
        }

        private void aULASBindingNavigatorSaveItem_Click(object sender, EventArgs e)

        {
            if (cod_aulaTextBox.Text == "")
            {
                MessageBox.Show("EL CAMPO CODIGO DE AULA NO PUEDE ESTAR VACIO", "ERROR");
            }
            else
            {
                if (descripcionTextBox.Text == "")
                {
                    MessageBox.Show("EL CAMPO DESCRIPCION DEL AULA NO PUEDE ESTAR VACIO", "ERROR");
                }
                else
                {
                    DialogResult resp = MessageBox.Show("¿Desea guardar los cambios?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (resp == DialogResult.Yes)
                    {
                        this.Validate();
                        this.aULASBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.reservadorDataSet);
                    }

                    bindingNavigatorAddNewItem.Enabled = true;
                }
                
            }
            
        }

        private void FormAdmAulas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reservadorDataSet.AULAS' Puede moverla o quitarla según sea necesario.
            this.aULASTableAdapter.Fill(this.reservadorDataSet.AULAS);
            borradoTextBox.Visible = false;

        }

        private void anadirFoto()
        {
            string miCarpetaOrigen = System.IO.Path.Combine(Application.StartupPath, "fotos\\");
            openFileDialog1.InitialDirectory = miCarpetaOrigen;

            openFileDialog1.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";

            DialogResult dres = openFileDialog1.ShowDialog();

            if (dres == DialogResult.Abort)
                return;
            if (dres == DialogResult.Cancel)
                return;

            //Se muestra la imagen en el PictureBox directamente de la ruta devuelta por el OpenFileDialog
            fotoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            anadirFoto();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Esta seguro de querer eliminar este Aula?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (resp == DialogResult.Yes)
            {
   
                    aULASTableAdapter.BorradoLogicoAulas(cod_aulaTextBox.Text);
                    MessageBox.Show("Aula eliminada correctamente", "BORRADA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    reservadorDataSet.AULAS.Clear();
                    aULASTableAdapter.Fill(reservadorDataSet.AULAS);

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            borradoTextBox.Text = "0";
        }
    }
}
