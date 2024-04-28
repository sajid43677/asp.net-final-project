using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class manTenantRepairDTO: manTenantDTO
    {
        public List<manRepairDTO> Repairs { get; set; }

        public manTenantRepairDTO()
        {
            
            Repairs = new List<manRepairDTO>();
        }
    }
}
