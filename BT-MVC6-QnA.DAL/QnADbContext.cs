using BT_MVC6_QnA.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BT_MVC6_QnA.DAL
{
	public class QnADbContext : IdentityDbContext<IdentityUser>
	{
		public QnADbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Question> Questions { get; set; }
		public DbSet<Response> Responses { get; set; }
	}
}
