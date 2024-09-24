using System;
using Microsoft.EntityFrameworkCore;

namespace BusinessObjects
{
	public class MyDbContext : DbContext
	{
		public MyDbContext()
		{
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}

