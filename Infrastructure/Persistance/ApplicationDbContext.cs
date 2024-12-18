﻿using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class ApplacationDbContext :DbContext, IApplicationDbContext
    {
        public DbSet<Order> orders { get; set; }

        public ApplacationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new OrderConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
