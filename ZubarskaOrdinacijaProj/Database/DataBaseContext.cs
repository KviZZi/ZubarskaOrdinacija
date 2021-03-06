using Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Termin> Termins { get; set; }
        public DbSet<Zubar> Zubars { get; set; }
        public DbSet<Pacijent> Pacijents { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
    }
}