using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUISupermarket
{
    public static class Global
    {
        private static UserAccount currUser;

        public static UserAccount CurrUser { get; set; }

        private static readonly double _MAXBALANCE = 100.00;
        public static double MAXBALANCE { get; }
    }
}
