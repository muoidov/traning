using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using muoi.Authorization.Roles;
using muoi.Authorization.Users;
using muoi.MultiTenancy;
using muoi.Core;
using muoi.Core.Data;

namespace muoi.EntityFrameworkCore
{
    public class muoiDbContext : AbpZeroDbContext<Tenant, Role, User, muoiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Tableone> Tableones{get;set;}
        public DbSet<Product> Products { get; set; }
        public muoiDbContext(DbContextOptions<muoiDbContext> options)
            : base(options)
        {

        }
    }
}
