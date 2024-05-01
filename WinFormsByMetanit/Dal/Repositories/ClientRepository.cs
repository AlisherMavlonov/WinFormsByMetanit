using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Dal.Interfaces;
using WinFormsByMetanit.Domain.Entity;

namespace WinFormsByMetanit.Dal.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly WindowDbContext db;

        public ClientRepository(WindowDbContext context)
        {
            db = context;
        }

        public async Task Create(Client entity)
        {
            await db.Clients.AddAsync(entity);
            await db.SaveChangesAsync();
        }

        public async Task CreateAll(List<Client> entity)
        {
            await db.Clients.AddRangeAsync(entity);
            await db.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var client = await db.Clients.FirstOrDefaultAsync(x=>x.Id == id);
            db.Clients.Remove(client);
            await db.SaveChangesAsync();

            return true;
        }

        public IQueryable<Client> GetAll()
        {
            return db.Clients;
        }

        public async Task<Client> GetClientByNameLastName(string Name, string LastName)
        {
            var client = await db.Clients.FirstOrDefaultAsync(x=>x.Name == Name 
            && x.LastName == LastName);

            return client;
        }

        public async Task<Client> Update(Client entity)
        {
            var client = await db.Clients.FirstOrDefaultAsync(x=>x.Id==entity.Id);
            client.PhoneNumber = entity.PhoneNumber;
            client.LastName = entity.LastName;
            client.Orders = entity.Orders;
            await db.SaveChangesAsync();

            return client;
        }
    }
}
