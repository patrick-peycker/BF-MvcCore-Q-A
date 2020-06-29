using System;

namespace BT_MVC6_QnA.DAL.Entities
{
	public class Response
	{
		public int ResponseId { get; set; }
		public string Message { get; set; }
		public User ResponseOwner { get; set; }
		public DateTime	Date { get; set; }
		public bool IsDeleted { get; set; }
		public Question Question { get; set; }
	}
}