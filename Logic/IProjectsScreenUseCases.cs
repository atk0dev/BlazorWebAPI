using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logic
{
    public interface IProjectsScreenUseCases
    {
        Task<IEnumerable<Project>> ViewProjectsAsync();
    }
}