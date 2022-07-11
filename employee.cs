using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrshovayaa
{
    public class employee : @abstract
    {
       // public string LastName;     //ФИО
        public string post;
        public string passport;

        public employee(string LastName, string post,string passsport) : base(LastName)
        {
            this.LastName = LastName;
            this.post = post;
            this.passport = passsport;
        }

    }

}

