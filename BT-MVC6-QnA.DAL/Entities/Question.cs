using System;
using System.Collections.Generic;

namespace BT_MVC6_QnA.DAL.Entities
{
	public class Question
	{
		public int QuestionId { get; set; }
		public string Message { get; set; }
		public User QuestionOwner { get; set; }
		public DateTime Date { get; set; }
		public StateType State { get; set; }
		public bool IsDeleted { get; set; }

		public ICollection<Response> Responses { get; set; }
	}
}
