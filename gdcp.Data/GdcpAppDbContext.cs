using gdcp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace gdcp.Data
{
    public class GdcpAppDbContext : DbContext
    {
        public GdcpAppDbContext(DbContextOptions<GdcpAppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
