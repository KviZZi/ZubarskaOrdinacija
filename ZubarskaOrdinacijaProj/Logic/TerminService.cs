using Common;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TerminService : ITerminService
    {
        public Task<Termin> CreateUser(Termin usr)
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

        public Task<bool> validateUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}