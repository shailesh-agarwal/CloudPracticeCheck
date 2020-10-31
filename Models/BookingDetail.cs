using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheck.Models
{
    public class BookingDetail
    {
        [Key]
        public int Id { get; set; }
        public int? PassengerId { get; set; }
        public string PassengerName { get; set; }
        public string Category { get; set; }
        public double? Price { get; set; }
    }
}
