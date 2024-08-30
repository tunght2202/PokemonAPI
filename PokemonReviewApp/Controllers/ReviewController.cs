using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interface;

namespace PokemonReviewApp.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[Controller]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewController(IReviewRepository reviewRepository, IMapper mapper )
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }
    }
}
