using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Tadb.DAL;
using Tadb.ServerStudio.Models;

namespace Tadb.ServerStudio.Services
{
    public class RecordService
    {
        public async Task<List<RecordDto>> GetRecordsByFilter(RecordFilter recordFilter)
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                var records = context.Records.ToList();

                if (recordFilter == null)
                    return Map(records);

                var filteredRecord = FilterRecords(records, recordFilter);
                return Map(filteredRecord);
            }
        }

        public DataTable RecordsToDataTable(List<RecordDto> records)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Сотрудник");
            dataTable.Columns.Add("Статус");
            dataTable.Columns.Add("Код оборудования");
            dataTable.Columns.Add("Код приспособления");
            dataTable.Columns.Add("Код технологического перехода");
            dataTable.Columns.Add("Код обрабатываемой поверхности");

            foreach (var record in records)
            {
                dataTable.Rows.Add(
                    record.Employee, 
                    record.Status,
                    record.equipment_code,
                    record.fixture_code,
                    record.process_code,
                    record.surface_code
                    );
            }

            return dataTable;
        }

        private List<RecordDto> Map(List<Record> records)
        {
            return records.Select(x =>
            {
                Employee curEmployee = EmployeeService.GetEmployeeById(x.id_employee);
                Status curStatus = StatusService.GetStatusById(x.id_status);
                return new RecordDto
                {
                    Employee = curEmployee?.first_name + " " + curEmployee?.patronymic + " " + curEmployee?.second_name,
                    Status = curStatus?.name,
                    equipment_code = x.equipment_code,
                    fixture_code = x.fixture_code,
                    process_code = x.process_code,
                    surface_code  = x.surface_code
                };
            }).ToList();
        }

        private static List<Record> FilterRecords(List<Record> records, RecordFilter recordFilter)
        {
            if (recordFilter.EmployeeId.HasValue)
            {
                records = records.Where(x => x.id_employee.Equals(recordFilter.EmployeeId)).ToList();
            }

            if (recordFilter.StatusId.HasValue)
            {
                records = records.Where(x => x.id_status.Equals(recordFilter.StatusId)).ToList();
            }

            return records;
        }
    }
}