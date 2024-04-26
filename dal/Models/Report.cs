using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Models
{
    public class Report
    {
        [Key]
        public int nid { get; set; }

        [Required]
        [StringLength(100)]
        public string reason { get; set; }

        [Required]
        [StringLength(50)]
        public string carNo { get; set; }

        [ForeignKey("Security")]

        public int secId { get; set; }

        public virtual Security Security { get; set; }
    }
}
