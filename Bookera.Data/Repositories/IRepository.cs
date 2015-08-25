using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookera.Data.Repositories
{
	public interface IRepository<T> where T: class
	{
		T GetById(int id);
		IEnumerable<T> GetAll();
		void Create(T item);
		void Delete(T item);
		void Update(T item);
	}
}
