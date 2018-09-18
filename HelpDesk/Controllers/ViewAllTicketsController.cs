using HelpDesk.Models;
using HelpDesk.ViewModel;
using System;
using System.Linq;
using System.Web.Mvc;

namespace HelpDesk.Controllers
{
    public class ViewAllTicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ViewAllTicketsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            var tickets = _context.Tickets.ToList();

            foreach (var ticket in tickets)
            {
                TicketRowViewModel viewModel = new TicketRowViewModel();

                viewModel.Summary = ticket.Summary;
                viewModel.DateSubmitted = DateTimeOffset.UtcNow;
            }

            return View(tickets);
        }
    }
}