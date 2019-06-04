using System.Linq;
using Tadb.BL;
using Tadb.DAL;
using Xunit;

namespace Tadb.UnitTests
{
    public class CreateUserTest
    {
        [Fact]
        public void Test_CreateUser()
        {
            AutorizationService service = new AutorizationService();
            string login = "echiidna";
            //string password = "1414";

            Role adminRole = new Role()
            {
                name = "admin",
                canEdit = true,
                canEditCatalog = true,
                canGetData = true,
                canEnter = true,
            };

            using (MachineDbContext context = new MachineDbContext())
            {
                foreach (var employee in context.Employees)
                {
                    context.Employees.Remove(employee);
                }

                if (!(context.Roles.FirstOrDefault(x => x.name.Equals(adminRole.name)) is null))
                {
                    context.Roles.Add(adminRole);
                }

                context.SaveChanges();
            }

            //service.CreateNewUser(login, password, adminRole);

            using (MachineDbContext context = new MachineDbContext())
            {
                Assert.NotNull(context.Employees.FirstOrDefault(x => x.login.Equals(login)));
            }
        }

        [Fact]
        public void Test_Authorization()
        {
            AutorizationService service = new AutorizationService();
            string login = "echiidna";
            string password = "1414";

            bool isOk = service.Authorize(login, password);

            Assert.True(isOk);
        }
    }
}