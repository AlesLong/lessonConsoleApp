using System.Collections.Generic;

namespace lessonConsoleApp
{
    internal class Employee
    {
        private string name; 
        private string surname;
        private int age;
        private int salary;
        private bool isWorking;
        private string sex;

        public Employee(string name,
                        string surname,
                        int age,
                        int salary,
                        bool isWorking,
                        string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Salary = salary;
            this.IsWorking = isWorking;
            this.Sex = sex;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public int Salary { get => salary; set => salary = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }
        public string Sex { get => sex; set => sex = value; }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   Name == employee.Name &&
                   Surname == employee.Surname &&
                   Age == employee.Age &&
                   Salary == employee.Salary &&
                   IsWorking == employee.IsWorking &&
                   Sex == employee.Sex;
        }

        public override int GetHashCode()
        {
            int hashCode = 1338273066;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + Salary.GetHashCode();
            hashCode = hashCode * -1521134295 + IsWorking.GetHashCode();
            hashCode = hashCode * -1521134295 + Sex.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "{name : "+ name + "}{ surname : " + surname + "}{ age : " + age + "}{ salary : " 
                + salary + "}{ isWorking : " + isWorking + "}{ sex : " + sex +"}";
        }
    }
}
