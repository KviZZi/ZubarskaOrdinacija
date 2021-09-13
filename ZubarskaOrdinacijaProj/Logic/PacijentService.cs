using Common;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PacijentService : IPacijentService
    {
        public IPacijentRepository userrepo;

        public PacijentService(IPacijentRepository repo)
        {
            this.userrepo = repo;
        }

        public async Task<bool> AddPacijent(string mail)
        {
            Pacijent p = new Pacijent();
            p.Mail = mail;

            try
            {
                userrepo.Create(p);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}