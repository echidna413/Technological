﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tadb.DAL;

namespace Tadb.ServerStudio.Services
{
    public class StatusService
    {
        public async Task<List<Status>> GetStatuses()
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                return context.Statuses.ToList();
            }
        }

        public static Status GetStatusById(int id)
        {
            using (MachineDbContext context = new MachineDbContext())
            {
                return context.Statuses.FirstOrDefault(x => x.id_status.Equals(id));
            }
        }
    }
}