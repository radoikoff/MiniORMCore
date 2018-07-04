namespace MiniORM.App
{
    using Data;
    using Data.Entities;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            const string connectionString = @"Server=(local)\SQLEXPRESS;DataBase=MiniORM;Integrated Security=True";

            var context = new SoftUniDbContext(connectionString);

            //var emploees = context.Employees.ToList();

            var newEmployee = new Employee
            {
                FirstName = "CC",
                LastName = "CCCCC",
                DepartmentId = context.Departments.First().Id,
                IsEmployed = true
            };

            context.Employees.Add(newEmployee);
            context.SaveChanges();

            var secondEmployee = new Employee
            {
                FirstName = "DD",
                LastName = "DDDDD",
                DepartmentId = context.Departments.First().Id,
                IsEmployed = true
            };
            context.Employees.Add(secondEmployee);
            context.SaveChanges();

            //Case 2
            //var employee = context.Employees.Single(e => e.Id == 8);
            //employee.MiddleName = "Jr.";
            //context.SaveChanges();


        }
    }
}
