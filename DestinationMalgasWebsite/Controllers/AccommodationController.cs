using DestinationMalgasWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace DestinationMalgasWebsite.Controllers
{
    public class AccommodationController : Controller
    {
        private List<House> houses = new List<House>
    {
        new House
        {
            Id = 1,
            Name = "Rivertime Cottage",
            Sleeps = 11,
            Price = 2000.00,
            Introduction = "Tucked away on the serene banks of the majestic Breede River, Rivertime Cottage is a peaceful, secluded family holiday retreat that offers a unique back-to-basics experience. With the capacity to sleep 10 adults and 2 kids, this charming property includes a 3-bedroom house with a loft and a separate 1-bedroom cottage, comfortably accommodating up to 12 guests. It is the perfect getaway for those seeking adventure in the great outdoors or a quiet escape surrounded by nature.",
            LocationSurroundings = "Rivertime Cottage is located in one of the best spots in Malgas, offering private river access, a private jetty, and ample space for extra camping spots under the trees. The surrounding area is rich in natural beauty, teeming with bird life, including bishops, bullrushes, falcons, and fish eagles. The Breede River is popular for all water sports, including boating, skiing, tubing, kayaking, and fishing. Land activities include lovely walks, mountain biking, and horse riding nearby. For convenience, shops, restaurants, pizza places, and a winery are all within close proximity.",
            FeaturesLayout = "Rivertime Cottage embraces a simpler lifestyle, free from the distractions of Wi-Fi and television, allowing guests to fully immerse themselves in the natural surroundings. The main house is a single-story with a loft, featuring 3 bedrooms and a bath/shower bathroom, along with an outdoor shower and toilet for a rustic touch. The living space is open-plan, flowing onto a porch that overlooks the river, creating the perfect spot for reading, relaxing, or enjoying sundowners in the shade of the trees. A portable braai is available for when the weather conditions are right, complementing the indoor fireplaces that add warmth and cosiness to the space. The outside cottage, located approximately 20 meters from the main house, has a separate entrance and is an open-plan space with a Queen and Double bed, complete with an on-suite shower and toilet.",
            RoomConfig = new Dictionary<string, string>
            {
                { "Room 1", "Queen Bed" },
                { "Room 2", "Double Bed" },
                { "Room 3 (Loft)", "1 Double mattress and 2 single mattresses, perfect for kids" },
                { "Room 4 (Outside Cottage)", "Double bed and Queen bed" }
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Rivertime_Cottage/1.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/2.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/3.jpg"
            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Houses/Icons/fridge.png" },
                new Amenity { Name = "Microwave", IconUrl = "/Assets/Houses/Icons/microwave.png" },
                 new Amenity { Name = "Gas Hob and Electric Stove", IconUrl = "/Assets/Houses/Icons/oven.png" }
            }
        }
        };
      
        private readonly ILogger<AccommodationController> _logger;

        public AccommodationController(ILogger<AccommodationController> logger)
        {
            _logger = logger;
        }

        public IActionResult Accommodation()
        {
            return View(houses);
        }

        public IActionResult AccommodationDetails(int id)
        {
            var house = houses.FirstOrDefault(h => h.Id == id);
            if (house == null)
            {
                return NotFound();
            }
            return View(house);
        }
    }
}
