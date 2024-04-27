using dal.Interfaces;
using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Repos
{
    internal class ReportRepo : Repo, IRepo<Report, int, Report>
    {
        public Report Create(Report obj)
        {
            db.Reports.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = db.Reports.Find(id);
            db.Reports.Remove(ex);
            if(db.SaveChanges() > 0) return true;
            else return false;
        }

        public List<Report> Read()
        {
            return db.Reports.ToList();
        }

        public Report Read(int id)
        {
            return db.Reports.Find(id);
        }

        public Report Update(Report obj)
        {
            var ex = db.Reports.Find(obj.nid);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0) return obj;
            else return null;
        }
    }
}
