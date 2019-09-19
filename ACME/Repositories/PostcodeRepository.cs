using ACME.Abstracts;
using ACME.Models;

namespace ACME.Repositories
{
    public class PostcodeRepository : EntityBaseRepository<Postcodes>, IPostcodeRepository
    {
        public PostcodeRepository(ACMEDbContext context)
           : base(context)
        { }
    }
}