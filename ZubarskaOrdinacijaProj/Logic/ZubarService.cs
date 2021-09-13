using Common;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ZubarService : IZubarService
    {
        public IZubarRepository userrepo;

        public ZubarService(IZubarRepository repo)
        {
            this.userrepo = repo;
        }

        public async Task<bool> AddZubar(string sifra)
        {
            Zubar z = new Zubar();
            z.Sifra = sifra;
            try
            {
                userrepo.CreateUser(z);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}