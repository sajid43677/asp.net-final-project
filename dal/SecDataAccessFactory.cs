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
    public class SecDataAccessFactory
    {
        public static IRepo<Security, int, Security> SecurityData()
        {
            return new SecurityRepo();
        }

        public static IRepo<Report, int, Report> ReportData()
        {
            return new ReportRepo();
        }

        public static IRepo<Shift, int, Shift> ShiftData()
        {
            return new ShiftRepo();
        }
    }
}
