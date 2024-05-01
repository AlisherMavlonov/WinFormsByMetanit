using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Response;

namespace WinFormsByMetanit.Service.Interfaces
{
    public interface IClientService
    {
        Task<IBaseResponse<Client>> AddClient(Client newClient);
        Task<IBaseResponse<Client>> UpdateClient(Client updateClient);
        Task<IBaseResponse<Client>> DeleteClient(int id);
        Task<IBaseResponse<Client>> GetClient(string Name, string LastName);
        Task<IBaseResponse<IEnumerable<Client>>> GetAllClients();


    }
}
