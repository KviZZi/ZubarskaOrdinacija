using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IPacijentRepository : IRepositoryBase<Pacijent>
    {
        Task<IEnumerable<Pacijent>> GetAllAsync();

        Task<Pacijent> GetByIdAsync(int userID);

        Task<Pacijent> GetWithDetailsAsync(int userID);

        void CreateUser(Pacijent user);

        void UpdateUser(Pacijent user);

        void DeleteUser(Pacijent user);
    }
}