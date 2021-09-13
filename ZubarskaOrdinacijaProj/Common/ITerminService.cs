using Common.DTOS;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ITerminService
    {
        Task<Termin> CreateUser(TerminDTO usr);

        Task<IEnumerable<Termin>> GetAll();

        Task<IEnumerable<string>> GetAllIds();

        Task<Termin> GetUserId(string id);

        Task<IEnumerable<string>> GetAllTeamIds();

        Task<bool> RemoveTermin(int v);
    }
}