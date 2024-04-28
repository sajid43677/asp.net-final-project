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
    }
}
