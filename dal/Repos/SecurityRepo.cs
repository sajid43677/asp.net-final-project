using dal.Interfaces;
using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Repos
{
    internal class SecurityRepo : Repo, IRepo<Security, int, Security>
    {
        public Security Create(Security obj)
        {
            db.Securitys.Add(obj);
            if(db.SaveChanges() > 0 ) return obj;
            else return null;

        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Securitys.Remove(ex);
            if (db.SaveChanges() > 0) return true;
            else { return false; }
        }

        public List<Security> Read()
        {
            return db.Securitys.ToList();
        }

        public Security Read(int id)
        {
            return db.Securitys.Find(id);
        }

        public Security Update(Security obj)
        {
            var ex = db.Securitys.Find(obj.id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj; 
            else return null;

        }
    }
}
