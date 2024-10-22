using Microsoft.EntityFrameworkCore;
using Bio_Agriturismo.Model;

namespace Bio_Agriturismo.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Room>Rooms { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
