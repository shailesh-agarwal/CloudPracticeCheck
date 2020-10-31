using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeCheck.Models;
using PracticeCheck.Repositories;

namespace PracticeCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public iadmin adm;

        public AdminController(iadmin adm)
        {
            this.adm = adm;
        }

        [HttpPost]
        [Route("BookTicket")]
        public IActionResult BookTicket([FromBody] BookingDetail book)
        {
            try
            {
                var booking = adm.BookTicket(book);
                if (booking > 0)
                {
                    return Ok(booking);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetAllBookingDetail")]
        public IActionResult GetAllBookingDetail()
        {
            try
            {
                var allbook = adm.GetAllBookingDetail().ToList();

                if (allbook != null)
                {
                    return Ok(allbook);
                }

                return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
