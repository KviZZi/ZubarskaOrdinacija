using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IZubarService
    {
        Task<bool> AddZubar(string sifra);
    }
}