using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCore.Domain.Identity;

namespace NetCore.Infrastructure
{
    public class MsSqlDbContext : IdentityDbContext<User, Role, long, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        private IConfiguration Configuration { get; }
        public MsSqlDbContext(DbContextOptions<MsSqlDbContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("User");
            builder.Entity<Role>().ToTable("Role");
            builder.Entity<RoleClaim>().ToTable("RoleClaim");
            builder.Entity<UserRole>().ToTable("UserRole");
            builder.Entity<UserClaim>().ToTable("UserClaim");
            builder.Entity<UserLogin>().ToTable("UserLogin");
            builder.Entity<UserToken>().ToTable("UserToken");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection"));
        }

        public DbSet<User> User { get; set; }
        public DbSet<User> Role { get; set; }
        public DbSet<User> RoleClaim { get; set; }
        public DbSet<User> UserRole { get; set; }
        public DbSet<User> UserClaim { get; set; }
        public DbSet<User> UserLogin { get; set; }
        public DbSet<User> UserToken { get; set; }

    }
}
