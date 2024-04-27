using dal.Interfaces;
using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Repos
{
    internal class ShiftRepo : Repo, IRepo<Shift, int, Shift>
    {
        public Shift Create(Shift obj)
        {
            db.Shifts.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(int id)
        {
            var ex = db.Shifts.Find(id);
            db.Shifts.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else return false;
        }

        public List<Shift> Read()
        {
            return db.Shifts.ToList();
        }

        public Shift Read(int id)
        {
            return db.Shifts.Find(id);

        }

        public Shift Update(Shift obj)
        {
            var ex = db.Shifts.Find(obj.sid);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }
    }
}
