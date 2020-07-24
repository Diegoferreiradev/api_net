using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiNet.Models;

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
