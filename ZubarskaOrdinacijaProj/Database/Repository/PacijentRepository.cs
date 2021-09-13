using Common;
using Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository
{
    public class PacijentRepository : RepositoryBase<Pacijent>, IPacijentRepository
    {
        public PacijentRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        public void CreateUser(Pacijent user)
        {
            Create(user);
        }

        public void DeleteUser(Pacijent user)
        {
            Delete(user);
        }

        public async Task<IEnumerable<Pacijent>> GetAllAsync()
        {
            return await FindAll()
       .OrderBy(usr => usr.Id)
       .ToListAsync();
        }

        public async Task<Pacijent> GetByIdAsync(int userID)
        {
            return await FindByCondition(usr => usr.Id.Equals(userID))
           .FirstOrDefaultAsync();
        }

        public async Task<Pacijent> GetWithDetailsAsync(int userID)
        {
            return await FindByCondition(usr => usr.Id.Equals(userID))
            .FirstOrDefaultAsync();
        }

        public void UpdateUser(Pacijent user)
        {
            Update(user);
        }
    }
}