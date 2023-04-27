using Microsoft.EntityFrameworkCore;
using VanSync.Models;

namespace VanSync.Data.Context
{
    public class VanSyncContext : DbContext
    {
        public VanSyncContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AttendanceListModel> AttendanceLists { get; set; }
        public DbSet<LoginModel> Login { get; set; }
        public DbSet<UserModel> User { get; set; }
    }
}
