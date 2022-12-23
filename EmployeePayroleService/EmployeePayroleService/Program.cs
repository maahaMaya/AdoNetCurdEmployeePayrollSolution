using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroleService
{
    public class Program
    {
        static void Main(string[] args)
        {
            Payrole payrole = new Payrole();
            bool flag = true;
            while (flag)
            {
                Console.Write("1.Display 2.Add 3.Update 4.Delete AnyOption:Exit : ");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EmployeeRepository employeeRepositoryDisplay = new EmployeeRepository();
                        employeeRepositoryDisplay.GetAllEmployes();
                        break;
                    case 2:
                        Console.Write("Enter name : ");
                        payrole.EmpName = Console.ReadLine();
                        Console.Write("Enter Department name : ");
                        payrole.EmpDept = Console.ReadLine();
                        Console.Write("Enter salary : ");
                        payrole.EmpSalary = Convert.ToInt64(Console.ReadLine()); 
                        EmployeeRepository employeeRepositoryAdd = new EmployeeRepository();
                        employeeRepositoryAdd.AddEmployee(payrole);
                        break;
                    case 3:
                        Console.Write("Enter Id : ");
                        payrole.EmpId = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Enter name : ");
                        payrole.EmpName = Console.ReadLine();
                        Console.Write("Enter Department name : ");
                        payrole.EmpDept = Console.ReadLine();
                        Console.Write("Enter salary : "); 
                        payrole.EmpSalary = Convert.ToInt64(Console.ReadLine());
                        EmployeeRepository employeeRepositoryUpdate = new EmployeeRepository();
                        employeeRepositoryUpdate.UpdateEmployee(payrole);
                        break;
                    case 4:
                        Console.Write("Enter Employee id to delte : ");
                        int employeeIdForDelete = Convert.ToInt16(Console.ReadLine());
                        EmployeeRepository employeeRepositoryDelete = new EmployeeRepository();
                        employeeRepositoryDelete.DeleteEmployee(employeeIdForDelete);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
