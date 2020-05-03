using System;

namespace FluentInterface
{
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
}
