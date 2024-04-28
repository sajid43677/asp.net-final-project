using AutoMapper;
using bll.DTOs;
using BLL.DTOs;
using dal;
using dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.Services
{
    public class manRepairService
    {
        public static List<manRepairDTO> Get()
        {
            var data = manDataAccessFactory.RepairData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Repair, manRepairDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<manRepairDTO>>(data);
            return mapped;
        }
        public static manRepairDTO Get(int id)
        {
            var data = manDataAccessFactory.RepairData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Repair, manRepairDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<manRepairDTO>(data);
            return mapped;
        }

        public static manRepairDTO Create(manRepairDTO repair)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manRepairDTO, Repair>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Repair>(repair);
            var data = manDataAccessFactory.RepairData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<Repair, manRepairDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manRepairDTO>(data);
            return mapped2;
        }

        public static manRepairDTO Update(manRepairDTO repair)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<manRepairDTO, Repair>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Repair>(repair);
            var data = manDataAccessFactory.RepairData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<Repair, manRepairDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<manRepairDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return manDataAccessFactory.RepairData().Delete(id);
        }

        public static manRepairDTO Create(SecSecurityDTO security)
        {
            throw new NotImplementedException();
        }
    }
}
