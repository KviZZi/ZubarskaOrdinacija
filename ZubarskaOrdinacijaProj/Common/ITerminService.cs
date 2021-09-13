using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ITerminService
    {
        Task<Termin> CreateUser(Termin usr);

        Task<IEnumerable<Termin>> GetAll();

        Task<IEnumerable<string>> GetAllIds();

        Task<bool> validateUser(string id);

        Task<Termin> GetUserId(string id);

        Task<IEnumerable<string>> GetAllTeamIds();
    }
}