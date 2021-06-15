using Core.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketScreenUseCases : ITicketScreenUseCases
    {
        private readonly ITicketRepository ticketRepository;

        public TicketScreenUseCases(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public async Task<int> AddTicket(Ticket ticket)
        {
            return await this.ticketRepository.CreateAsync(ticket);
        }

        public async Task DeleteTicket(int ticketId)
        {
            await this.ticketRepository.DeleteAsync(ticketId);
        }
    }
}
