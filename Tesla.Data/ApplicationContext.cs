using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tesla.Data.Entities;

namespace Tesla.Data
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions options)
				: base(options)
		{
		}

		public DbSet<Location> Locations { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Review> Reviews { get; set; }
	}
}
