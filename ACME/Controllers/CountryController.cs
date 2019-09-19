using ACME.Abstracts;
using ACME.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ACME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        // GET: api/Country
        [HttpGet]
        public IEnumerable<CountryViewModel> GetCountries()
        {
            IEnumerable<Country> countries = _countryRepository.GetAll();

            IEnumerable<CountryViewModel> countriesViewModel = Mapper.Map<IEnumerable<Country>, IEnumerable<CountryViewModel>>(countries);

            return countriesViewModel;
        }
    }
}