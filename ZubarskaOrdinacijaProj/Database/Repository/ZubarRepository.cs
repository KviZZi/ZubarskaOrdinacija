using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Common;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository
{
    public class ZubarRepository : RepositoryBase<Zubar>, IZubarRepository
    {
        public ZubarRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        public void CreateUser(Zubar user)
        {
            Create(user);
        }

        public void DeleteUser(Zubar user)
        {
            Delete(user);
        }

        public async Task<IEnumerable<Zubar>> GetAllAsync()
        {
            return await FindAll()
    .OrderBy(usr => usr.Id)
    .ToListAsync();
        }

        public async Task<Zubar> GetByIdAsync(int userID)
        {
            return await FindByCondition(usr => usr.Id.Equals(userID))
          .FirstOrDefaultAsync();
        }

        public async Task<Zubar> GetWithDetailsAsync(int userID)
        {
            return await FindByCondition(usr => usr.Id.Equals(userID))
           .FirstOrDefaultAsync(); ;
        }

        public void UpdateUser(Zubar user)
        {
            Update(user);
        }
    }
}