using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_avtovokzalu
{
    public class Costs
    {
        public string City;
        public string Cost;
        public Costs Next;

        public Costs(string count)
        {
            List<string> str = new List<string>();
            string[] a = count.Split('_');
            City = a[0];
            Cost = a[1];
            Next = null;
        }

        public string String()
        {
            return string.Join("_", City, Cost);
        }
    }
    public class CostList
    {
        public Costs head = null;
        private int count;
        public CostList()
        {
            head = null;
        }
        public void Add(string value)
        {
            if (head == null)
            {
                head = new Costs(value);
                count++;
            }
            else
            {
                Costs node = head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new Costs(value);
                count++;
            }
        }
        public int this[string city]
        {
            get
            {
                Costs node = head;
                for (int i = 0; node != null; node = node.Next)
                {
                    if (node.City == city)
                        return i;
                }
                return -1;
            }
        }
    }
}
