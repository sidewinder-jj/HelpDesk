using HelpDesk.Models;
using HelpDesk.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TicketFormViewModel ticketFormViewModel)
        {
            var ticket = new Ticket
            {
                Summary = ticketFormViewModel.Summary,
                Description = ticketFormViewModel.Description
            };

            _context.Tickets.Add(ticket);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

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
    }
}