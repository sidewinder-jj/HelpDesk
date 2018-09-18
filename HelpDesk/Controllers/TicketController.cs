using HelpDesk.Models;
using HelpDesk.ViewModel;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace HelpDesk.Controllers
{
    public class TicketController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketController()
        {
            _context = new ApplicationDbContext();

        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CreateTicketViewModel ticketFormViewModel)
        {
            var ticket = new Ticket
            {
                Summary = ticketFormViewModel.Summary,
                Description = ticketFormViewModel.Description,
                CreatedByUserId = User.Identity.GetUserId()
            };

            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [HttpGet]
        public ActionResult View(int ticketId)
        {
            var ticket = _context.Tickets.Find(ticketId);
            var viewModel = new Ticket
            {
                Description = ticket.Description,
                Id = ticket.Id,
                Summary = ticket.Summary
            };

            return View(ticket);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Edit(Ticket ticket)
        {
            var existingTicket = _context.Tickets.Find(ticket.Id);

            existingTicket.Summary = ticket.Summary;
            existingTicket.Description = ticket.Description;

            _context.SaveChanges();

            return View("View", ticket.Id);
        }
    }
}