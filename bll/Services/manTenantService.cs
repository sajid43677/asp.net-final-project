using AutoMapper;
using bll.DTOs;
using dal;
using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.Services
{
    public class manTenantService
    {
        public static List<manTenantDTO> Get()
        {
            var data = manDataAccessFactory.TenantData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Tenant, manTenantDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<manTenantDTO>>(data);
            return mapped;
        }
        
        public static manTenantDTO Get(int id)
        {
            var data = manDataAccessFactory.TenantData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Tenant, manTenantDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<manTenantDTO>(data);
            return mapped;
        }

        public static manTenantRepairDTO GetwithRepair(int id)
        {
            var data = manDataAccessFactory.TenantData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Tenant, manTenantRepairDTO>();
                c.CreateMap<Repair, manRepairDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<manTenantRepairDTO>(data);
            return mapped;
        }

        public static manTenantDTO Create(manTenantDTO tenant)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manTenantDTO, Tenant>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Tenant>(tenant);
            var data = manDataAccessFactory.TenantData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<Tenant, manTenantDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manTenantDTO>(data);
            return mapped2;
        }

        public static manTenantDTO Update(manTenantDTO tenant)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manTenantDTO, Tenant>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Tenant>(tenant);
            var data = manDataAccessFactory.TenantData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<Tenant, manTenantDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manTenantDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return manDataAccessFactory.TenantData().Delete(id);
        }
    }
}
