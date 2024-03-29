﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using src.Models;

namespace src.Data
{
	public class Context: IdentityDbContext<ApplicationUser>
	{
        public Context(DbContextOptions options) : base(options) { }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Freelancer> Freelancers {  get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Job> Jobs { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Category>()
				.HasIndex(c => c.Name)
				.IsUnique();

			builder.Entity<Job>()
				.OwnsOne(j => j.ExpectedDuration);

			base.OnModelCreating(builder);
		}
	}
}
