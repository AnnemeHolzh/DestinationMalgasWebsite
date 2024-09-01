using DestinationMalgasWebsite.BackEndServices.Prog7311_POE_ST10071737.Services;
using DestinationMalgasWebsite.DBServices;
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
            Bath = 2.5,
            Price = 2000.00,
            Description1 = "Tucked away on the serene banks of the majestic Breede River, Rivertime Cottage is a peaceful, secluded family holiday retreat that offers a unique back-to-basics experience. With the capacity to sleep 10 adults and 2 kids, this charming property includes a 3-bedroom house with a loft and a separate 1-bedroom cottage, comfortably accommodating up to 12 guests. It is the perfect getaway for those seeking adventure in the great outdoors or a quiet escape surrounded by nature.",
            Description2 = "Rivertime Cottage is located in one of the best spots in Malgas, offering private river access, a private jetty, and ample space for extra camping spots under the trees. The surrounding area is rich in natural beauty, teeming with bird life, including bishops, bullrushes, falcons, and fish eagles. The Breede River is popular for all water sports, including boating, skiing, tubing, kayaking, and fishing. Land activities include lovely walks, mountain biking, and horse riding nearby. For convenience, shops, restaurants, pizza places, and a winery are all within close proximity.",
            Description3 = "Rivertime Cottage embraces a simpler lifestyle, free from the distractions of Wi-Fi and television, allowing guests to fully immerse themselves in the natural surroundings. The main house is a single-story with a loft, featuring 3 bedrooms and a bath/shower bathroom, along with an outdoor shower and toilet for a rustic touch. The living space is open-plan, flowing onto a porch that overlooks the river, creating the perfect spot for reading, relaxing, or enjoying sundowners in the shade of the trees. A portable braai is available for when the weather conditions are right, complementing the indoor fireplaces that add warmth and cosiness to the space. The outside cottage, located approximately 20 meters from the main house, has a separate entrance and is an open-plan space with a Queen and Double bed, complete with an on-suite shower and toilet.",
            Description4 = "",
            Description5 = "",
            RoomConfig = new List<(string RoomName, string BedType)>
            {
                ( "Room 1", "Queen Bed" ),
                ( "Room 2", "Double Bed" ),
                ( "Room 3 (Loft)", "1 Double mattress and 2 single mattresses, perfect for kids" ),
                ("Room 4 (Outside Cottage)", "Double bed and Queen bed")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Rivertime_Cottage/1.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/3.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/4.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/5.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/6.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/7.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/8.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/9.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/10.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/11.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/12.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/13.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/14.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/15.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/16.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/17.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/18.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/19.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/20.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/21.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/22.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/23.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/24.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/25.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/26.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/27.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/28.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/29.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/30.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/31.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/32.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/33.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/34.jpg",
                "/Assets/Accommodation/Houses/Rivertime_Cottage/35.jpg"

            },
            Amenities = new List<Amenity>
            {
               new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
               new Amenity { Name = "Chiller", IconUrl = "/Assets/Accommodation/Icons/chestFreezerIcon.svg" },
               new Amenity { Name = "Microwave", IconUrl = "/Assets/Accommodation/Icons/microwaveIcon.svg" },
               new Amenity { Name = "Gas Hob and Electric Oven", IconUrl = "/Assets/Accommodation/Icons/gashobIcon.svg" },
               new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
               new Amenity { Name = "Toaster", IconUrl = "/Assets/Accommodation/Icons/toasterIcon.svg" },
               new Amenity { Name = "Fan", IconUrl = "/Assets/Accommodation/Icons/fanIcon.svg" },
               new Amenity { Name = "Jetty", IconUrl = "/Assets/Accommodation/Icons/jettyIcon.svg" },
               new Amenity { Name = "Indoor Fireplace", IconUrl = "/Assets/Accommodation/Icons/fireplaceIcon.svg" },
               new Amenity { Name = "Outdoor Seating", IconUrl = "/Assets/Accommodation/Icons/outdoorSeatingIcon.svg" },

            },
            GlanceDesc = "Peaceful, secluded family retreat offering a unique back-to-basics experience."
        },

         new House
        {
            Id = 2,
            Name = "Weaver Cottage",
            Sleeps = 6,
            Bath = 1,
            Price = 2000.00,
            Description1 = "Weaver Cottage is a true gem along the Breede River, offering a harmonious blend of functionality and minimalistic charm. This well-equipped home features bright, open spaces and provides 360-degree views of the river from virtually every corner of the house. As you step onto the large porch, you'll be greeted by stunning, ever-changing river views that set the perfect backdrop for both relaxation and social gatherings.",
            Description2 = "The cottage boasts three comfortable bedrooms with a Double and 4 Singles, a spacious bathroom complete with a shower, wash basin, and toilet. The open-plan kitchen and living area is thoughtfully designed, featuring a six-seater dining table, a cosy living space, and an indoor fireplace for those cooler evenings. Step outside to the outdoor dining area, which includes a six-seater table, a braai (barbecue) facility, and an umbrella—ideal for al fresco dining.",
            Description3 = "Weaver Cottage offers ample space and opportunities for a variety of activities. Whether you’re interested in sunbathing, swimming, boating, skiing, tubing, kayaking, fishing, or simply enjoying the scenic beauty, this location has it all. The property also includes a launching and mooring facility, making it a perfect spot for water sports enthusiasts. For those who prefer land-based activities, walking, bird watching, mountain biking, and trail biking are also available, and horse rides can be arranged. Board games are on hand for some relaxed indoor fun.",
            Description4 ="",
            Description5 = "",
             RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Double Bed"),
                ("Room 2", "2 Single Beds"),
                ("Room 3", "2 Single Beds")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Weaver_Cottage/1.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/2.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/3.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/4.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/5.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/6.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/7.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/8.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/9.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/10.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/11.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/12.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/13.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/14.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/15.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/16.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/17.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/18.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/19.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/20.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/21.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/22.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/23.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/24.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/25.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/26.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/27.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/28.jpg",
                "/Assets/Accommodation/Houses/Weaver_Cottage/29.jpg"

            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Electric 2 Plate Stove and Oven", IconUrl = "/Assets/Accommodation/Icons/2plateIcon.svg" },
                new Amenity { Name = "Toaster", IconUrl = "/Assets/Accommodation/Icons/toasterIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Bar Fridge", IconUrl = "/Assets/Accommodation/Icons/barFridgeIcon.svg" },
                new Amenity { Name = "Plunger Coffee", IconUrl = "/Assets/Accommodation/Icons/frenchpressIcon.svg" },
                new Amenity { Name = "Microwave", IconUrl = "/Assets/Accommodation/Icons/microwaveIcon.svg" },
                new Amenity { Name = "Electric Juicer", IconUrl = "/Assets/Accommodation/Icons/juicerIcon.svg" },
                new Amenity { Name = "Coffee Grinder", IconUrl = "/Assets/Accommodation/Icons/coffeeGrinderIcon.svg" },
                new Amenity { Name = "Turbo Oven", IconUrl = "/Assets/Accommodation/Icons/ovenIcon.svg" },
                new Amenity { Name = "WiFi", IconUrl = "/Assets/Accommodation/Icons/wifiIcon.svg" },
                new Amenity { Name = "Slipway", IconUrl = "/Assets/Accommodation/Icons/slipwayIcon.svg" },
                new Amenity { Name = "Jetty", IconUrl = "/Assets/Accommodation/Icons/jettyIcon.svg" }
            },
            GlanceDesc = "Perfect for those seeking tranquillity and quality time with family and friends."
        },

          new House
        {
            Id = 3,
            Name = "Riverview House",
            Sleeps = 10,
            Bath = 3,
            Price = 3000.00,
            Description1 = "Riverview House is a secluded family holiday home perched on the serene banks of the majestic Breede River in Malgas. Designed to accommodate up to 10 adults across five bedrooms, this expansive property offers the ultimate retreat for those seeking adventure or a peaceful escape in nature. With its luxurious amenities and prime location, Riverview House combines privacy, comfort, and the natural beauty of the Breede River, creating an idyllic setting for memorable family gatherings or group getaways.",
            Description2 = "Riverview House boasts one of the best locations in Malgas, offering direct access to the river via a private jetty and communal slipway. Surrounded by lush landscapes teeming with birdlife, including fish eagles and falcons, the property provides a tranquil backdrop for outdoor enthusiasts and nature lovers alike. Nearby, guests will find shops, restaurants, pizza places, and a winery, ensuring all conveniences are within easy reach.\r\nThe Breede River itself is renowned for a variety of water sports, including water-skiing, kayaking, and tubing, making it a haven for thrill-seekers. The river’s ample fishing spots are perfect for casting a line, and the opposite bank reveals a unique beach area at low tide—ideal for hours of fun for kids. For those who prefer to stay on land, the area offers lovely walking paths, mountain biking trails, and opportunities for horse riding.",
            Description3 = "Riverview House is a double-story home designed with both luxury and comfort in mind. The interior features an open-plan living space that flows seamlessly onto a spacious porch overlooking the river. This outdoor area is perfect for unwinding with a good book or enjoying sundowners as you watch the river's changing hues at dusk. An indoor fireplace and an outdoor firepit provide cosy spots for gathering and creating lasting memories, regardless of the season. The house is thoughtfully arranged to balance privacy with communal living. It includes five bedrooms, each equipped with two single beds, allowing flexibility for various group configurations. Three bathrooms, equipped with either a bath or shower, ensure convenience and comfort for all guests. The dining area and bar are ideal for socializing, while the indoor fireplace adds a touch of warmth and charm to evenings spent indoors.",
            Description4 = "Riverview House is equipped with everything needed for a carefree stay, with ample space for sunbathing, swimming, and a host of river activities right at your doorstep. The property offers endless opportunities for boating, skiing, tubing, and stand-up paddle boarding (SUP), allowing guests to fully immerse themselves in the river's offerings. The surrounding natural beauty also makes it perfect for bird watching and exploring the local flora and fauna.\r\nDespite its luxury feel, Riverview House maintains a rustic charm that encourages guests to connect with the environment. The absence of fences enhances the sense of openness and immersion in nature. A permanent live-in caretaker on the property ensures that guests’ needs are promptly met, providing peace of mind and a truly relaxing experience.\r\n",
            Description5 = "Riverview House is not just a place to stay; it’s a destination where memories are made. Whether you’re perfecting your water-skiing tricks, tackling fishing rods, or simply letting the river’s tide entertain you, each day brings a new adventure. When it's time to leave, a piece of your heart will undoubtedly remain by the river, waiting among the bullrushes and the gentle sounds of nature, until you return once more to this beautiful riverside haven.",
              RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "2 Single Beds"),
                ("Room 2", "2 Single Beds"),
                ("Room 3", "2 Single Beds"),
                ("Room 4", "2 Single Beds"),
                    ("Room 5", "2 Single Beds")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Riverview_House/1.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/2.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/3.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/4.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/5.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/6.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/7.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/8.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/9.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/10.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/11.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/12.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/13.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/14.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/15.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/16.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/17.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/18.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/19.jpg",
                "/Assets/Accommodation/Houses/Riverview_House/20.jpg"

            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Microwave", IconUrl = "/Assets/Accommodation/Icons/microwaveIcon.svg" },
                new Amenity { Name = "Gas Hob and Electric Stove", IconUrl = "/Assets/Accommodation/Icons/gasHobIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "Toaster", IconUrl = "/Assets/Accommodation/Icons/toasterIcon.svg" },
                new Amenity { Name = "Dishwasher", IconUrl = "/Assets/Accommodation/Icons/dishwasherIcon.svg" },
                new Amenity { Name = "Coffee Plunger", IconUrl = "/Assets/Accommodation/Icons/frenchpressIcon.svg" },
                new Amenity { Name = "Coffee Machine", IconUrl = "/Assets/Accommodation/Icons/coffeeMachineIcon.svg" }
            },
            GlanceDesc = "A secluded family home on the serene Breede River banks in Malgas."
        },

           new House
        {
            Id = 4,
            Name = "Greek Cottage",
            Sleeps = 4,
            Bath = 1,
            Price = 1600.00,
            Description1 = "Nestled along the serene banks of the Breede River, Greek Cottage is a hidden gem offering the perfect escape into nature's beauty. This charming, well-equipped Cottage is designed with a minimalist approach that enhances its bright, open spaces and offers stunning 360-degree views of the river and the majestic Potberg Mountains. The tranquil setting makes Greek Cottage a sanctuary for relaxation and quality time with loved ones.",
            Description2 = "Greek Cottage boasts an unrivaled location along the Breede River, one of the longest navigable rivers in South Africa. It meanders through the picturesque Overberg region, bordered by lush landscapes and framed by the towering Potberg Mountains. The Potberg Mountains, with their rugged peaks and verdant slopes, are a sight to behold, especially during sunrise and sunset when the light paints the landscape in hues of gold and pink. These mountains are part of the De Hoop Nature Reserve, known for its diverse flora and fauna, including the endangered Cape Vultures that soar above. The quietness of the area is only interrupted by the sounds of nature, creating a peaceful retreat where you can disconnect from the everyday hustle and bustle.",
            Description3 = "As you step into Greek Cottage, you'll be greeted by a large porch that offers an ever-changing view of the river. Whether it’s the mist rolling off the water in the early morning, the vibrant colors of the sunset, or the starry sky at night, the view from the porch is nothing short of spectacular. Inside, the cottage is thoughtfully designed to meet all your needs, featuring two comfortable bedrooms—one with a double bed and the other with two single beds. The bathroom is equipped with a shower, wash basin, and toilet, providing all the essentials for a comfortable stay. The open-plan kitchen and living area is the heart of the home, offering a welcoming space to gather, cook, and relax. It includes a dining area where you can enjoy meals with a view, and the kitchen is fully equipped with a fridge/freezer, microwave, kettle, toaster, and a two-plate stove with an oven. For outdoor enthusiasts, the cottage also offers a slipway and jetty, making it easy to launch boats and enjoy the river.",
            Description4 = "Greek Cottage provides ample opportunities for both relaxation and adventure. The outdoor area includes a six-seater area with a braai (barbecue) facility, perfect for alfresco dining with a backdrop of the river and mountains. Whether you’re sunbathing, swimming in the river, or exploring the area, there’s no shortage of activities to fill your days. Enjoy boating, skiing, tubing, and kayaking directly from the cottage's jetty. Fishing enthusiasts will appreciate the abundant fishing spots along the river, known for species like Cob and Garrick.\r\nFor those who prefer land-based activities, the area is perfect for walking, bird watching, mountain biking, and trail biking. The surrounding landscape is rich with birdlife, including fish eagles and kingfishers, making it an ideal spot for avid bird watchers. \r\n",
            Description5 = "Without the distractions of Wi-Fi or a TV, Greek Cottage offers a unique opportunity to reconnect with nature and enjoy the simple pleasures of life. The soothing sounds of the river, the gentle rustling of leaves, and the calls of birds create a serene ambiance that allows you to fully immerse yourself in the natural beauty of the Breede River and Potberg Mountains. Whether you’re seeking a peaceful retreat or an active outdoor experience, Greek Cottage provides the perfect setting for unforgettable moments with family and friends.",
               RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Double Bed" ),
                ( "Room 2", "2 Single Beds" )
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Greek_House/1.jpg",
                "/Assets/Accommodation/Houses/Greek_House/2.jpg",
                "/Assets/Accommodation/Houses/Greek_House/3.jpg",
                "/Assets/Accommodation/Houses/Greek_House/4.jpg",
                "/Assets/Accommodation/Houses/Greek_House/5.jpg",
                "/Assets/Accommodation/Houses/Greek_House/6.jpg",
                "/Assets/Accommodation/Houses/Greek_House/7.jpg",
                "/Assets/Accommodation/Houses/Greek_House/8.jpg",
                "/Assets/Accommodation/Houses/Greek_House/9.jpg",
                "/Assets/Accommodation/Houses/Greek_House/10.jpg",
                "/Assets/Accommodation/Houses/Greek_House/11.jpg",
                "/Assets/Accommodation/Houses/Greek_House/12.jpg",
                "/Assets/Accommodation/Houses/Greek_House/13.jpg",
                "/Assets/Accommodation/Houses/Greek_House/14.jpg",
                "/Assets/Accommodation/Houses/Greek_House/15.jpg",
                "/Assets/Accommodation/Houses/Greek_House/16.jpg",
                "/Assets/Accommodation/Houses/Greek_House/17.jpg",
                "/Assets/Accommodation/Houses/Greek_House/18.jpg",
                "/Assets/Accommodation/Houses/Greek_House/19.jpg",
                "/Assets/Accommodation/Houses/Greek_House/20.jpg",
                "/Assets/Accommodation/Houses/Greek_House/21.jpg",
                "/Assets/Accommodation/Houses/Greek_House/22.jpg",
                "/Assets/Accommodation/Houses/Greek_House/23.jpg",
                "/Assets/Accommodation/Houses/Greek_House/24.jpg",
                "/Assets/Accommodation/Houses/Greek_House/25.jpg",
                "/Assets/Accommodation/Houses/Greek_House/26.jpg",
                "/Assets/Accommodation/Houses/Greek_House/27.jpg",
                "/Assets/Accommodation/Houses/Greek_House/28.jpg"
            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Microwave", IconUrl = "/Assets/Accommodation/Icons/microwaveIcon.svg" },
                new Amenity { Name = "Toaster", IconUrl = "/Assets/Accommodation/Icons/toasterIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "2 Plate Stove and Oven", IconUrl = "/Assets/Accommodation/Icons/2plateIcon.svg" },
                new Amenity { Name = "Slipway", IconUrl = "/Assets/Accommodation/Icons/slipwayIcon.svg" },
                new Amenity { Name = "Jetty", IconUrl = "/Assets/Accommodation/Icons/jettyIcon.svg" }
            },
            GlanceDesc = "A hidden gem for a perfect escape into nature's beauty."
        },

            new House
        {
            Id = 5,
            Name = "Owl Cottage",
            Sleeps = 4,
            Bath = 1,
            Price = 2500.00,
            Description1 = "Owl Cottage is a delightful retreat on the Breede River, embodying the essence of simplicity with its “less is more” philosophy. This well-equipped and functional home offers bright, open spaces and stunning 360-degree views of the river from anywhere in the house, providing a serene and picturesque setting for your stay.",
            Description2 = "Owl Cottage features two cosy bedrooms and a bathroom complete with a shower, wash basin, and toilet. The open-plan kitchen and living area is warm and inviting, cantered around a fireplace that adds a touch of comfort. Step outside to the spacious porch, which overlooks the river and offers a captivating view that evolves from dawn to dusk. The outdoor area includes a six-seater dining table, a braai (barbecue) facility, and an umbrella, perfect for enjoying meals al fresco.",
            Description3 = "This cottage offers ample space and a variety of activities to suit all tastes. Whether you’re in the mood for sunbathing, swimming, boating, skiing, tubing, kayaking, fishing, or simply exploring the area, you’ll find it all at Owl Cottage. The property also features a launching and mooring facility, making it ideal for water-based adventures. For those who prefer to stay on land, there are opportunities for walking, bird watching, mountain biking, trail biking, and even arranging horse rides. Board games are available for some laid-back indoor fun.",
            Description4 = "",
            Description5 = "",
                RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Double Bed"),
                ("Room 2", "2 Single Beds")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Owl_Cottage/1.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/2.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/3.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/4.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/5.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/6.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/7.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/8.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/9.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/10.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/11.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/12.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/13.jpg",
                "/Assets/Accommodation/Houses/Owl_Cottage/14.jpg"

            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Deep Freezer", IconUrl = "/Assets/Accommodation/Icons/chestFreezerIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "toaster", IconUrl = "/Assets/Accommodation/Icons/toasterIcon.svg" },
                new Amenity { Name = "Music Speaker", IconUrl = "/Assets/Accommodation/Icons/speakerIcon.svg" },
                new Amenity { Name = "TV", IconUrl = "/Assets/Accommodation/Icons/tvIcon.svg" },
                new Amenity { Name = "Coffee Plunger", IconUrl = "/Assets/Accommodation/Icons/frenchpressIcon.svg" },
                new Amenity { Name = "Potjie Pot", IconUrl = "/Assets/Accommodation/Icons/potjieIcon.svg" },
                new Amenity { Name = "2 Palte Stove and Oven", IconUrl = "/Assets/Accommodation/Icons/2plateIcon.svg" },
                new Amenity { Name = "Wifi Avaliable", IconUrl = "/Assets/Accommodation/Icons/wifiIcon.svg" },
                new Amenity { Name = "slipway", IconUrl = "/Assets/Accommodation/Icons/slipwayIcon.svg" },
                new Amenity { Name = "Jetty", IconUrl = "/Assets/Accommodation/Icons/jettyIcon.svg" },
            },
            GlanceDesc = "A retreat on the Breede River, embracing a “less is more” philosophy"
        },

            new House
        {
            Id = 6,
            Name = "Delbridge House",
            Sleeps = 6,
            Bath = 3,
            Price = 3500.00,
            Description1 = "Nestled right on the edge of the Breede River, Delbridge House is a newly renovated gem offering a perfect blend of comfort and tranquillity. This picturesque retreat features a private jetty and slipway, making it an ideal choice for boating enthusiasts. The house has been thoughtfully designed with meticulous attention to detail, ensuring a homely atmosphere where guests can truly unwind. Its prime location provides easy access to local bars and restaurants, and it's just a 40 km boat ride to the river mouth at Witsand and Infanta.",
            Description2 = "Delbridge House comfortably accommodates up to 7 guests in 3 spacious bedrooms, each with its own on-suite bathroom. The top floor boasts a bright, open-plan layout featuring a fully fitted kitchen, a dining table, and a cosy lounge area. The master bedroom on this level has a queen-size bed and on-suite bathroom. Step out onto the balcony to enjoy the stunning river views from the outdoor seating and braai (barbecue) area, perfect for al fresco dining and relaxation.\r\nDownstairs, you’ll find two additional on-suite bedrooms, each with its own private entrance. Bedroom 2 offers flexibility with two single beds that can be converted into a double, while Bedroom 3 features a double bed and a single bed, along with a kitchenette and a bar fridge for added convenience.\r\n",
            Description3 = "Please note that Delbridge House is not equipped with solar power, Wi-Fi, or a TV, encouraging guests to disconnect and immerse themselves in the natural beauty of the Breede River. The serene setting, abundant fauna and flora, and river activities create a memorable escape where families and friends can create lasting memories away from the hustle and bustle of everyday life.",
            Description4 = "",
            Description5 = "",
                RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Queen Bed") ,
                ("Room 2", "2 Single Beds"),
                ("Room 3", "2 Single Beds")
            },
            ImageUrls = new List<string>
            {
               "/Assets/Accommodation/Houses/Delbridge_House/1.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/2.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/3.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/4.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/5.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/6.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/7.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/8.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/9.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/10.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/11.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/12.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/13.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/14.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/15.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/16.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/17.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/18.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/19.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/20.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/21.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/22.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/23.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/24.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/25.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/26.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/27.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/28.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/29.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/30.jpg",
                "/Assets/Accommodation/Houses/Delbridge_House/31.jpg"
            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Dishwashing Machine", IconUrl = "/Assets/Accommodation/Icons/dishwasherIcon.svg" },
                new Amenity { Name = "Indoor Fireplace", IconUrl = "/Assets/Accommodation/Icons/fireplaceIcon.svg" },
                new Amenity { Name = "Bar Fridges", IconUrl = "/Assets/Accommodation/Icons/barFridgeIcon.svg" },
                new Amenity { Name = "Outdoor Braai", IconUrl = "/Assets/Accommodation/Icons/braaiIcon.svg" },
                new Amenity { Name = "Outdoor Seating", IconUrl = "/Assets/Accommodation/Icons/outdoorSeating.svg" },
                new Amenity { Name = "Private Jetty", IconUrl = "/Assets/Accommodation/Icons/jettyIcon.svg" },
                new Amenity { Name = "Private Slipway", IconUrl = "/Assets/Accommodation/Icons/slipwayIcon.svg" },
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Gas Hob", IconUrl = "/Assets/Accommodation/Icons/gashobIcon.svg" }
            },
            GlanceDesc = "Newly renovated, blending comfort and tranquillity."
        },

            new House
        {
            Id = 7,
            Name = "H & M House",
            Sleeps = 16,
            Bath = 5,
            Price = 3500.00,
            Description1 = "Nestled against the scenic backdrop of the Potberg Mountains and the tranquil Breede River, H&M House offers an exceptional retreat for families and large groups, accommodating up to 16 guests. This splendid property, with its expansive layout and luxurious amenities, captures the essence of riverside living while providing breath-taking views and a host of activities in one of the Western Cape’s most picturesque areas. The Potberg Mountains form part of the greater De Hoop Nature Reserve, an area renowned for its rich biodiversity, fynbos, and panoramic views that stretch over rolling hills and valleys. The rugged beauty of the mountains offers a stunning contrast to the gentle flow of the Breede River, South Africa's longest navigable river, known for its lush riverbanks and abundant birdlife. The river meanders through the Overberg region, creating a serene environment that is perfect for outdoor enthusiasts and those looking to reconnect with nature.",
            Description2 = "H&M House is designed with comfort and luxury in mind, featuring spacious living areas, a fully equipped kitchen, and ample outdoor spaces that make it ideal for large groups. The property is fenced, ensuring privacy and security, and it boasts various amenities to enhance your stay.",
            Description3 = "H&M House's riverside location is a prime spot for creating lasting memories, whether you are fishing on the jetty, exploring the river by boat, or enjoying the spectacular sunset views from the patio. The property’s combination of luxury, comfort, and proximity to natural beauty makes it a standout choice for those seeking a retreat that offers both relaxation and adventure.",
            Description4 = "From the quiet mornings filled with birdsong to the exhilarating activities on the river and surrounding landscapes, H&M House provides an all-encompassing escape. The Potberg Mountains and Breede River offer a unique blend of tranquillity and excitement, making H&M House the perfect base to explore one of the Western Cape’s most picturesque and serene locations. Whether you're seeking adventure or simply a place to unwind, H&M House ensures a memorable stay amidst the stunning beauty of nature.",
            Description5 = "For additional accommodation, a flatlet is available upon request at an extra charge of R480.00. This separate unit includes:\r\n•\tSleeping Arrangements: A queen-size bed and a single bed\r\n•\tKitchenette: Equipped for light meal preparation\r\n•\tBathroom: Includes essential amenities\r\n",
            RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "King Bed"),
                ("Room 2", "King Bed and 2 Single Beds"),
                ("Room 2", "1 Double amd 4 Single Beds"),
                ( "Room 2", "King Bed" ),
                ("Room 2", "1 King Bed and 1 Single Bed"),
                ("Room 2", " Single Beds"),
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/HM_House/1.jpg",
                "/Assets/Accommodation/Houses/HM_House/2.jpg",
                "/Assets/Accommodation/Houses/HM_House/3.jpg",
                "/Assets/Accommodation/Houses/HM_House/4.jpg",
                "/Assets/Accommodation/Houses/HM_House/5.jpg",
                "/Assets/Accommodation/Houses/HM_House/6.jpg",
                "/Assets/Accommodation/Houses/HM_House/7.jpg",
                "/Assets/Accommodation/Houses/HM_House/8.jpg",
                "/Assets/Accommodation/Houses/HM_House/9.jpg",
                "/Assets/Accommodation/Houses/HM_House/10.jpg",
                "/Assets/Accommodation/Houses/HM_House/11.jpg",
                "/Assets/Accommodation/Houses/HM_House/12.jpg",
                "/Assets/Accommodation/Houses/HM_House/13.jpg",
                "/Assets/Accommodation/Houses/HM_House/14.jpg",
                "/Assets/Accommodation/Houses/HM_House/15.jpg",
                "/Assets/Accommodation/Houses/HM_House/16.jpg",
                "/Assets/Accommodation/Houses/HM_House/17.jpg",
                "/Assets/Accommodation/Houses/HM_House/18.jpg",
                "/Assets/Accommodation/Houses/HM_House/19.jpg",
                "/Assets/Accommodation/Houses/HM_House/20.jpg",
                "/Assets/Accommodation/Houses/HM_House/21.jpg",
                "/Assets/Accommodation/Houses/HM_House/22.jpg",
                "/Assets/Accommodation/Houses/HM_House/23.jpg",
                "/Assets/Accommodation/Houses/HM_House/24.jpg",
                "/Assets/Accommodation/Houses/HM_House/25.jpg",
                "/Assets/Accommodation/Houses/HM_House/26.jpg"

            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Microwave", IconUrl = "/Assets/Accommodation/Icons/microwaveIcon.svg" },
                new Amenity { Name = "Dishwasher", IconUrl = "/Assets/Accommodation/Icons/dishwasherIcon.svg" },
                new Amenity { Name = "Gas Hob and Electric Oven", IconUrl = "/Assets/Accommodation/Icons/gashobIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "Toaster", IconUrl = "/Assets/Accommodation/Icons/toasterIcon.svg" },
                new Amenity { Name = "Air Conditioning", IconUrl = "/Assets/Accommodation/Icons/airConditioningIcon.svg" },
                new Amenity { Name = "Jetty", IconUrl = "/Assets/Accommodation/Icons/jettyIcon.svg" },
                new Amenity { Name = "Indoor and Outdoor Fireplace", IconUrl = "/Assets/Accommodation/Icons/fireplaceIcon.svg" },
                new Amenity { Name = "Outdoor Seating", IconUrl = "/Assets/Accommodation/Icons/outdoorSeatingIcon.svg" },
                new Amenity { Name = "TV", IconUrl = "/Assets/Accommodation/Icons/tvIcon.svg" },
                new Amenity { Name = "WiFi (Purchase Seperately)", IconUrl = "/Assets/Accommodation/Icons/wifiIcon.svg" },
            },
            GlanceDesc = "An exceptional retreat for families and groups, accommodating up to 16."
        },

            new House
        {
            Id = 8,
            Name = "Orion Houseboat",
            Sleeps = 4,
            Bath = 1,
            Price = 2500.00,
            Description1 = "Embark on a unique and memorable houseboat adventure on the picturesque Breede River, perfect for fishing enthusiasts, birdwatchers, or anyone looking to spend quality time in nature. This 4-sleeper houseboat offers all the comforts of home combined with the excitement of a floating getaway, allowing you to explore the river at your own pace. A valid Skipper's License is required to operate the houseboat, ensuring a safe and enjoyable journey.",
            Description2 = "The houseboat boasts a large roof deck, ideal for soaking up the sun, enjoying panoramic views of the river, or simply relaxing under the open sky. It’s the perfect spot for morning coffee, sunbathing, or stargazing at night. \r\n Equipped with a dedicated stern fishing area, this houseboat is a dream come true for anglers. Cast your line from the comfort of your floating home and enjoy some of the best fishing spots the Breede River has to offer.\r\n No outdoor adventure is complete without a braai! The houseboat features a gas braai, making it easy to grill up fresh catches or cook delicious meals while enjoying the river's serene surroundings.",
            Description3 = "The Breede River is one of the largest rivers in South Africa, winding through beautiful landscapes of lush greenery, gentle hills, and serene riverbanks. The river’s calm waters are ideal for boating and its scenic surroundings offer a sense of peace and seclusion. As you navigate along the river, you’ll pass by quaint riverside villages, hidden coves, and abundant wildlife. Whether you’re anchored in a quiet spot or gently drifting along, the natural beauty of the Breede River provides a stunning backdrop for your houseboat adventure.",
            Description4 = "A houseboat adventure on the Breede River offers a one-of-a-kind escape from everyday life. It’s an opportunity to experience the freedom of life on the water, where each day brings new views, new discoveries, and new experiences. Whether you’re fishing, birdwatching, or simply enjoying the company of friends and family, the houseboat provides a cosy, comfortable base for all your river adventures. So, bring your Skipper’s License and get ready to set sail on the Breede River for an unforgettable floating holiday!",
            Description5 = "",
            RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Double Bed"),
                ("Convertible Dining Area", "Double Bed")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Orion_Houseboat/1.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/2.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/3.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/4.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/5.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/6.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/7.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/8.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/9.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/10.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/11.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/12.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/13.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/14.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/15.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/16.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/17.jpg",
                "/Assets/Accommodation/Houses/Orion_Houseboat/18.jpg"
            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Gas Hob and Electric Stove", IconUrl = "/Assets/Accommodation/Icons/gashobIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "Gas Braai", IconUrl = "/Assets/Accommodation/Icons/braaiIcon.svg" },
                new Amenity { Name = "Outdoor Seating", IconUrl = "/Assets/Accommodation/Icons/outdoorSeatingIcon.svg" },
                new Amenity { Name = "Solar", IconUrl = "/Assets/Accommodation/Icons/solarIcon.svg" },
                new Amenity { Name = "Bluetooth Sound System", IconUrl = "/Assets/Accommodation/Icons/bluetoothSpeakerIcon.svg" }
            },
            GlanceDesc = "Unique and memorable houseboat adventure on the picturesque Breede River."
        },
            new House
        {
            Id = 9,
            Name = "Heron Cottage",
            Sleeps = 4,
            Bath =  1,
            Price = 2500.00,
            Description1 = "Heron Cottage is a delightful retreat on the Breede River, embodying the essence of simplicity with its “less is more” philosophy. This well-equipped and functional home offers bright, open spaces and stunning 360-degree views of the river from anywhere in the house, providing a serene and picturesque setting for your stay.",
            Description2 = "Heron Cottage features two cosy bedrooms and a bathroom complete with a shower, wash basin, and toilet. The open-plan kitchen and living area is warm and inviting, cantered around a fireplace that adds a touch of comfort. Step outside to the spacious porch, which overlooks the river and offers a captivating view that evolves from dawn to dusk. The outdoor area includes a six-seater dining table, a braai (barbecue) facility, and an umbrella, perfect for enjoying meals al fresco.",
            Description3 = "This cottage offers ample space and a variety of activities to suit all tastes. Whether you’re in the mood for sunbathing, swimming, boating, skiing, tubing, kayaking, fishing, or simply exploring the area, you’ll find it all at Heron Cottage. The property also features a launching and mooring facility, making it ideal for water-based adventures. For those who prefer to stay on land, there are opportunities for walking, bird watching, mountain biking, trail biking, and even arranging horse rides. Board games are available for some laid-back indoor fun.",
            Description4 = "",
            Description5 = "",
            RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Double Bed"),
                ("Room 2", "2 Single Beds")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Heron_Cottage/1.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/2.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/3.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/4.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/5.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/6.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/7.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/8.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/9.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/10.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/11.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/12.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/13.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/14.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/15.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/16.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/17.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/18.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/19.jpg",
                "/Assets/Accommodation/Houses/Heron_Cottage/20.jpg"

            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Deep Freezer", IconUrl = "/Assets/Accommodation/Icons/chestFreezericon.svg" },
                new Amenity { Name = "Microwave", IconUrl = "/Assets/Accommodation/Icons/microwaveIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "Music Speaker", IconUrl = "/Assets/Accommodation/Icons/speakerIcon.svg" },
                new Amenity { Name = "TV", IconUrl = "/Assets/Accommodation/Icons/tvIcon.svg" },
                new Amenity { Name = "Frech Press", IconUrl = "/Assets/Accommodation/Icons/frenchPressIcon.svg" },
                new Amenity { Name = "Potjie Pot", IconUrl = "/Assets/Accommodation/Icons/potjieIcon.svg" },
                new Amenity { Name = "2 Palte Stove and Oven", IconUrl = "/Assets/Accommodation/Icons/2plateIcon.svg" },
                new Amenity { Name = "Wifi", IconUrl = "/Assets/Accommodation/Icons/wifiIcon.svg" },
                new Amenity { Name = "Slipway", IconUrl = "/Assets/Accommodation/Icons/slipwayIcon.svg" },
                new Amenity { Name = "Jetty", IconUrl = "/Assets/Accommodation/Icons/jettyIcon.svg" }
            },
            GlanceDesc = "A retreat on the Breede River, with a “less is more” philosophy."
        },

            new House
        {
            Id = 10,
            Name = "Infanta Fish Cottage",
            Sleeps = 6,
            Bath = 2,
            Price = 1800.00,
            Description1 = "Infanta Fish House is a charming and cosy holiday retreat located in the serene coastal village of Infanta, a hidden gem on the South African coastline. This welcoming home is perfectly suited for families and small groups, offering a blend of comfort and convenience amidst the natural beauty of the area. With accommodation for up to 6 guests across 3 bedrooms, the house provides a peaceful escape with modern amenities and easy access to the pristine surroundings.",
            Description2 = "Infanta Fish House is pet-friendly, making it an excellent choice for guests who wish to bring their pets along on their holiday. The surrounding area offers plenty of open spaces and paths for dogs to explore, making it an enjoyable experience for the entire family.",
            Description3 = "Whether you're seeking a quiet escape to relax and unwind, or an adventure-packed holiday filled with outdoor activities, InfantaFish House offers the perfect base. The combination of stunning natural scenery, a welcoming and comfortable home, and the many opportunities for exploration and relaxation make InfantaFish House a delightful destination for any traveller.",
            Description4 = "The spacious living area includes an indoor fireplace, creating a warm and inviting atmosphere perfect for cosy evenings. A dedicated study area with Wi-Fi allows guests to stay connected or even work remotely if needed. The fully equipped kitchen includes everything needed for preparing meals, making it easy to cater for your group during your stay.",
            Description5 = "",
            RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Double Bed"),
                ("Room 2", "2 Single Beds"),
                ("Room 3", "2 Single Beds")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Infantafish_House/1.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/2.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/3.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/4.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/5.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/6.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/7.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/8.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/9.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/10.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/11.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/12.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/13.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/14.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/15.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/16.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/17.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/18.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/19.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/20.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/21.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/22.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/23.jpg",
                "/Assets/Accommodation/Houses/Infantafish_House/24.jpg"
            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Microwave", IconUrl = "/Assets/Accommodation/Icons/microwaveIcon.svg" },
                new Amenity { Name = "Gas Hob and Electric Oven", IconUrl = "/Assets/Accommodation/Icons/gashobIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "Toaster", IconUrl = "/Assets/Accommodation/Icons/toasterIcon.svg" },
                new Amenity { Name = "Shared Slipway (Infanta Beach)", IconUrl = "/Assets/Accommodation/Icons/slipwayIcon.svg" },
                new Amenity { Name = "Indoor and Outdoor Fireplace", IconUrl = "/Assets/Accommodation/Icons/fireplaceIcon.svg" },
                new Amenity { Name = "Outdoor Seating", IconUrl = "/Assets/Accommodation/Icons/outdoorSeatingIcon.svg" },
                new Amenity { Name = "WiFi", IconUrl = "/Assets/Accommodation/Icons/wifiIcon.svg" }
            },
            GlanceDesc = "A charming retreat in Infanta, a hidden gem on the South African coast."
        },

            new House
        {
            Id = 10,
            Name = "Riverstay House",
            Sleeps = 8,
            Bath = 3.5,
            Price = 3000.00,
            Description1 = "Riverstay House is a serene riverside haven that perfectly captures the essence of a carefree, barefoot lifestyle, where guests can freely frolic on the lawn, explore the wild gardens, or wander along wooden walkways leading to the river. The surrounding area offers plenty of open spaces and paths for dogs to explore, making it an enjoyable experience for the entire family.",
            Description3 = "Riverstay House comfortably accommodates up to 8 guests in four beautifully appointed bedrooms, thoughtfully arranged across the property to provide privacy and comfort. Two of the bedrooms offer stunning views of the river, while all feature a cosy mix of double and queen-sized beds, ensuring restful nights after days filled with adventure.",
            Description4 = "Riverstay House is more than just a place to stay; it’s a gateway to endless outdoor adventures. Whether you’re perfecting water-skiing tricks, casting fishing rods, paddling in rubber ducks, tubing, or exploring the river on SUPs, the Breede River provides a playground for all ages. For those who prefer a slower pace, the tranquil waters and abundant birdlife, including bishops, bullrushes, falcons, and fish eagles, offer a peaceful backdrop for relaxation and reflection.",
            Description5 = "Riverstay House is designed to make every day different and exciting. The idyllic setting and diverse activities mean that whether you’re on the water or enjoying the house’s many comfortable spaces, there’s always something new to explore and enjoy. And when it’s time to leave, a part of your heart will remain by the river, eagerly awaiting your return to this beautiful, serene retreat.",
            RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Double Bed"),
                ("Room 2", "Double Bed"),
                ("Room 3", "Double Bed"),
                ("Room 4", "Queen Bed")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Riverstay_House/1.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/2.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/3.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/4.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/5.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/6.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/7.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/8.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/9.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/10.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/11.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/12.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/13.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/14.jpg",
                "/Assets/Accommodation/Houses/Riverstay_House/15.jpg"

            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Electric Oven", IconUrl = "/Assets/Accommodation/Icons/ovenIcon.svg" },
                new Amenity { Name = "Washing Machine", IconUrl = "/Assets/Accommodation/Icons/washingMachineIcon.svg" },
                new Amenity { Name = "Dishwasher", IconUrl = "/Assets/Accommodation/Icons/dishwasherIcon.svg" },
                new Amenity { Name = "Double Door Fridge", IconUrl = "/Assets/Accommodation/Icons/2DoorFridge.svg" },
                new Amenity { Name = "Microwave Oven", IconUrl = "/Assets/Accommodation/Icons/microwaveIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "Toaster", IconUrl = "/Assets/Accommodation/Icons/toasterIcon.svg" },
                new Amenity { Name = "Coffee Machine", IconUrl = "/Assets/Accommodation/Icons/coffeeMachineIcon.svg" },
                new Amenity { Name = "Chest Freezer", IconUrl = "/Assets/Accommodation/Icons/chestFreezerIcon.svg" },
                new Amenity { Name = "Food Steamer", IconUrl = "/Assets/Accommodation/Icons/steamerIcon.svg" },
                new Amenity { Name = "TV", IconUrl = "/Assets/Accommodation/Icons/tvIcon.svg" }
            },
            GlanceDesc = "A serene riverside haven capturing a carefree, barefoot lifestyle."
        },

            new House
        {
            Id = 11,
            Name = "Smit House",
            Sleeps = 10,
            Bath = 3,
            Price = 4800.00,
            Description1 = "Nestled on the tranquil banks of the majestic Breede River, Smit House is a secluded family holiday home that offers the perfect blend of luxury, nature, and adventure. This spacious double-story property comfortably sleeps up to 10 adults across five beautifully appointed bedrooms, making it an ideal getaway for families or groups of friends seeking both relaxation and recreation. With its unique location, private jetty, and river access, Smit House promises a truly memorable stay.",
            Description3 = "Smit House enjoys one of the prime locations in Malgas, right on the Breede River. The area is surrounded by lush natural landscapes, brimming with birdlife such as falcons, fish eagles, and other native species. The river is a hub for water sports enthusiasts, offering opportunities for boating, skiing, tubing, and stand-up paddle boarding (SUP). Fishing spots are abundant, and the opposite bank reveals a unique beach area at low tide, perfect for hours of fun, especially for kids.\r\nFor those who prefer land-based activities, the surroundings offer excellent walking paths, mountain bike trails, and horse riding adventures. Nearby amenities include shops, restaurants, pizza places, and a winery, all within easy reach, adding convenience to the charm of this picturesque riverside retreat.\r\n",
            Description4 = "Smit House exudes a sense of luxury with a welcoming, cosy ambiance that makes it feel like a home away from home. The open-plan living area seamlessly flows into a spacious porch that overlooks the river, providing a perfect spot for reading, relaxing, or enjoying sundowners under the shade of the trees. An indoor fireplace and outdoor braai area create inviting spaces for social gatherings, while the property’s concierge service ensures that the home remains tidy and comfortable throughout your stay.\r\nThe house features five bedrooms and three bathrooms, equipped with either baths or showers, to cater to the needs of larger groups. The upstairs area includes a delightful dining space with views of the river, a bar fridge, a second TV, and an indoor fireplace/braai area, making it an ideal setting for meals and socializing.\r\n",
            Description5 = "Smit House is fully equipped for a comfortable and enjoyable stay, with ample space to do as you please. Whether you’re sunbathing, swimming, launching a boat from your private jetty, or simply soaking in the views, the property caters to all preferences. Water sports enthusiasts can indulge in skiing, tubing, and kayaking right from the house’s doorstep. For those who enjoy quieter pursuits, bird watching, walking, and exploring the natural beauty of the area offer a peaceful retreat. The property’s open layout and multitude of spaces make it perfect for both private moments and group gatherings. Whether it’s cosy nights by the fireplace, lively meals around the dining table, or days spent exploring the river, Smit House offers a versatile and welcoming environment.",
            RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Queen Bed"),
                ("Room 2", "Double Bed"),
                ("Room 3", "Two Single Beds"),
                ("Room 4", "Queen Bed"),
                ("Room 5", "Queen Bed")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/Smit_House/1.jpg",
                "/Assets/Accommodation/Houses/Smit_House/2.jpg",
                "/Assets/Accommodation/Houses/Smit_House/3.jpg",
                "/Assets/Accommodation/Houses/Smit_House/4.jpg",
                "/Assets/Accommodation/Houses/Smit_House/5.jpg",
                "/Assets/Accommodation/Houses/Smit_House/6.jpg",
                "/Assets/Accommodation/Houses/Smit_House/7.jpg",
                "/Assets/Accommodation/Houses/Smit_House/8.jpg",
                "/Assets/Accommodation/Houses/Smit_House/9.jpg",
                "/Assets/Accommodation/Houses/Smit_House/10.jpg",
                "/Assets/Accommodation/Houses/Smit_House/11.jpg",
                "/Assets/Accommodation/Houses/Smit_House/12.jpg",
                "/Assets/Accommodation/Houses/Smit_House/13.jpg",
                "/Assets/Accommodation/Houses/Smit_House/14.jpg",
                "/Assets/Accommodation/Houses/Smit_House/15.jpg",
                "/Assets/Accommodation/Houses/Smit_House/16.jpg",
                "/Assets/Accommodation/Houses/Smit_House/17.jpg",
                "/Assets/Accommodation/Houses/Smit_House/18.jpg",
                "/Assets/Accommodation/Houses/Smit_House/19.jpg",
                "/Assets/Accommodation/Houses/Smit_House/20.jpg",
                "/Assets/Accommodation/Houses/Smit_House/21.jpg",
                "/Assets/Accommodation/Houses/Smit_House/22.jpg",
                "/Assets/Accommodation/Houses/Smit_House/23.jpg",
                "/Assets/Accommodation/Houses/Smit_House/24.jpg",
                "/Assets/Accommodation/Houses/Smit_House/25.jpg",
                "/Assets/Accommodation/Houses/Smit_House/26.jpg",
                "/Assets/Accommodation/Houses/Smit_House/27.jpg",
                "/Assets/Accommodation/Houses/Smit_House/28.jpg",
                "/Assets/Accommodation/Houses/Smit_House/29.jpg",
                "/Assets/Accommodation/Houses/Smit_House/30.jpg",
                "/Assets/Accommodation/Houses/Smit_House/31.jpg",
                "/Assets/Accommodation/Houses/Smit_House/32.jpg",
                "/Assets/Accommodation/Houses/Smit_House/33.jpg",
                "/Assets/Accommodation/Houses/Smit_House/34.jpg",
                "/Assets/Accommodation/Houses/Smit_House/35.jpg",
                "/Assets/Accommodation/Houses/Smit_House/36.jpg"
            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Bar Fridge", IconUrl = "/Assets/Accommodation/Icons/barFridgeIcon.svg" },
                new Amenity { Name = "Microwave", IconUrl = "/Assets/Accommodation/Icons/microwaveIcon.svg" },
                new Amenity { Name = "Gas Hob and Electric Oven", IconUrl = "/Assets/Accommodation/Icons/gashobIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "Air Fryer", IconUrl = "/Assets/Accommodation/Icons/airFryerIcon.svg" },
                new Amenity { Name = "Coffee Machine (Bring Beans)", IconUrl = "/Assets/Accommodation/Icons/coffeeMachineIcon.svg" },
                new Amenity { Name = "Toaster", IconUrl = "/Assets/Accommodation/Icons/toasterIcon.svg" },
                new Amenity { Name = "Fan", IconUrl = "/Assets/Accommodation/Icons/fanIcon.svg" },
                new Amenity { Name = "Air Conditioning", IconUrl = "/Assets/Accommodation/Icons/airConditioningIcon.svg" },
                new Amenity { Name = "Wifi", IconUrl = "/Assets/Accommodation/Icons/wifiIcon.svg" },
                new Amenity { Name = "2x Tv", IconUrl = "/Assets/Accommodation/Icons/tvIcon.svg" },
                new Amenity { Name = "Slipway", IconUrl = "/Assets/Accommodation/Icons/slipwayIcon.svg" },
                new Amenity { Name = "Jetty", IconUrl = "/Assets/Accommodation/Icons/jettyIcon.svg" },
                new Amenity { Name = "Concierge Service", IconUrl = "/Assets/Accommodation/Icons/conciergeIcon.svg" }
            },
            GlanceDesc = "A secluded home on the Breede River blending luxury, nature, and adventure."
        },

             new House
        {
            Id = 12,
            Name = "Southern Cross Houseboat",
            Sleeps = 4,
            Bath = 1,
            Price = 2500.00,
            Description1 = "Embark on a unique and memorable houseboat adventure on the picturesque Breede River, perfect for fishing enthusiasts, birdwatchers, or anyone looking to spend quality time in nature. This 4-sleeper houseboat offers all the comforts of home combined with the excitement of a floating getaway, allowing you to explore the river at your own pace. A valid Skipper's License is required to operate the houseboat, ensuring a safe and enjoyable journey.",
            Description3 = "The Breede River is one of the largest rivers in South Africa, winding through beautiful landscapes of lush greenery, gentle hills, and serene riverbanks. The river’s calm waters are ideal for boating and its scenic surroundings offer a sense of peace and seclusion. As you navigate along the river, you’ll pass by quaint riverside villages, hidden coves, and abundant wildlife. Whether you’re anchored in a quiet spot or gently drifting along, the natural beauty of the Breede River provides a stunning backdrop for your houseboat adventure.",
            Description4 = "A houseboat adventure on the Breede River offers a one-of-a-kind escape from everyday life. It’s an opportunity to experience the freedom of life on the water, where each day brings new views, new discoveries, and new experiences. Whether you’re fishing, birdwatching, or simply enjoying the company of friends and family, the houseboat provides a cosy, comfortable base for all your river adventures. So, bring your Skipper’s License and get ready to set sail on the Breede River for an unforgettable floating holiday!",
            Description5 = "The houseboat boasts a large roof deck, ideal for soaking up the sun, enjoying panoramic views of the river, or simply relaxing under the open sky. It’s the perfect spot for morning coffee, sunbathing, or stargazing at night. Equipped with a dedicated stern fishing area, this houseboat is a dream come true for anglers. Cast your line from the comfort of your floating home and enjoy some of the best fishing spots the Breede River has to offer.",
            RoomConfig = new List<(string RoomName, string BedType)>
            {
                ("Room 1", "Double Bed"),
                ("Convertible Dining Area", "Double Bed")
            },
            ImageUrls = new List<string>
            {
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/1.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/2.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/3.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/4.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/5.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/6.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/7.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/8.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/9.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/10.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/11.jpg",
                "/Assets/Accommodation/Houses/SouthernCross_HouseBoat/12.jpg"

            },
            Amenities = new List<Amenity>
            {
                new Amenity { Name = "Fridge", IconUrl = "/Assets/Accommodation/Icons/fridgeIcon.svg" },
                new Amenity { Name = "Gas Hob and Electric Oven", IconUrl = "/Assets/Accommodation/Icons/gashobIcon.svg" },
                new Amenity { Name = "Kettle", IconUrl = "/Assets/Accommodation/Icons/kettleIcon.svg" },
                new Amenity { Name = "Gas Braai", IconUrl = "/Assets/Accommodation/Icons/braiIcon.svg" },
                new Amenity { Name = "Outdoor Seating Area", IconUrl = "/Assets/Accommodation/Icons/outdoorSeatingIcon.svg" },
                new Amenity { Name = "Solar", IconUrl = "/Assets/Accommodation/Icons/solarIcon.svg" },
                new Amenity { Name = "Bluetooth Sound System", IconUrl = "/Assets/Accommodation/Icons/bluetoothSpeakerIcon.svg" },
            },
            GlanceDesc = "Memorable houseboat adventure on the Breede River, ideal for fishing, birdwatching, or nature."
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

        public IActionResult HouseGallery(int id)
        {
            var house = houses.FirstOrDefault(h => h.Id == id);
            if (house == null)
            {
                return NotFound();
            }

            // Filter out non-existing images
            house.ImageUrls = house.ImageUrls.Where(url => ImageExists(url)).ToList();

            return View(house);
        }

        private bool ImageExists(string path)
        {
            var physicalPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", path.TrimStart('/'));
            return System.IO.File.Exists(physicalPath);
        }


        [HttpPost]
        public async Task<IActionResult> SendEmail(string name, string email, string phoneNumber, DateTime arivalDate, DateTime departureDate, int adults, int kids, string comments, string HouseName)
        {
            var emailService = new EmailService
            {
                name = name,
                email = email,
                phoneNumber = phoneNumber,
                arrivalDate = arivalDate.ToShortDateString(),
                departureDate = departureDate.ToShortDateString(),
                adults = adults,
                kids = kids,
                comments = comments,
                HouseName = HouseName
            };

            emailService.AccomadationpageSender();

            return RedirectToAction("Accommodation");
        }

    }
}
