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
    public class OrderDetailsRepository : IOrderDatailsRepository
    {
        private readonly WindowDbContext db;
        public OrderDetailsRepository(WindowDbContext context)
        {
            db = context;
        }

        public async Task Create(OrderDetails entity)
        {
            await db.OrderDetails.AddAsync(entity);
            await db.SaveChangesAsync();
        }

        public async Task CreateAll(List<OrderDetails> entity)
        {
                await db.OrderDetails.AddRangeAsync(entity);
                await db.SaveChangesAsync();
        }
        public async Task<bool> Delete(int id)
        {
            var orderDetails = await db.OrderDetails.FirstOrDefaultAsync(x=>x.Id == id);
            db.OrderDetails.Remove(orderDetails);
            await db.SaveChangesAsync();

            return true;
        }

        public IQueryable<OrderDetails> GetAll()
        {
            return db.OrderDetails;
        }

        public async Task<OrderDetails> Update(OrderDetails entity)
        {
            var order = await db.OrderDetails.FirstOrDefaultAsync(x=>x.Id==entity.Id);
            order.Width = entity.Width;
            order.Heigth = entity.Heigth;
            order.Quantity = entity.Quantity;
            order.GlassTypePaket = entity.GlassTypePaket;
            order.GlassTypeOdinar = entity.GlassTypeOdinar;
            order.LayerGrass = entity.LayerGrass;

            await db.SaveChangesAsync();

            return order;
        }
    }
}
