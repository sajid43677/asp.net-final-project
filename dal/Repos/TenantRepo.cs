using dal.Interfaces;
using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Repos
{
    internal class TenantRepo: Repo, IRepo<Tenant, int, Tenant>
    {
        public Tenant Create(Tenant entity)
        {
            db.Tenants.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
            var tenant = db.Tenants.Find(id);
            db.Tenants.Remove(tenant);
            db.SaveChanges();
            return true;
        }

        public Tenant Read(int id)
        {
            return db.Tenants.Find(id);
        }

        public List<Tenant> Read()
        {
            return db.Tenants.ToList();
        }

        public Tenant Update(Tenant entity)
        {
            var tenant = db.Tenants.Find(entity.id);
            tenant.floorNo = entity.floorNo;
            tenant.flatNo = entity.flatNo;
            db.SaveChanges();
            return tenant;
        }
    }
}
