using System;
using Bookera.Data.Repository;

namespace Bookera.Data.UnitOfWork
{
	public class EFUnitOfWork: IUnitOfWork
	{
		private BookeraEntities _bookeraContext;

		public EFUnitOfWork(BookeraEntities bookeraContext)
		{
			_bookeraContext = bookeraContext;
		}
		public int Commit()
		{
			return _bookeraContext.SaveChanges();
		}

		public int Rollback()
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			_bookeraContext.Dispose();
		}
	}
}
