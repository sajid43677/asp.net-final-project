using dal.Interfaces;
using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Repos
{
    internal class RepairRepo: Repo, IRepo<Repair, int, Repair>
    {
        public Repair Create(Repair obj)
        {
            db.Repairs.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public List<Repair> Read()
        {
            return db.Repairs.ToList();
        }

        public Repair Read(int id)
        {
            return db.Repairs.FirstOrDefault(x => x.id == id);
        }

        public Repair Update(Repair obj)
        {
            Repair repair = db.Repairs.FirstOrDefault(x => x.id == obj.id);
            if (repair != null)
            {
                repair.repairDetails = obj.repairDetails;
                repair.status = obj.status;
                db.SaveChanges();
            }
            else
            {
                return null;
            }
            return repair;
        }

        public bool Delete(int id)
        {
            Repair repair = db.Repairs.FirstOrDefault(x => x.id == id);
            if (repair != null)
            {
                db.Repairs.Remove(repair);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
