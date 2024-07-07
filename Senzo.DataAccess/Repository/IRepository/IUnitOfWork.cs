using System;
using Senzo.Models;

namespace Senzo.DataAccess.Repository.IRepository
{
	public interface IUnitOfWork
	{
		ICategoryRepository Category { get;  }

		void Save();

	}
}

