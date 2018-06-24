﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.ViewModel
{
    public class TicketFormViewModel
    {
        [Required]
        public string Summary { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
