namespace FluentInterface
{
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
