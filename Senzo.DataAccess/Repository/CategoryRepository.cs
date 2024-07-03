using System;
using System.Linq.Expressions;
using Senzo.DataAccess.Data;
using Senzo.DataAccess.Repository.IRepository;
using Senzo.Models;

namespace Senzo.DataAccess.Repository
{
    public class CategoryRepository :  Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}

