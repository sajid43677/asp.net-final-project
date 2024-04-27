using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SecShiftDTO
    {
        public int sid { get; set; }

        [Required]

        public string position { get; set; }

        [Required]
        public string shift { get; set; }
        public int secId { get; set; }
    }
}
