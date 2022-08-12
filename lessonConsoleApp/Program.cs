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


            List<Employee> employeeList = new List<Employee>() {
            new Employee("Vasya", "Pupkin", 23, 9999, true, "m"),
            new Employee("Sveta", "Sokolova", 30, 3333, false, "f"),
            new Employee("Dave", "Mustaine", 61, 22222, true, "m"),
            new Employee("Dave", "Elefson", 23, 1234, false, "m"),
            new Employee("Vasya", "Pupkin", 23, 9999, true, "f"),
        };

            PrintList(FiltredListNameIsWorking(employeeList, "Vasya", true));

            Console.WriteLine("");

            PrintList(FiltredListNameSex(employeeList, "Dave", "m"));

            Console.ReadLine();
        }

        private static List<Employee> FiltredListNameIsWorking(List<Employee> list, string name, bool isWorking)
        {
            List<Employee> filtredList = new List<Employee>();
            filtredList.AddRange(list.Where(el => (el.Name == name && el.IsWorking == isWorking)));
            return filtredList;
        }
        private static List<Employee> FiltredListNameSex(List<Employee> list, string name, string sex)
        {
            List<Employee> filtredList = new List<Employee>();
            filtredList.AddRange(list.Where(el => el.Name == name && el.Sex == sex));
            return filtredList;
        }

        private static void PrintList(List<Employee> list)
        {
            list.ForEach(el => Console.WriteLine(el));
        }
    }
}
