using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Entity;

namespace WinFormsByMetanit.Dal.Interfaces
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        Task<Client> GetClientByNameLastName(string Name, string LastName);
    }
}
