using PracticeCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheck.Repositories
{
    public class admin : iadmin
    {
        private static List<BookingDetail> lst = new List<BookingDetail>() { new BookingDetail { Id = 1, PassengerId = 2222, PassengerName = "Ray", Category = "AC Sleeper", Price = 800 } };

        public int BookTicket(BookingDetail book)
        {
            if (book != null)
            {
                lst.Add(book);
                return 1;
            }
            return 0;
        }

        public IEnumerable<BookingDetail> GetAllBookingDetail()
        {
            return lst;
        }
    }
}
