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
    public partial class FormInformes : Form
    {
        public FormInformes()
        {
            InitializeComponent();
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hola");
            using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
            {
                AULAS objAula = objBD.AULAS.Create();
                var consulta1 = from aul in objBD.AULAS
                                where aul.Borrado == 0
                                select new { aul.Descripcion };


            }
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {

        }
    }
}
