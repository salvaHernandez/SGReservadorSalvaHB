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
        reservadorDataSet dsbd = new reservadorDataSet();
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
                CBX.Items.Add(reservadorDataSet.AULAS[i].Descripcion);
            }
        }
        
        /*
         * revisar esto
         **/


        private void CBX_SelectedIndexChanged(object sender, EventArgs e)
        {

            aULASTableAdapter.FillByCodAula(reservadorDataSet.AULAS,""+ aULASTableAdapter.Cositas("" + CBX.Text));
        }
    }
}
