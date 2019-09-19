using ACME.Models;

namespace ACME.Abstracts
{
    public interface ICountryRepository : IEntityBaseRepository<Country> { }

    public interface IPostcodeRepository : IEntityBaseRepository<Postcodes> { }

    public interface IOfferApplicationRepository : IEntityBaseRepository<OfferApplication> { }
}