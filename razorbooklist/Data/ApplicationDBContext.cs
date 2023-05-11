using System;
using Microsoft.EntityFrameworkCore;
using razorbooklist.Models;

namespace razorbooklist.Data
{
	public class ApplicationDBContext :DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
		{
		}
		public DbSet<Category> Categories { get; set;}
	}
}

