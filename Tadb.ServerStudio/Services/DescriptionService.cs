using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Tadb.DAL;
using Tadb.ServerStudio.Models;

namespace Tadb.ServerStudio.Services
{
    public class DescriptionService
    {
        public async Task<List<DescriptionDto>> GetDescriprionsByFilter(DetailFilter detailFilter)
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                var descriptions = context.DDescriptions.ToList();

                if (detailFilter == null)
                    return Map(descriptions);

                var filteredDescriptions = FilterDescriptions(descriptions, detailFilter);

                return Map(filteredDescriptions);
            }
        }

        public async Task<List<string>> GetMaterials()
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                return context.DDescriptions.Select(x => x.mark_material).Distinct().ToList();
            }
        }

        public DataTable DescriptionsToDataTable(List<DescriptionDto> descriptions)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Сотрудник");
            dataTable.Columns.Add("Код детали");
            dataTable.Columns.Add("Наименование детали");
            dataTable.Columns.Add("Марка материала");
            dataTable.Columns.Add("Объем производственной партии");
            dataTable.Columns.Add("Объем передаточной партии");
            dataTable.Columns.Add("Масса детали");
            dataTable.Columns.Add("Возможность изготовления центровых отверстий");

            foreach (var description in descriptions)
            {
                dataTable.Rows.Add(
                    description.Employee,
                    description.code_detail,
                    description.name_detail,
                    description.mark_material,
                    description.size_production,
                    description.size_transmission,
                    description.mass_detail,
                    description.central_hole
                    );
            }

            return dataTable;
        }

        private static List<DescriptionDto> Map(List<DDescription> descriptions)
        {
            return descriptions.Select(x =>
            {
                var employee = EmployeeService.GetEmployeeById(x.id_employee);
                return new DescriptionDto
                {
                    Employee = employee?.first_name + " " + employee?.patronymic + " " + employee?.second_name,
                    detail_id = x.detail_id,
                    id_employee = x.id_employee,
                    code_detail = x.code_detail,
                    name_detail = x.name_detail,
                    mark_material = x.mark_material, 
                    size_production = x.size_production,
                    size_transmission = x.size_transmission,
                    mass_detail = x.mass_detail,
                    central_hole = x.central_hole ? "Да" : "Нет",
                    description = x.description
                };
            }).ToList();
        }

        private static List<DDescription> FilterDescriptions(List<DDescription> descriptions, DetailFilter detailFilter)
        {
            if (detailFilter.EmployeeId.HasValue)
            {
                descriptions = descriptions.Where(x => x.id_employee.Equals(detailFilter.EmployeeId)).ToList();
            }

            if (!string.IsNullOrEmpty(detailFilter.Material))
            {
                descriptions = descriptions.Where(x => x.mark_material.Equals(detailFilter.Material)).ToList();
            }

            return descriptions;
        }
    }
}