using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ITerminRepository : IRepositoryBase<Termin>
    {
        Task<IEnumerable<Termin>> GetAllAsync();

        Task<Termin> GetByIdAsync(int userID);

        Task<Termin> GetWithDetailsAsync(int userID);

        void CreateUser(Termin user);

        void UpdateUser(Termin user);

        void DeleteUser(Termin user);
    }
}