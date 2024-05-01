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
    public class OrderRepository : IOrderRepository
    {
        private readonly WindowDbContext db;

        public OrderRepository(WindowDbContext context)
        {
            db = context;
        }

        public async Task Create(Order entity)
        {
            
            await db.Orders.AddAsync(entity);
            await db.SaveChangesAsync();
        }

        public Task CreateAll(List<Order> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            var order = await db.Orders.FirstOrDefaultAsync(x=>x.Id == id);
            db.Orders.Remove(order);
            await db.SaveChangesAsync();

            return true;
        }

        public IQueryable<Order> GetAll()
        {
            return db.Orders;
        }

        public async Task<Order> Update(Order entity)
        {
            var order = await db.Orders.FirstOrDefaultAsync(x => x.Id == entity.Id);
            order.StatusOrder = entity.StatusOrder;
            order.OrderDetails = entity.OrderDetails;
            order.Client = entity.Client;
            order.ClientId = entity.ClientId;
            
            await db.SaveChangesAsync();

            return entity;
        }
    }
}
