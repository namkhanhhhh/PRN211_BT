using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2PRN_HE180034
{
    //khoi tao lop dai dien cho employee, ke thua tu person

    public class Employee:Person
    {
        private int salary;
        //khoi tao doi tuong
        public Employee(string name, string address, int salary) : base(name, address)
        {
            this.salary = salary;
        }

        public int Salary { get => salary; set => salary = value; }
        //phuong thuc ghi de display de hien thi thong tin employee
        public override void display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address},Balance: {salary}");
        }
    }
}
