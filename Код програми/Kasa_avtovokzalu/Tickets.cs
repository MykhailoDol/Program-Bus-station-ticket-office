using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_avtovokzalu
{
    public class Tickets
    {
        public string Login;
        public  string Name;
        public string Surname;
        public string Num;
        public string SearchCity;
        public string Phone;
        public string NumPlace;
        public Tickets Next;

        public Tickets(string count)
        {
            string[] a = count.Split('_');
            Login = a[0];
            Name = a[1];
            Surname = a[2];
            Num = a[3];
            SearchCity = a[4];
            Phone = a[5];
            NumPlace = a[6];
            Next = null;
        }

        public string String()
        {
            return string.Join("_", Login, Name, Surname, Num, SearchCity, Phone, NumPlace);
        }
    }
    public class TicketList
    {
        public Tickets head;
        private static int count;
        public TicketList()
        {
            head = null;
        }
        public void Add(string value)
        {
            if (head == null)
            {
                head = new Tickets(value);
                count++;
            }
            else
            {
                Tickets node = head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new Tickets(value);
                count++;
            }
        }

        public void Delete(string[] value)
        {
            if (head.Num == value[0] && head.NumPlace == value[1])
                head = head.Next;
            else
            {
                for(Tickets node = head; node.Next != null; node = node.Next)
                {
                    if (node.Next.Num == value[0] && node.Next.NumPlace == value[1])
                    {
                        node.Next = node.Next.Next;
                        return;
                    }
                }
            }
        }

        public void Delete(string value)
        {
            if (head.Num == value)
                head = head.Next;
            else
            {
                for (Tickets node = head; node.Next != null; node = node.Next)
                {
                    if (node.Next.Num == value)
                        node.Next = node.Next.Next;
                    if (node.Next == null)
                        return;
                }
            }
        }
    }
}
