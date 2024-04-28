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

    }
}
