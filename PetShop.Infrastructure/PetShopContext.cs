using Microsoft.EntityFrameworkCore;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infrastructure
{
    public class PetShopContext: DbContext
    {
        public PetShopContext() : base(DbContextOptions < PetShopContext > opt)
        {
            
        }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Owner> Owners { get; set; }
    }
}
