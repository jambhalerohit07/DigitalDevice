using DigitalDevice.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalDevice.Services
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
