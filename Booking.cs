using System;
using System.Collections.Generic;

namespace boom
{
    public class Booking
    {
        public int bookingID { get; set; }
        public Contact contact { get; set; }
        public List<Lesson> lessons { get; set; }
        public List<Student> students { get; set; }
        public string comment{ get; set; }
    }
}
