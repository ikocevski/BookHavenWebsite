using BuyBooks.DataAccess.Repository.IRepository;
using BuyBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyBooks.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
