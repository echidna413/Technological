using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RecordLogic
    {
        public void AddRecord(Record r)
        {
            List<Record> records;

            using (MachineDbContext context = new MachineDbContext())
            {
                if (!context.Records.Contains(r))
                {
                    context.Records.Add(r);
                    context.SaveChanges();
                }
            }

        }

        public void RefreshStatus(int id_record, int id_status)
        {
            //
        }

        public IEnumerable<Record> GetRecordsByCompany(int id_company)
        {
            List<Record> records;

            using (MachineDbContext context = new MachineDbContext())
            {
                records = context.Records.Where(x => x.id_company == id_company).ToList();
                //из всех записей мы отбираем только те, чьи ид равны заданному ид
            }

            return records;
        }

        public void GetRecordsByEmployee(int id_employee)
        {

        }

        public void GetRecordsByStatus(int id_status)
        {

        }

        public void DeleteRecord(int id_record)
        {

        }
    }
}
