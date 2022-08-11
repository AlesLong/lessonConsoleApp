using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Vasya", "Pupkin", 23, 9999, true, 'm');
            Employee emp2 = new Employee("Sveta", "Sokolova", 30, 3333, false, 'f');
            Employee emp3 = new Employee("Dave", "Mustaine", 61, 22222, true,'m');
            Employee emp4 = new Employee("Dave", "Elefson", 23, 1234, false, 'm') ;
            Employee emp5 = new Employee("Vasya", "Pupkin", 23, 9999, true, 'f');

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            employeeList.Add(emp4);
            employeeList.Add(emp5);

            List<Employee> filtredList = new List<Employee>();

            filtredList.AddRange(employeeList.Where(el => (el.Name == "Vasya"&&el.IsWorking == true)));

            filtredList.ForEach(el => Console.WriteLine(el));

            List<Employee> filtredList2 = new List<Employee>();

            filtredList2.AddRange(employeeList.Where(el => el.Name == "Dave" && el.Sex == 'm'));

            filtredList2.ForEach(el => Console.WriteLine(el));

            Console.ReadLine();
        }
    }
}
