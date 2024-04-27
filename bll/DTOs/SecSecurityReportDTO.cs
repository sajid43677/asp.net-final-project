using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SecSecurityReportDTO : SecSecurityDTO
    {
        public List<SecReportDTO> Reports { get; set; }

        public SecSecurityReportDTO() { 
            
            Reports = new List<SecReportDTO>();
        }
    }
}
