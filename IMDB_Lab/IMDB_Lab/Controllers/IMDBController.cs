using IMDB_Lab.Models;
using IMDB_Lab.Models.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace IMDB_Lab.Controllers
{
    public class IMDBController : Controller
    {
        private readonly IIMDBRepository _iMDBRepository;

        public IMDBController(IIMDBRepository iMDBRepository)
        {
            _iMDBRepository = iMDBRepository;
        }

        //synchronous
        public IActionResult Index()
        {
            return View();
        }

        //The first action shows a blank form
        public async Task<ActionResult> MovieSearch()
        {
            return View();
        }

        //This action occurs when the client hits the submit button
        [HttpPost]
        public async Task<IActionResult> MovieSearch(SearchMovie movie)
        {
            //Search for the movie
            IMDBResponse movieResponse = await _iMDBRepository.SearchMovie(movie.SearchTerm);

            return RedirectToAction("MovieResult", movieResponse);
        }

        public async Task<IActionResult> MovieResult(IMDBResponse movie)
        {
            return View(movie);
        }

        public async Task<IActionResult> MovieNight()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MovieNightResult(MovieNight movieNight)
        {
            List<IMDBResponse> movieList = new List<IMDBResponse>();

            movieList.Add(await _iMDBRepository.SearchMovie(movieNight.Movie1));
            movieList.Add(await _iMDBRepository.SearchMovie(movieNight.Movie2));
            movieList.Add(await _iMDBRepository.SearchMovie(movieNight.Movie3));
            return View(movieList);
        }
    }
}
