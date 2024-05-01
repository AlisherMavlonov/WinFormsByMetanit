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
    public class UserRepository : IUserRepository
    {
        private readonly WindowDbContext db;

        public UserRepository(WindowDbContext context)
        {
            db = context;
        }

        public async Task Create(User entity)
        {
            await db.Users.AddAsync(entity);
            await db.SaveChangesAsync();
        }

        public Task CreateAll(List<User> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            var user = await db.Users.FirstOrDefaultAsync(x=>x.Id == id);
            db.Users.Remove(user);
            await db.SaveChangesAsync(true);

            return true;
        }

        public IQueryable<User> GetAll()
        {
            return db.Users;
        }

        public async Task<User> Update(User entity)
        {
            db.Users.Update(entity);
            await db.SaveChangesAsync();

            return entity;
        }
    }
}
