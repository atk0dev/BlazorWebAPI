using Core.Models;
using System.Threading.Tasks;

namespace Logic
{
    public interface ITicketScreenUseCases
    {
        Task<int> AddTicket(Ticket ticket);
        Task DeleteTicket(int ticketId);
    }
}