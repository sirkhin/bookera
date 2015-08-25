using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
