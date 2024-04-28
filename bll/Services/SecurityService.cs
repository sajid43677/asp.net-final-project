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

namespace BLL.Services
{
    public class SecurityService
    {
        public static List<SecSecurityDTO> Get()
        {
            var data = SecDataAccessFactory.SecurityData().Read();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Security, SecSecurityDTO>();
            });
            
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<SecSecurityDTO>>(data);
            return mapped;
        }

        public static SecSecurityDTO Get(int id)
        {
            var data = SecDataAccessFactory.SecurityData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Security, SecSecurityDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SecSecurityDTO>(data);
            return mapped;
        }

        public static SecSecurityReportDTO GetwithReport(int id)
        {
            var data = SecDataAccessFactory.SecurityData().Read(id);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Security, SecSecurityReportDTO>();
                c.CreateMap<Report, SecReportDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SecSecurityReportDTO>(data);
            return mapped;
        }


        public static SecSecurityDTO AddSecurity(SecSecurityDTO security)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SecSecurityDTO, Security>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Security>(security);
            var data = SecDataAccessFactory.SecurityData().Create(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<Security, SecSecurityDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<SecSecurityDTO>(data);
            return mapped2;
        }


        public static SecSecurityDTO Update(SecSecurityDTO security)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap< SecSecurityDTO, Security > ();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Security>(security);
            var data = SecDataAccessFactory.SecurityData().Update(mapped);
            var cfg2 = new MapperConfiguration(c =>
            {
                c.CreateMap<Security, SecSecurityDTO>();
            });
            var mapper2 = new Mapper(cfg2);
            var mapped2 = mapper2.Map<SecSecurityDTO>(data);
            return mapped2;
        }

        public static bool Delete(int id)
        {
            return SecDataAccessFactory.SecurityData().Delete(id);
        }


    }
}
