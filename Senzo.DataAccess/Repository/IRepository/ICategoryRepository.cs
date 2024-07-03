using System;
using Senzo.Models;

namespace Senzo.DataAccess.Repository.IRepository
{
	public interface ICategoryRepository : IRepository<Category>
	{
		void Update(Category obj);
		void Save();

	}
}

