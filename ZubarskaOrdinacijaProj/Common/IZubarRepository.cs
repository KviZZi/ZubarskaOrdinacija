using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IZubarRepository : IRepositoryBase<Zubar>
    {
        Task<IEnumerable<Zubar>> GetAllAsync();

        Task<Zubar> GetByIdAsync(int userID);

        Task<Zubar> GetWithDetailsAsync(int userID);

        void CreateUser(Zubar user);

        void UpdateUser(Zubar user);

        void DeleteUser(Zubar user);
    }
}