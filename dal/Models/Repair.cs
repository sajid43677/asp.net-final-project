using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Models
{
    public class Repair
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string repairDetails { get; set; }
        [Required]
        public string status { get; set; }

        [ForeignKey("Tenant")]
        public int tid { get; set; }

        public virtual Tenant Tenant { get; set; }
    }
}
