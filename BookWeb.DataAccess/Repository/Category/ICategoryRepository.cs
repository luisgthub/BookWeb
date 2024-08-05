using BookWeb.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.DataAccess.Repository.IRepo
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);

    }
}