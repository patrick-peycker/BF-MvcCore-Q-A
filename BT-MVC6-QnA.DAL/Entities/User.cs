using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BT_MVC6_QnA.DAL.Entities
{
	public class User : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public ICollection<Question> Questions { get; set; }
		public ICollection<Response> Responses { get; set; }
	}
}