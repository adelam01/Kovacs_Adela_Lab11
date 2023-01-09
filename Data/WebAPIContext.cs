using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kovacs_Adela_Lab11.Models;

    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Kovacs_Adela_Lab11.Models.ShopList> ShopList { get; set; } = default!;
    }
