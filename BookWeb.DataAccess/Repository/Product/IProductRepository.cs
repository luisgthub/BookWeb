using BookWeb.DataAccess.Repository.IRepo;
using BookWeb.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.DataAccess.Repository.IRepo
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);

    }
}
