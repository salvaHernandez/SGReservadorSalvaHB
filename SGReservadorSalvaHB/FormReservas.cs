using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGReservadorSalvaHB
{
    public partial class FormReservas : Form
    {

        public FormReservas()
        {
            InitializeComponent();
        }


        private void FormReservas_Load(object sender, EventArgs e)
        {
            cargarCbxAulas();
        }

        private void cargarCbxAulas()
        {
            aULASTableAdapter.Fill(reservadorDataSet.AULAS);
            for (int i = 0; i < reservadorDataSet.AULAS.Count; i++)
            {
                cbxAulas.Items.Add(reservadorDataSet.AULAS[i].Descripcion);
            }
        }
        
        /*
         * revisar esto
         **/

        private void cbxAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("id-> " + cbxAulas.SelectedIndex + ", nombre->" + cbxAulas.Text);
            aULASTableAdapter.Fill(reservadorDataSet.AULAS);

        }

    }
}
