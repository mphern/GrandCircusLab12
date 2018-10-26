using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Person : object
    {


        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public string Name { get; private set; }
        public string Address { get; private set; }

        public override string ToString()
        {
            return string.Format("{0,-10}","Name: ")+Name+"\n"+string.Format("{0,-10}","Address: ")+Address;
        }

        public void EditName(string name)   { Name = name; }

        public void EditAddress(string address)    { Address = address; }

    }
}
