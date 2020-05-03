using System;

namespace FluentInterface
{
    public class Employee
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }
    public class EmployeeBuilder
    {
        private readonly Employee _order;

        public EmployeeBuilder()
        {
            _order = new Employee();
        }
        public EmployeeBuilder EmployeeName(string name)
        {
            _order.FullName = name;
            return this;
        }
        public EmployeeBuilder Born(string date)
        {
            _order.DateOfBirth = Convert.ToDateTime(date);
            return this;
        }
        public EmployeeBuilder StaysAt(string address)
        {
            _order.Address = address;
            return this;
        }
        public EmployeeBuilder WorkingOn(string department)
        {
            _order.Department = department;
            return this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new EmployeeBuilder();
            builder
                .EmployeeName("aamir khan")
                .Born("03/02/1996")
                .WorkingOn("IT")
                .StaysAt("Chandraghona");

        }
    }
}
