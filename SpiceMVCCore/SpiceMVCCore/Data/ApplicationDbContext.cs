﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpiceMVCCore.Models;

namespace SpiceMVCCore.Data
{
    public class ApplicationDbContext_db : IdentityDbContext
    {
        public ApplicationDbContext_db(DbContextOptions<ApplicationDbContext_db> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory>SubCategory { get; set; }
    }
}