using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class manRepairDTO
    {
        public int id { get; set; }

        [Required]
        public string repairDetails { get; set; }
        [Required]
        public string status { get; set; }
        public int tid { get; set; }
    }
}
