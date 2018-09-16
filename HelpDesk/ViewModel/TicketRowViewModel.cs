using System;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.ViewModel
{
    public class TicketRowViewModel
    {
        [Required]
        public string Summary { get; set; }

        [Required]
        public DateTimeOffset DateSubmitted { get; set; }
    }
}
