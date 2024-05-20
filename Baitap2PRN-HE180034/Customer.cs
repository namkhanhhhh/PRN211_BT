using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2PRN_HE180034
{
    //khoi tao lop dai dien cho customer, ke thua tu person
    public class Customer:Person
    {
        private int balance;
        //khoi tao doi tuong
        public Customer(string name, string address,int balance) : base(name, address)
        {
            this.balance = balance;
        }

        public int Balance { get => balance; set => balance = value; }

        //phuong thuc ghi de display de hien thi thong tin customer
        public override void display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Balance: {balance}");
        }
    }
}
