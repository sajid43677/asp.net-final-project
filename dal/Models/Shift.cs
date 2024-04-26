using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Models
{
    public class Shift
    {
        [Key]
        public int sid { get; set; }

        [Required]
        [StringLength(50)]
        public string position { get; set; }

        [Required]
        [StringLength(50)]
        public string shift { get; set; }

        [ForeignKey("Security")]

        public int secId { get; set; }

        public virtual Security Security { get; set; }
    }
}
