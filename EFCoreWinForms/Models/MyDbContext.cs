using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWinForms.Models
{
	public class MyDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
	}
}
