using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCorePostgre.Domain.Identity;

namespace NetCorePostgre.Infrastructure
{
    public class PostgreSqlDbContext : IdentityDbContext<User, Role, long, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        private IConfiguration Configuration { get; }
        public PostgreSqlDbContext(DbContextOptions<PostgreSqlDbContext> options, IConfiguration configuration) : base(options)
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
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("PostgreSqlConnection"));
        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserClaim> UserClaim { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }
        public DbSet<UserToken> UserToken { get; set; }

    }
}
