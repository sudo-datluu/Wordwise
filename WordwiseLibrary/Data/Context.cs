using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordwiseLibrary.Models;

namespace WordwiseLibrary.Data
{
    public class Context : DbContext
    {
        // Register Database Entity
        public DbSet<User> Users { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<WordSet> WordSets { get; set; }

        private string _connString = GlobalConfig.DBConnString();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(_connString);
    }
}
