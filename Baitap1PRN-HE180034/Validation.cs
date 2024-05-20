using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1PRN_HE180034
{
    //khoi tao lop de xac thuc du lieu dau vao
    class Validation
    {
        public Validation() { }
        //xac thuc cach nhap 1 chuoi trong chuong trinh
        public string getString()
        {
            while (true)
            {
                try
                {
                    string s = Console.ReadLine();
                    //neu la khoang trang hoac rong se in ra noti
                    if (!string.IsNullOrWhiteSpace(s))
                    {
                        return s;
                    }
                    else
                    {
                        Console.WriteLine("Nothing to display!!!");
                    }
                }
                //bat loi vao exception
                catch (Exception e)
                {
                    Console.WriteLine("Error!!!");
                }

            }

        }
        //xac thuc cach nhap 1 so nguyen trong chuong trinh
        public int getInt(int min, int max)
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    // check input is null or whitespace
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty or whitespace only. Please enter a valid number.");
                        continue;
                    }
                    // convert to int
                    int s;
                    if (int.TryParse(input, out s))
                    {
                        // test input in a range of min or max
                        if (s >= min && s <= max)
                        {
                            return s;
                        }
                        else
                        {
                            Console.WriteLine($"Please enter a number between {min} and {max}.");
                        }
                    }
                    else
                    {
                        // if input is not a number
                        Console.WriteLine("Input is not a valid number. Please enter a valid number.");
                    }
                }
                catch (Exception e)
                {
                    // noti
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            }
        }
    }
}
