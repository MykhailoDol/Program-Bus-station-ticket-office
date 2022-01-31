using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_avtovokzalu
{
    public class Ticket
    {
        public static string Login;
        public static string Name;
        public static string Surname;
        public static string Num;
        public static string SearchCity;
        public static string Phone;
        public static string NumPlace;

        public static void Add()
        {
            MainForm.Tickets.Add(string.Join("_", Login, Name, Surname, Num, SearchCity, Phone, NumPlace));
        }
    }
}
