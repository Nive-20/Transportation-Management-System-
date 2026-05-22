namespace TransportationAPI.Models
{
    public class Transport
    {
        public int Id { get; set; }

        public string? VehicleName { get; set; }

        public string? DriverName { get; set; }

        public string? Source { get; set; }

        public string? Destination { get; set; }

        public decimal Fare { get; set; }
    }
}