using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.Repository
{
	public interface RepositoryBase<T> where T : class
	{
		public Task<T> CreateAsync(T entity);
		public Task<T> UpdateAsync(Guid Id, T entity);
		public Task DeleteAsync(Guid Id);
		public Task<IEnumerable<T>> GetAllAsync();
		public Task<T> GetByIdAsync(Guid Id);
	}
}
