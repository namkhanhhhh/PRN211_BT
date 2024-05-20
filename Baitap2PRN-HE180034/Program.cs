namespace Baitap2PRN_HE180034
{

    public class Program
    {
        //kiem tra xem input co trung voi ten cua nhan vien hay ko
        public static bool IsEmployeeName(Employee employee, string name)
        {
            return employee.Name.Contains(name);
        }
        static void Main(string[] args)
        {
            //khai bao mang dong employee, customer va lop validation
            List<Employee> employees = new List<Employee>();
            List<Customer> customers = new List<Customer>();
            Validation validation = new Validation();
            //menu de cho nguoi dung input va xu ly du lieu
            while (true)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1. Add new Employee: ");
                Console.WriteLine("2. Add new Customer: ");
                Console.WriteLine("3. View all employees: ");
                Console.WriteLine("4. View all customers: ");
                Console.WriteLine("5. Find employee who has highest salary: ");
                Console.WriteLine("6. Find customer who has lowest balance: ");
                Console.WriteLine("7. Find employee by name: ");
                Console.WriteLine("8. Exit");
                int choice = validation.getInt(1, 8);
                switch (choice)
                {
                    //them nguoi dung vao trong mang dong
                    case 1:
                        Console.WriteLine("Enter name of employee: ");
                        String pe = validation.getString();
                        Console.WriteLine("Enter address: ");
                        string a = validation.getString();
                        Console.WriteLine("Enter salary: ");
                        int b = validation.getInt(int.MinValue, int.MaxValue);
                        employees.Add(new Employee(pe, a, b));
                        break;
                    //them customer vao trong mang dong
                    case 2:
                        Console.WriteLine("Enter name Customer: ");
                        String pee = validation.getString();
                        Console.WriteLine("Enter address: ");
                        String c = validation.getString();
                        Console.WriteLine("Enter balance: ");
                        int d= validation.getInt(int.MinValue,int.MaxValue);
                        customers.Add(new Customer(pee, c,d));
                        break;
                    //xem toan bo employee trong mang dong
                    case 3:
                        Console.WriteLine("List of employees: ");
                        foreach (var employee in employees)
                        {
                            employee.display();
                        }
                        break;
                    //xem toan bo customer trong mang dong
                    case 4:
                        Console.WriteLine("List of customers: ");
                        foreach (var customer in customers)
                        {
                            customer.display();
                        }
                        break;
                    // tim ra nhan vien co luong cao nhat
                    case 5:
                        //dung orderbydescending de tim nguoi co luong cao nhat
                        var highestSalary = employees.OrderByDescending(e => e.Salary).FirstOrDefault();
                        if (highestSalary != null)
                        {
                            Console.WriteLine("Employee who has highest salary: ");
                            highestSalary.display();
                        }
                        else
                        {
                            Console.WriteLine("Not found!!!");
                        }
                        break;
                    // tim ra khach hang co so du thap nhat
                    case 6:
                        //dung orderby de tim nguoi co so du thap nhat
                        var lowestBalance = customers.OrderBy(c=>c.Balance).FirstOrDefault();
                        if (lowestBalance != null)
                        {
                            Console.WriteLine("Customer who has lowest balance: ");
                            lowestBalance.display();
                        }
                        else
                        {
                            Console.WriteLine("Not found!!!");
                        }
                        break;
                        //tim nhan vien theo ten
                        case 7:
                        Console.WriteLine("Enter name of employee: ");
                        string name = validation.getString();
                        Employee efound = null;
                        //khi thay trung voi ten nhan vien, add nhan vien do vao bien efound
                        foreach (var employee in employees)
                        {
                            if (IsEmployeeName(employee, name))
                            {
                                efound = employee;
                            }
                        }
                        if (efound != null)
                        {
                            Console.WriteLine("Employee: ");
                            efound.display();
                        }
                        else
                        {
                            Console.WriteLine("Not found!!! ");
                        }
                        break;
                    //exit khoi chuong trinh
                    case 8:
                        return;
                }
                }
        }
    }
}