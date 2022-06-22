using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace boom.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        [HttpGet]
        [Route("/api/Booking/getAll")]
        public string Get()
        {
            //return getBookingsFromFile();
            return "IT WORKS JUST FINE";
        }

        [HttpPost]
        [Route("/api/Booking/insert")]
        public Booking Post(Booking model)
        {
            var bookings = getBookingsFromFile();
            var maxId = bookings.Select(x => x.bookingID).Max();
            var incrementedMaxId = maxId + 1;

            model.bookingID = incrementedMaxId;
            foreach (var lesson in model.lessons)
            {
                lesson.bookingID = incrementedMaxId;
            }

            bookings.Add(model);

            var index = bookings.FindIndex(x => x.bookingID == model.bookingID);
            System.IO.File.WriteAllText("/Users/larsgrav/Desktop/data/bookings.txt", JsonConvert.SerializeObject(bookings));
            return bookings[index];   
        }

        [HttpPut]
        [Route("/api/Booking/save")]
        public Booking Put(Booking model)
        {
            var bookings = getBookingsFromFile();
            var index = bookings.FindIndex(x => x.bookingID == model.bookingID);
            bookings[index] = model;
            System.IO.File.WriteAllText("/Users/larsgrav/Desktop/data/bookings.txt", JsonConvert.SerializeObject(bookings));
            return bookings[index];
        }

        

        private List<Booking> getBookingsFromFile() {
            string text = System.IO.File.ReadAllText("/Users/larsgrav/Desktop/data/bookings.txt");
            var retval = JsonConvert.DeserializeObject<List<Booking>>(text);
            return retval;
        }
    }
}
