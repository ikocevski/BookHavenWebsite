using BuyBooks.DataAccess.Repository.IRepository;
using BuyBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyBooks.DataAccess.Repository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType obj);
    }
}
