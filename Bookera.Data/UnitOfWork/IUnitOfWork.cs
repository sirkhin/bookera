using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookera.Data.UnitOfWork
{
	interface IUnitOfWork: IDisposable
	{
		int Commit();
		int Rollback();
	}
}
