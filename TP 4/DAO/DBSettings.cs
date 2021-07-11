using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class DBSettings
    {
        public static readonly string CONNECTION_STR;

        static DBSettings()
        {
            CONNECTION_STR = "Data Source=.;Initial Catalog=TP4_Henestroza_Alejandro;Integrated Security=True";
        }
    }
}
