using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_avtovokzalu
{
    public class Way
    {
        public string Count;
        public string Num;
        public string Time;
        public string[] Ways;
        public Way Next;

        public Way(string count)
        {
            List<string> str = new List<string>();
            string[] a = count.Split('_');
            Count = a[0];
            Num = a[1];
            Time = a[2];
            for(int i = 3; i < a.Length; i++)
            {
                str.Add(a[i]);
            }
            Ways = str.ToArray();
            Next = null;
        }

        public string String()
        {
            return string.Join("_", Count, Num, Time, string.Join("_", Ways));
        }
    }
    public class WayList
    {
        public Way head;
        private static int count;
        public WayList()
        {
            head = null;
        }
        public void Add(string value)
        {
            if (head == null)
            {
                head = new Way(value);
                count++;
            }
            else
            {
                Way node = head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new Way(value);
                count++;
            }
        }

        public bool Check(string value)
        {
            for(Way node = head; node != null; node = node.Next)
            {
                if(node.Num == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void Sort(Way value)
        {
            int countValue = int.Parse(String.Join("", value.Time.Split(':')));
            if (head == null)
                head = value;
            for (Way node = head; node != null; node = node.Next)
            {
                int count = int.Parse(String.Join("", node.Time.Split(':')));
                if (countValue < count)
                {
                    value.Next = node;
                    head = value;
                    return;
                }
                else if (node.Next == null)
                {
                    node.Next = value;
                    return;
                }
                else if (countValue >= count && countValue <= int.Parse(String.Join("", node.Next.Time.Split(':'))))
                {
                    value.Next = node.Next;
                    node.Next = value;
                    return;
                }
            }
        }

        public void Delete(string value)
        {
            if (head.Num == value)
                head = head.Next;
            else
            {
                for (Way node = head; node.Next != null; node = node.Next)
                {
                    if (node.Next.Num == value)
                        node.Next = node.Next.Next;
                }
            }
        }
    }
}
