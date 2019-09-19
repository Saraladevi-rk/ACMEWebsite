using ACME.Abstracts;
using ACME.Models;

namespace ACME.Repositories
{
    public class CountryRepository : EntityBaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(ACMEDbContext context)
           : base(context)
        { }
    }
}