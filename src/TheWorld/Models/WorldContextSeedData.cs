using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    public class WorldContextSeedData
    {
        private WorldContext _context;

        public WorldContextSeedData(WorldContext context)
        {
            _context = context;
        }

        public void EnsureSeedData()
        {
            if (!_context.Trips.Any())
            {
                // Add new Data
                var usTrip = new Trip()
                {
                    Name = "US Trip",
                    Created = DateTime.UtcNow,
                    UserName = "",
                    Stops = new List<Stop>()
                    {
                        new Stop() { Name = "Atlanta, GA", Arrival = new DateTime(2014, 6, 4), Order = 0, Latitude = 33.7550, Longitude = -84.3900 },
                        new Stop() { Name = "New York, NY", Arrival = new DateTime(2014, 6, 9), Order = 1, Latitude = 40.7127, Longitude = -74.0059 },
                        new Stop() { Name = "Boston, MA", Arrival = new DateTime(2014, 7, 1), Order = 2, Latitude = 42.3601, Longitude = -71.0589 },
                        new Stop() { Name = "Chicago, IL", Arrival = new DateTime(2014, 7, 10), Order = 3, Latitude = 41.8369, Longitude = -87.6847 },
                        new Stop() { Name = "Seattle, WA", Arrival = new DateTime(2014, 8, 13), Order = 4, Latitude = 47.6097, Longitude = -122.3331 },
                        new Stop() { Name = "Atlanta, GA", Arrival = new DateTime(2014, 8, 23), Order = 5, Latitude = 33.7550, Longitude = -84.3900 },
                    }
                };

                _context.Trips.Add(usTrip);
                _context.Stops.AddRange(usTrip.Stops);

                var worldTrip = new Trip()
                {
                    Name = "World Trip",
                    Created = DateTime.UtcNow,
                    UserName = "",
                    Stops = new List<Stop>()
                    {
                        new Stop() { Name = "Fort Lauderdale, FL", Arrival = new DateTime(2015, 10, 31), Order = 0, Latitude = 26.1333, Longitude = -80.1500 },
                        new Stop() { Name = "New York, NY", Arrival = new DateTime(2015, 11, 3), Order = 1, Latitude = 40.7127, Longitude = -74.0059 },
                        new Stop() { Name = "Amsterdam, Netherlands", Arrival = new DateTime(2015, 11, 13), Order = 2, Latitude = 52.3667, Longitude = 4.9000 },
                        new Stop() { Name = "Barcelona, Spain", Arrival = new DateTime(2016, 11, 20), Order = 3, Latitude = 41.3833, Longitude = 2.1833 },
                        new Stop() { Name = "Lyon, France", Arrival = new DateTime(2016, 12, 20), Order = 4, Latitude = 45.7600, Longitude = 4.8400 },
                        new Stop() { Name = "Prague, Czech Republic", Arrival = new DateTime(2016, 12, 22), Order = 5, Latitude = 50.0833, Longitude = 14.4167 },
                        new Stop() { Name = "New York, NY", Arrival = new DateTime(2016, 1, 5), Order = 1, Latitude = 40.7127, Longitude = -74.0059 },
                        new Stop() { Name = "Fort Lauderdale, FL", Arrival = new DateTime(2016, 1, 7), Order = 0, Latitude = 26.1333, Longitude = -80.1500 },
                    }
                };

                _context.Trips.Add(worldTrip);
                _context.Stops.AddRange(worldTrip.Stops);

                _context.SaveChanges();
            }
        }
    }
}
