using ACME.Abstracts;
using ACME.Models;

namespace ACME.Repositories
{
    public class OfferApplicationRepository : EntityBaseRepository<OfferApplication>, IOfferApplicationRepository
    {
        public OfferApplicationRepository(ACMEDbContext context)
           : base(context)
        { }
    }
}