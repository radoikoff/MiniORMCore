namespace MiniORM.App
{
    using MiniORM.App.Data;

    public class StartUp
    {
        static void Main()
        {
            const string connectionString = "Server=.;DataBase=MiniORM;Integrated Security=True";

            var context = new SoftUniDbContext(connectionString);

            var emploees = context.Employees.ToList();
        }
    }
}
