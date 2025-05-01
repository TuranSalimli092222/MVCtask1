using Microsoft.AspNetCore.Mvc;
using MVCTask1.Models;

namespace MVCTask1.Controllers
{
	public class HomeController : Controller
	{

		public IActionResult Index()
		{

			FeaturedCar featuredCar = new FeaturedCar()
			{
				Brand = "BMW 6-series gran coupe",
				Model = "2017",
				Price = 89.395F,

				ShortDescription = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non.",

		ImgUrl = "assets/images/brand/br1.png"
			};

			NewestCar newestCar = new NewestCar()
			{
				Name = "Ferrari",

				ShortDescription = "beleelelelelleleeelleleleleelelel"

			};
			Service Service = new Service()
			{
				Title = "unlimited repair warrenty",
				ShortDescription = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut den fugit sed quia."

			};
			
			ViewData["FeaturedCars"] = new List<FeaturedCar> { featuredCar };

			return View();
		}
	}
}
