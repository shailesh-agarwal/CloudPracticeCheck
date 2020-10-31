using PracticeCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheck.Repositories
{
    public interface iadmin
    {
        public IEnumerable<BookingDetail> GetAllBookingDetail();
        public int BookTicket(BookingDetail book);
    }
}
