using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace BasicSupermarketClasses
{
    [Table(Name = "UserAccount")]
    public class UserAccount
    {
    
        [Column(IsPrimaryKey=true, Storage="username")]
        public string Username{ get; private set; }

       [Column(Storage ="pswd")]
        public string Pswd { get; set; }

        [Column(Storage ="balance")]
        public double balance { get; set; }


        //public UserAccount(string uname, string pswd)
        //{
        //    Username = uname;
        //    Pswd = pswd;
        //    balance = 0;
        //}


    }
}
