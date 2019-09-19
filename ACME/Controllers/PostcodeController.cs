using ACME.Abstracts;
using ACME.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ACME.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostcodeController : ControllerBase
    {
        private readonly IPostcodeRepository _postcodeRepository;

        public PostcodeController(IPostcodeRepository postcodeRepository)
        {
            _postcodeRepository = postcodeRepository;
        }

        // GET: api/Postcode
        [HttpGet]
        public IEnumerable<PostcodeViewModel> GetPostcodes()
        {
            IEnumerable<Postcodes> postCodes = _postcodeRepository.GetAll();

            IEnumerable<PostcodeViewModel> postcodeViewModels = Mapper.Map<IEnumerable<Postcodes>, IEnumerable<PostcodeViewModel>>(postCodes);

            return postcodeViewModels;
        }
    }
}