using Microsoft.EntityFrameworkCore;
using Route.DAL.Data.Configurations;
using Route.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Route.DAL.Data
{
	internal class ApplicationDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseSqlServer("Server = .; Database = MVCApplication; Trusted_Connection = True");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations());
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		public DbSet<Department> Departments { get; set; }
    }
}
