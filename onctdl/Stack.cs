using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Stack
    {

        private Node first;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }


        }


        public Stack()
        {
            this.count = 0;
        }




        public void Push(Person value)
        {
            Node node = new Node(value);
            if (this.Count == 0)
            {
                this.first = node;
            }
            else
            {
                node.Next = this.first;
                this.first = node;
            }
            this.count++;
        }


        public Person Peek()
        {
            return this.first.Value;
        }


        public Person Pop()
        {
            Person value = this.first.Value;
            this.first = this.first.Next;
            this.count--;
            return value;
        }


        public void Clear()
        {
            this.first = null;
            this.count = 0;
        }


        public Person Find(string name)
        {
            Person ps = null;

            for (Node i = this.first; i != null; i = i.Next)
            {
                if (i.Value.Name.Equals(name))
                {
                    ps = i.Value;
                    break;
                }
            }

            return ps;
        }


        public Person FindLast(string name)
        {
            Person ps = null;

            for (Node i = this.first; i != null; i = i.Next)
            {
                if (i.Value.Name.Equals(name))
                {
                    ps = i.Value;
                }
            }

            return ps;
        }


        public void BubbleSort()
        {
            for (Node i = this.first; i != null; i = i.Next)
            {
                for (Node j = this.first; j.Next != null; j = j.Next)
                {
                    if (j.Value.GetAge() < j.Next.Value.GetAge())
                    {
                        Swap(ref j, ref i);
                    }
                }
            }
        }


        public void InterchangeSort()
        {
            for (Node i = this.first; i.Next != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    if (j.Value.GetAge() > i.Value.GetAge())
                    {
                        Swap(ref j, ref i);
                    }
                }
            }
        }


        private void Swap(ref Node node1, ref Node node2)
        {
            Person value = node1.Value;
            node1.Value = node2.Value;
            node2.Value = value;
        }

        public void Show()
        {
            for (Node i = this.first; i != null; i = i.Next)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine($"count: {this.Count}");
        }
        public Queue Finds(string name)
        {
            Queue queue = new Queue();
            for (Node i = this.first; i != null; i = i.Next)
            {
                if (i.Value.Name.Equals(name))
                {
                    queue.EnQueue(i.Value);
                }
            }
            return queue;
        }
    }
}
