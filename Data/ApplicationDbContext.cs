﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebCK.Models;

namespace WebCK.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<BookingForm> Forms { get; set; }
        public DbSet<DepositBill> Bills { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
