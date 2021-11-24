using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sendroni_Mircea_Lab8.Models;

namespace Sendroni_Mircea_Lab8.Data
{
    public class Sendroni_Mircea_Lab8Context : DbContext
    {
        public Sendroni_Mircea_Lab8Context (DbContextOptions<Sendroni_Mircea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sendroni_Mircea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sendroni_Mircea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sendroni_Mircea_Lab8.Models.Category> Category { get; set; }

        public DbSet<Sendroni_Mircea_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
