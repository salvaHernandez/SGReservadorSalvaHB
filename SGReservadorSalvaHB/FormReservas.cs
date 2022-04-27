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
            // TODO: esta línea de código carga datos en la tabla 'reservadorDataSet.RESERVAS' Puede moverla o quitarla según sea necesario.
            this.rESERVASTableAdapter.Fill(this.reservadorDataSet.RESERVAS);
            cargarCbxAulas();
            btnMostrar.Enabled = false;
            pboxImagen.Visible = false;
            dtpkFecha.Enabled = false;
            btnReservar.Enabled = false;
            //dtpkFecha.MinDate = DateTime.Today;

        }

        private void cargarCbxAulas()
        {
            aULASTableAdapter.FillByAlf(reservadorDataSet.AULAS);
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
            btnMostrar.Enabled = true;
            pboxImagen.Visible = true;
            dtpkFecha.Enabled = true;
            aULASTableAdapter.FillByCodAula(reservadorDataSet.AULAS,""+ aULASTableAdapter.Cositas("" + CBX.Text));

            //CargarDataGridView(aULASTableAdapter.Cositas("" + CBX.Text), CBX.Text);
        }

        
        private void CargarDataGridView(string cod_aula, string nom_aula)
        {

            dtgvHorario.Rows.Clear();
            reservadorDataSetTableAdapters.RESERVASTableAdapter taReservas = new reservadorDataSetTableAdapters.RESERVASTableAdapter();
            taReservas.FillByReservas(dsbd.RESERVAS, cod_aula, dtpkFecha.Text);
            String nombreReserva = "";

            for (int i = 0; i < 6; i++) {

                dtgvHorario.Rows.Add("");
                dtgvHorario.Rows[i].Cells[0].Value = nom_aula;
                dtgvHorario.Rows[i].Cells[2].Value = i+1;
                nombreReserva = taReservas.SQLcomp_reserva(dtpkFecha.Text, (i + 1), cod_aula);

                if (nombreReserva != null)
                {
                    dtgvHorario.Rows[i].Cells[1].Value = nombreReserva;
                    dtgvHorario.Rows[i].Cells[3].Value = "No";
                }
                else
                {
                    dtgvHorario.Rows[i].Cells[3].Value = "Si";
                }


            }

        }

        private void dtpkFecha_ValueChanged(object sender, EventArgs e)
        {
            //CargarDataGridView(aULASTableAdapter.Cositas("" + CBX.Text), CBX.Text);
        }

        private void dtgvHorario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarDataGridView(aULASTableAdapter.Cositas("" + CBX.Text), CBX.Text);
            btnReservar.Enabled = true;
        }
    }

}
