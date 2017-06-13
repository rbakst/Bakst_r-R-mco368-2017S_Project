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
        private static DataClasses1DataContext context;

        public static UserAccount CurrUser { get; set; }

        private static readonly decimal _MAXBALANCE = 100.00M;
        public static decimal MAXBALANCE { get { return _MAXBALANCE; } }

        public static DataClasses1DataContext Context
        {
            get
            {
                return context == null ? new DataClasses1DataContext() : context;
                
            }
        }
    }
}
