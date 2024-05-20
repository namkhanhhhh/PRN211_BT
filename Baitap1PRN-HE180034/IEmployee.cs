using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1PRN_HE180034
{
    //giao dien dinh nghia phuong thuc chung cho nhan vien
    public interface IEmployee
    {
        //tinh toan luong
        int calculateSalary();
        //tra ve ten cua nhan vien
        String getName();
    }
}
