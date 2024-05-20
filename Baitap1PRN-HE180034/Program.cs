namespace Baitap1PRN_HE180034
{
    internal class Program
    {
        //kiem tra xem input co trung voi ten cua nhan vien hay ko
        public static bool IsEmployeeName(Employee employee,string name)
        {
            return employee.getName().Contains(name);
        }
        //tinh toan luong cho nhan vien dua vao phuong thuc tinh luong cua nguoi do
        public static int CalculateSalary(Employee employee)
        {
            return employee.calculateSalary();
        }
        static void Main(string[] args)
        {
            //khai bao mang dong employee va lop validation
            List<Employee> employees = new List<Employee>();
            Validation validation= new Validation();
            //menu de cho nguoi dung input va xu ly du lieu
            while (true)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1. Add new PartTime employee:  ");
                Console.WriteLine("2. Add new FullTime employee:  ");
                Console.WriteLine("3. Find employee with highest salary: ");
                Console.WriteLine("4. Find employee by name: ");
                Console.WriteLine("5. View all employees: ");
                Console.WriteLine("6. Exit");
                int choice = validation.getInt(1,7);
                switch(choice)
                {
                    //them parttime-employee vao trong mang dong
                    case 1:
                        Console.WriteLine("Enter name of employee: ");
                        String pe = validation.getString();
                        Console.WriteLine("Enter payment per hour: ");
                        int a=validation.getInt(int.MinValue,int.MaxValue);
                        Console.WriteLine("Enter working hour: ");
                        int b = validation.getInt(int.MinValue, int.MaxValue);
                        employees.Add(new PartTimeEmployee(pe,a,b));
                        break;
                    //them fulltime-employee vao trong mang dong
                    case 2:
                        Console.WriteLine("Enter name of employee: ");
                        String pee = validation.getString();
                        Console.WriteLine("Enter payment per hour: ");
                        int c = validation.getInt(int.MinValue, int.MaxValue);
                        employees.Add(new FullTimeEmployee(pee,c));
                        break;
                    // tim ra nhan vien co luong cao nhat
                    case 3:
                        //dung orderbydescending de tim nguoi co luong cao nhat
                        var highestSalary=employees.OrderByDescending(CalculateSalary).FirstOrDefault();
                        if (highestSalary != null)
                        {
                            Console.WriteLine("Employee who has highest salary: ");
                            Console.WriteLine(highestSalary);
                        }
                        else
                        {
                            Console.WriteLine("Not found!!!");
                        }
                        break;
                    //tim nhan vien theo ten
                    case 4:
                        Console.WriteLine("Enter name of employee: ");
                        string name=validation.getString();
                        Employee efound = null;
                        foreach(var employee in employees)
                        {
                            //khi thay trung voi ten nhan vien, add nhan vien do vao bien efound
                            if(IsEmployeeName(employee,name))
                            {
                                efound= employee;
                            }
                        }
                            if(efound != null)
                            {
                                Console.WriteLine("Employee: ");
                            Console.WriteLine(efound);
                            }else
                            {
                                Console.WriteLine("Not found!!! ");

                            }
                            break;
                    //in ra danh sach nhan vien
                    case 5:
                        Console.WriteLine("Result: ");
                        foreach(var employee in employees)
                        {
                            Console.WriteLine(employee);
                        }
                        break;
                    //thoat khoi chuong trinh
                    case 6:
                        return;
                }
            }
        }
    }
}
