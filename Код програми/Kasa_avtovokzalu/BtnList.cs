using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasa_avtovokzalu
{
    public class BtnListNode
    {
        public double num;
        public double num1;
        public BtnListNode Next;

        
        public BtnListNode(double value)
        {
            num = value;
            Next = null;
        }

    }
    public class BtnList
    {
        public BtnListNode head;
        private int count;
        public BtnList()
        {
            head = null;
        }
        public void Add(double value)
        {
            if (head == null)
            {
                head = new BtnListNode(value);
                count++;
            }
            else
            {
                BtnListNode node = head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                node.Next = new BtnListNode(value);
                count++;
            }
        }
        public double this[int index]
        {
            get
            {
                BtnListNode p = head;
                for (int i = 0; i < count; i++)
                {
                    if (i == index)
                        return p.num;
                    p = p.Next;
                }
                return -1;
            }
        }
    }
}
