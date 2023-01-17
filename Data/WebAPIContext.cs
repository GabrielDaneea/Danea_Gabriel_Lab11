using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Danea_Gabriel_Lab11.Models;

namespace WebAPI
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Danea_Gabriel_Lab11.Models.ShopList> ShopList { get; set; } = default!;
    }
}
