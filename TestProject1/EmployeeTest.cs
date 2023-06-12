using MediatorCQRS_NUnit.Data;
using MediatorCQRS_NUnit.Models;
using MediatorCQRS_NUnit.Services.Implementation;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;


namespace TestWithSqlLite_1
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Test_Get_By_ALL()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection).Options;
            using (var context = new ApplicationDbContext(options))
            {
                context.Database.EnsureCreated();
                context.Employees.Add(new Employee { Id = 1, EmployeeName = "Rajan", Address = "abc", EmployeeAge = 30, EmployeeCode = "110056" });
                context.SaveChanges();

                var repository = new Repository<Employee>(context);
                var employee = repository.GetALL();
                Assert.AreEqual(1, context.Employees.Count());
                Assert.AreEqual("anil", employee.FirstOrDefault().EmployeeName);


            }

        }
    }
}