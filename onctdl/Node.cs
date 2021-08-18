using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Node
    {
        private Person value;
        private Node next;


        internal Node Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        internal Person Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Node(Person value)
        {
            this.Value = value;
        }

    }
}
