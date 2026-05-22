using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using TransportationAPI.Models;

namespace TransportationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransportController : ControllerBase
    {
        // Temporary data list
        static List<Transport> transports = new List<Transport>()
        {
            new Transport
            {
                Id = 1,
                VehicleName = "Bus",
                DriverName = "Ravi",
                Source = "Chennai",
                Destination = "Madurai",
                Fare = 550
            },

            new Transport
            {
                Id = 2,
                VehicleName = "Van",
                DriverName = "Suresh",
                Source = "Chennai",
                Destination = "Trichy",
                Fare = 700
            }
        };

        // GET: api/transport
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(transports);
        }

        // GET by ID
        // api/transport/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var transport = transports.FirstOrDefault(x => x.Id == id);

            if (transport == null)
            {
                return NotFound();
            }

            return Ok(transport);
        }

        // POST: api/transport
        [HttpPost]
        public IActionResult Post(Transport transport)
        {
            transports.Add(transport);

            return Ok(transport);
        }

        // PUT: api/transport/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, Transport updatedTransport)
        {
            var transport = transports.FirstOrDefault(x => x.Id == id);

            if (transport == null)
            {
                return NotFound();
            }

            transport.VehicleName = updatedTransport.VehicleName;
            transport.DriverName = updatedTransport.DriverName;
            transport.Source = updatedTransport.Source;
            transport.Destination = updatedTransport.Destination;
            transport.Fare = updatedTransport.Fare;

            return Ok(transport);
        }

        // DELETE: api/transport/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var transport = transports.FirstOrDefault(x => x.Id == id);

            if (transport == null)
            {
                return NotFound();
            }

            transports.Remove(transport);

            return Ok("Deleted Successfully");
        }
    }
}