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
                                    orderby aul.Descripcion
                                    select aul.Cod_aula;

                MessageBox.Show(aulasBorradas.Count().ToString());
                if (aulasBorradas.Count() > 0)
                {
                    var reservasPorGrupo = from r in objBD.RESERVAS
                                   where aulasBorradas.Contains(r.Aula)
                                   group r by r.Aula into grupo
                                   select new
                                   {
                                       numReservas = grupo.Count(),
                                       aula = grupo.Key
                                   };

                    var consultaMinNumReserva = reservasPorGrupo.Where(x => x.numReservas == reservasPorGrupo.Min(y => y.numReservas));

                    var consultaFinal = from a in objBD.AULAS
                                        from c in consultaMinNumReserva
                                        where a.Cod_aula == c.aula
                                        orderby a.Descripcion
                                        select new
                                        {
                                            a.Cod_aula,
                                            a.Descripcion,
                                            c.numReservas
                                        };

                    dataGridView1.DataSource = consultaFinal.ToList();

                }
            }
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
            {
                var usuariosNoBorrados = from us in objBD.USUARIOS
                                         where us.Borrado == 0
                                         select 
                                       
                                             us.Login
                                         ;

                var reservasAgrupadas = from res in objBD.RESERVAS
                                       where usuariosNoBorrados.Contains(res.Usuario)
                                       group res by res.Usuario into grupo
                                       select new
                                       {
                                           numReservasAgrupadas = grupo.Count(),
                                           user = grupo.Key
                                       };

                
                if (reservasAgrupadas.Count() > 0)
                {

                    var consultaMaxNumReserva = reservasAgrupadas.Where(x => x.numReservasAgrupadas == reservasAgrupadas.Max(y => y.numReservasAgrupadas));


                    var consultaFinal = from us in objBD.USUARIOS
                                        from c in consultaMaxNumReserva
                                        where us.Login == c.user  
                                        select new
                                        {
                                            c.user,
                                            us.Password,
                                            c.numReservasAgrupadas
                                        };
                    dataGridView1.DataSource = consultaFinal.ToList();
                }
            }
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
            {
                var reservaGrupos = from res in objBD.RESERVAS
                                    group res by res.Usuario into grupo
                                    select new
                                    {
                                        numReservasAgrupadas = grupo.Count(),
                                        user = grupo.Key
                                    };
                if (reservaGrupos.Count() > 0)
                {
                    // Si hacemos la media por todos los usuarios, independientemente que hayan reservado o no
                    var conNumUser = from us in objBD.USUARIOS
                                      select us.Login;
                    var totalReservas = reservaGrupos.Sum(y => y.numReservasAgrupadas);
                    var numeroUsuarios = conNumUser.Count();
                    var mediaReal = totalReservas / numeroUsuarios; // Resultado 2, hay 8 reservas en total y 4 usuarios

                    // Si Hacemos la media contando los que han hecho reservas
                    // Resultado 4, hay 8 reservas en total y todas las han hecho 2 usuarios por lo tanto la media es 4
                    var mediaReserva = reservaGrupos.Average(y => y.numReservasAgrupadas); 


                    // Cambiar mediaReal con mediaReserva
                    var consultaConMedia = reservaGrupos.Where(x => x.numReservasAgrupadas >= mediaReal);

                    var consultaFinal = from c in consultaConMedia
                                        select new
                                        {
                                            c.user,
                                            c.numReservasAgrupadas
                                        };
                    dataGridView1.DataSource = consultaFinal.ToList();
                }
            }
        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            using (reservadorEntitiesLQ objBD = new reservadorEntitiesLQ())
            {
                var reservas = from r in objBD.RESERVAS
                               orderby r.Fecha
                                  select r.Fecha;
                DateTime fecha = reservas.First();


                var resMasAntigua = from re in objBD.RESERVAS
                                    where re.Fecha.CompareTo(fecha) < 1
                                    select new
                                    {
                                        re.Usuario,
                                        re.Aula,
                                        re.Fecha
                                    };

                if (resMasAntigua.Count() > 0)
                {
                    var consultaFinal = from a in objBD.AULAS
                                        from r in resMasAntigua
                                        where r.Aula == a.Cod_aula
                                        select new
                                        {
                                            r.Usuario,
                                            a.Descripcion,
                                            r.Fecha
                                        };

                    dataGridView1.DataSource = consultaFinal.ToList();
                }

            }
        }
    }
}