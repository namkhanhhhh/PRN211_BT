using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1PRN_HE180034
{
    //lop truu tuong, trien khai giao dien iemployee
    public abstract class Employee : IEmployee
    {
        //khai bao thuoc tinh
        private string name;
        private int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.PaymentPerHour = paymentPerHour;
        }
        //getter setter
        public string Name { get => this.name; set => this.name = value; }
        public int PaymentPerHour { get => paymentPerHour; set => paymentPerHour = value; }
        //phuong thuc truu tuong calculatesalary va getname
        public abstract int calculateSalary();
        public abstract string getName();
        //ghi de phuong thuc tostring de hien thi
        public override string ToString()
        {
            return $"Name: {name}, Payment per hour: {paymentPerHour}";
        }
    }
}
