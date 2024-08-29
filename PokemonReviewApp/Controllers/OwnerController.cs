using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interface;

namespace PokemonReviewApp.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[Controller]")]
    [ApiController]
    public class OwnerController : Controller 
    {
        private readonly IOwnerRepository _ownerRepository;
        private readonly IMapper _mapper;

        public OwnerController(IOwnerRepository ownerRepository, IMapper mapper )
        {
            _ownerRepository = ownerRepository;
            _mapper = mapper;
        }
    }
}
