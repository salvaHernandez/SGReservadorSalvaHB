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
            using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
            {
                var aulas = from aul in objBD.AULAS
                                where aul.Borrado == 0
                                select  aul.Cod_aula;

                var maxReservas = from res in objBD.RESERVAS
                                  where aulas.Contains(res.Aula)
                                  group res by new { res.Aula, res.Fecha} into grupo
                                  select new
                                  {
                                      reservasPorDia = grupo.Count(),
                                      infoGrupo = grupo.Key
                                  };

                var maxValue = maxReservas.Max(x => x.reservasPorDia);


                var consulta = maxReservas.Where(x => x.reservasPorDia == maxValue);


                var consultaFinal = from c in consulta
                                    from aula in objBD.AULAS
                                    where c.infoGrupo.Aula == aula.Cod_aula
                                    select new
                                    {
                                        aula.Descripcion,
                                        c.infoGrupo.Fecha,
                                        c.reservasPorDia
                                    };
                dataGridView1.DataSource = consultaFinal.ToList();

            }
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
            {
                var aulasBorradas = from aul in objBD.AULAS
                                    where aul.Borrado == -1
                                    select aul.Cod_aula;

                var menosReservas = from res in objBD.RESERVAS
                                    where aulasBorradas.Contains(res.Aula)
                                    group res by res.Aula into grupo
                                    select new
                                    {
                                        reservasPorDia = grupo.Count(),
                                        idAula = grupo.Key
                                    };
                if (menosReservas.Count() > 0)
                {
                    var numReservas = menosReservas.Min(x => x.reservasPorDia);

                    var consulta = menosReservas.Where(x => x.reservasPorDia <= numReservas);

                    var consultaFinal = from c in consulta
                                        from aula in objBD.AULAS
                                        where c.idAula == aula.Cod_aula
                                        select new
                                        {
                                            aula.Descripcion,
                                            c.idAula,
                                            c.reservasPorDia,
                                        };
                    dataGridView1.DataSource = consultaFinal.ToList();

                } else
                {
                    dataGridView1.DataSource = aulasBorradas.ToList();
                }
            }
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
