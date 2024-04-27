using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Models
{
    public class Security
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(11)]
        public string phone { get; set; }

        [Required]
        [StringLength(4)]
        public string password { get; set; }

        public virtual ICollection<Report> Reports { get; set; }

        public Security() {

            Reports = new List<Report>(); 
        }
    }
}
