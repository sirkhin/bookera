using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookera.Data.Repositories;
using Bookera.Data.Repository;

namespace Bookera.Data.EFConcrete
{
	public class EFBookRepository: IBookRepository
	{
		private readonly BookeraEntities _bookeraContext;
		public EFBookRepository()
		{
			_bookeraContext = new BookeraEntities();
		}
		public Entity.Book GetById(int id)
		{
			return _bookeraContext.Books.Find(id);
		}

		public IEnumerable<Entity.Book> GetAll()
		{
			return _bookeraContext.Books;
		}

		public void Create(Entity.Book item)
		{
			_bookeraContext.Books.Add(item);
		}

		public void Delete(Entity.Book item)
		{
			_bookeraContext.Books.Remove(item);
		}

		public void Update(Entity.Book item)
		{
			_bookeraContext.Entry(item).State = EntityState.Modified;
		}
	}
}
