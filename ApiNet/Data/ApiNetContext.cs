using ApiNet.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiNet.Data
{
    public class ApiNetContext : DbContext
    {
        public ApiNetContext (DbContextOptions<ApiNetContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
    }
}
