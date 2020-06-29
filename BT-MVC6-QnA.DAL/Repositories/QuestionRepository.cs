using BT_MVC6_QnA.DAL.Entities;
using BT_MVC6_QnA.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_MVC6_QnA.DAL.Repositories
{
	public class QuestionRepository : IQuestionRepository
	{
		private readonly QnADbContext context;

		public QuestionRepository(QnADbContext context)
		{
			this.context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public async Task<Question> AddAsync(Question entity)
		{
			if (entity is null)
				throw new ArgumentNullException(nameof(entity));

			await context.AddAsync(entity);

			return entity;
		}

		public async Task<int> CommitAsync()
		{
			return await context.SaveChangesAsync();
		}

		public async Task<Question> DeleteAsync(int id)
		{
			var questionToDelete = await GetByIdAsync(id);
			if (questionToDelete is null)
				throw new ArgumentNullException(nameof(questionToDelete));

			questionToDelete.IsDeleted = true;

			return Update(questionToDelete);
		}

		public async Task<ICollection<Question>> GetAllAsync()
		{
			return await context.Questions
				.Include(q => q.QuestionOwner)
				.Include(q => q.Responses)
				.ThenInclude(q => q.ResponseOwner)
				.Where(q => !q.IsDeleted)
				.ToListAsync();
		}

		public async Task<Question> GetByIdAsync(int id)
		{
			return await context.Questions
				.Include(q => q.QuestionOwner)
				.Include(q => q.Responses)
				.ThenInclude(q => q.ResponseOwner)
				.Where(q => !q.IsDeleted)
				.FirstOrDefaultAsync();
		}

		public Question Update(Question entity)
		{
			if (entity is null)
				throw new ArgumentNullException(nameof(entity));

			var entityToUpdate = context.Questions.Attach(entity);
			entityToUpdate.State = EntityState.Modified;
			return entity;
		}
	}
}
