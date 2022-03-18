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
            this.Validate();
            this.aULASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.reservadorDataSet);

        }

        private void FormAdmAulas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reservadorDataSet.AULAS' Puede moverla o quitarla según sea necesario.
            this.aULASTableAdapter.Fill(this.reservadorDataSet.AULAS);

        }
    }
}
