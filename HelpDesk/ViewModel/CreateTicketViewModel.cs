using System.ComponentModel.DataAnnotations;

namespace HelpDesk.ViewModel
{
    public class CreateTicketViewModel
    {
        [Required]
        public string Summary { get; set; }

        [Required]
        public string Description { get; set; }

        public string CreatedByUserId { get; set; }
    }
}
