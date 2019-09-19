using ACME.Abstracts;
using ACME.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferApplicationController : ControllerBase
    {
        private readonly IOfferApplicationRepository _offerApplicationRepository;

        public OfferApplicationController(IOfferApplicationRepository offerApplicationRepository)
        {
            _offerApplicationRepository = offerApplicationRepository;
        }

        // POST: api/OfferApplication
        [HttpPost]
        public IActionResult PostOfferApplication([FromBody] OfferApplication offerApplication)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _offerApplicationRepository.Add(offerApplication);
            _offerApplicationRepository.Commit();

            return Ok(offerApplication);
        }
    }
}