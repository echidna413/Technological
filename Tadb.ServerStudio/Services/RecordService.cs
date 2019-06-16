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
        public async Task<List<Record>> GetRecordsByFilter(RecordFilter recordFilter)
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                var records = context.Records.ToList();

                if (recordFilter == null)
                    return records;

                return FilterRecords(records, recordFilter);
            }
        }

        public DataTable RecordsToDataTable(List<Record> records)
        {
            //TODO добавить все нужные поля
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Сотрудник");
            dataTable.Columns.Add("Статус");

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Employee, record.Status);
            }

            return dataTable;
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