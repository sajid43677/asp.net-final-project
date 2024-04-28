using AutoMapper;
using BLL.DTOs;
using dal.Models;
using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SecShiftService
    {
        public static List<SecShiftDTO> Get()
        {
            var data = SecDataAccessFactory.ShiftData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Shift, SecShiftDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<SecShiftDTO>>(data);
            return mapped;
        }

        public static SecShiftDTO Get(int id)
        {
            var data = SecDataAccessFactory.ShiftData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Shift, SecShiftDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SecShiftDTO>(data);
            return mapped;
        }


        public static SecShiftDTO AddShift(SecShiftDTO shift)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SecShiftDTO, Shift>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Shift>(shift);
            var data = SecDataAccessFactory.ShiftData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<Shift, SecShiftDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<SecShiftDTO>(data);
            return mapped2;
        }


        public static SecShiftDTO Update(SecShiftDTO shift)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SecShiftDTO, Shift>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Shift>(shift);
            var data = SecDataAccessFactory.ShiftData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<Shift, SecShiftDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<SecShiftDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return SecDataAccessFactory.ShiftData().Delete(id);
        }
    }
}
