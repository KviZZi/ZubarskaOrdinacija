using Common;
using Common.Models;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void DeleteUser(Termin user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Termin>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Termin> GetByIdAsync(string userID)
        {
            throw new NotImplementedException();
        }

        public Task<Termin> GetWithDetailsAsync(string userID)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Termin user)
        {
            throw new NotImplementedException();
        }
    }
}