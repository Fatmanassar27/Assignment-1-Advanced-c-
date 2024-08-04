using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Advanced_c_.Genaric
{
    internal class Employee : IComparable
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"({Id} :: {Name} :: {Salary})";
        }

        public override bool Equals(object? obj)
        {
            Employee? employee = (Employee?)obj;
            return (Id == employee?.Id) && (Name == employee.Name) && (Salary == employee.Salary);
        }

        public override int GetHashCode()
        {
           // return this.Id.GetHashCode() + this.Name?.GetHashCode() ?? 0 + this.Salary.GetHashCode();
           return HashCode.Combine(Id, Name, Salary);
        }

        public int CompareTo(object? obj)
        {
            //Employee? employee = (Employee?)obj;
            if (obj is  Employee employee) 
                 return this.Salary.CompareTo(employee?.Salary);
            else return 1;
        }
    }
}
