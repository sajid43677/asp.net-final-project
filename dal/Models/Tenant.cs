using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Models
{
    public class Tenant
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int floorNo { get; set; }
        [Required]
        public string flatNo { get; set; }
        [Required]
        public int uid { get; set; }

        public virtual ICollection<Repair> Repairs { get; set; }
        public Tenant()
        {
            Repairs = new List<Repair>();
        }
    }
}
