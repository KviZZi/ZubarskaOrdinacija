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
    public class TerminiRepository : RepositoryBase<Termin>, ITerminRepository
    {
        public TerminiRepository(DataBaseContext dbContext) : base(dbContext)
        {
        }

        public void CreateUser(Termin user)
        {
            Create(user);
        }

        public void DeleteUser(Termin user)
        {
            Delete(user);
        }

        public async Task<IEnumerable<Termin>> GetAllAsync()
        {
            return await FindAll()
       .OrderBy(usr => usr.Id)
       .ToListAsync();
        }

        public async Task<Termin> GetByIdAsync(int userID)
        {
            return await FindByCondition(usr => usr.Id.Equals(userID))
           .FirstOrDefaultAsync();
        }

        public async Task<Termin> GetWithDetailsAsync(int userID)
        {
            return await FindByCondition(usr => usr.Id.Equals(userID))
            .FirstOrDefaultAsync();
        }

        public void UpdateUser(Termin user)
        {
            Update(user);
        }
    }
}