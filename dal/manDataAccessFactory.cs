using dal.Interfaces;
using dal.Models;
using dal.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class manDataAccessFactory
    {
        public static IRepo<Tenant, int, Tenant> TenantData()
        {
            return new TenantRepo();
        }

        public static IRepo<Repair, int, Repair> RepairData()
        {
            return new RepairRepo();
        }
    }
}
