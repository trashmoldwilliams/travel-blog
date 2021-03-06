﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using TravelBlog.Models;

namespace TravelBlog.Models
{
    public class TravelBlogContext : DbContext
    {

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TravelBlog;integrated security = True");
        }
    }
}
