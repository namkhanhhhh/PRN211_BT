using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2PRN_HE180034
{
    //lop truu tuong person
    public abstract class Person
    {
        private string name;
        private string address;
        //khoi tao doi tuong
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        //phuong thuc truu truong display de phuc vu cho customer va employee
        public abstract void display();
    }
}
