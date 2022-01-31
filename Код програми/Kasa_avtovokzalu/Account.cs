using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_avtovokzalu
{
    class Account
    {
        public string Name;
        public string Surname;
        public string Login;

        public Account(string count)
        {
            string[] a = count.Split(' ');
            Name = a[0];
            Surname = a[1];
            Login = a[2];
        }
    }
}

