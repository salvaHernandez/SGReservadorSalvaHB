using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGReservadorSalvaHB
{
    class GlobalVaribleClass
    {
        private static string _userName = "";

        public static string userName
        {
            get { return _userName; }
            set { _userName = value; }

        }
    }
}
