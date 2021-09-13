using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IUserRepository : IRepositoryBase<Termin>
    {
        Task<IEnumerable<Termin>> GetAllAsync();

        Task<Termin> GetByIdAsync(string userID);

        Task<Termin> GetWithDetailsAsync(string userID);

        void CreateUser(Termin user);

        void UpdateUser(Termin user);

        void DeleteUser(Termin user);
    }
}