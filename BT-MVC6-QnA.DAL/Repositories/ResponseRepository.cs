using BT_MVC6_QnA.DAL.Entities;
using BT_MVC6_QnA.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BT_MVC6_QnA.DAL.Repositories
{
	public class ResponseRepository : IResponseRepository
	{
		private readonly QnADbContext context;

		public ResponseRepository(QnADbContext context)
		{
			this.context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public Task<Response> AddAsync(Response entity)
		{
			throw new NotImplementedException();
		}

		public Task<int> CommitAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Response> DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<ICollection<Response>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Response> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Response Update(Response entity)
		{
			throw new NotImplementedException();
		}
	}
}
