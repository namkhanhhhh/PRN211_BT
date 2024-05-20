using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1PRN_HE180034
{
    //lop dai dien cho parttimeemployee

    public class PartTimeEmployee : Employee
    {
        private int workingHours;
        //khoi tao doi tuong
        public PartTimeEmployee(string name, int paymentPerHour,int workingHours) : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }
        //phuong thuc ghi de de tinh toan luong cho parttimeemployee
        public override int calculateSalary()
        {
            return workingHours*PaymentPerHour;
        }

        public override string getName()
        {
            return Name;
        }
        //ghi de thong tin cua lop cha de hien thi thong tin parttimeemployee
        public override string ToString()
        {
            return base.ToString() +$", Working hours: {workingHours}, Salary: {calculateSalary()}";
        }
    }
}
