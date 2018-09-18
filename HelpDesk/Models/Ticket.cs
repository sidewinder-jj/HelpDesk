using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Summary { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(128)]
        public string CreatedByUserId { get; set; }
    }
}
