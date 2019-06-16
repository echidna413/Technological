using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tadb.DAL;

namespace Tadb.ServerStudio.Services
{
    public class EmployeeService
    {
        public async Task<List<Employee>> GetEmployees()
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                return context.Employees.ToList();
            }
        }

        public static Employee GetEmployeeById(int id)
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                return context.Employees.FirstOrDefault(x=> x.id_employee.Equals(id));
            }
        }
    }
}