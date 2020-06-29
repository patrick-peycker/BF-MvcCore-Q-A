using System.Collections.Generic;
using System.Threading.Tasks;

namespace BT_MVC6_QnA.DAL.Interfaces
{
	public interface IRepository<T> where T : class
	{
		Task<ICollection<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<T> AddAsync(T entity);
		T Update(T entity);
		Task<T> DeleteAsync(int id);
		Task<int> CommitAsync();
	}
}
