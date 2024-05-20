using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1PRN_HE180034
{
    //lop dai dien cho fulltimeemployee
    public class FullTimeEmployee : Employee
    {
        //khoi tao doi tuong
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }
        //phuong thuc ghi de de tinh toan luong cho fulltimeemployee
        public override int calculateSalary()
        {
            return PaymentPerHour*8;
        }
        public override string getName()
        {
            return Name;
        }
        //ghi de thong tin cua lop cha de hien thi thong tin fulltimeemployee
        public override string ToString()
        {
            return base.ToString()+$", Salary: {calculateSalary()}";
        }

    }
}
