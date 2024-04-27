using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SecReportDTO
    {
        public int nid { get; set; }

        [Required]
        public string reason { get; set; }

        [Required]
        public string carNo { get; set; }

        public int secId { get; set; }
    }
}
