using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class manTenantDTO
    {
        public int id { get; set; }
        [Required]
        public int floorNo { get; set; }
        [Required]
        public string flatNo { get; set; }
        [Required]
        public int uid { get; set; }
    }
}
