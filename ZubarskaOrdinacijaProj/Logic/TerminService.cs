using Common;
using Common.DTOS;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TerminService : ITerminService
    {
        private readonly ITerminRepository userrepo;

        public TerminService(ITerminRepository repo)
        {
            this.userrepo = repo;
        }

        public Task<Termin> CreateUser(TerminDTO usr)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Termin>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetAllIds()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetAllTeamIds()
        {
            throw new NotImplementedException();
        }

        public Task<Termin> GetUserId(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveTermin(int v)
        {
            Termin t = await userrepo.GetByIdAsync(v);
            try
            {
                userrepo.DeleteUser(t);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Task<bool> validateUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}