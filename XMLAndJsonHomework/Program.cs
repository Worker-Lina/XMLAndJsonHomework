using System;
using WeatherJson;

namespace XMLAndJsonHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Request request = new Request
            {
                 Type = "City",
                 Query = "Astana, Kazakhstan",
                 Language = "en",
                 Unit = "m"
            };

            Location location = new Location
            {
                Name = "Astana",
                Country = "Kazakhstan",
                Region = "Astana",
                Lat = 51.181,
                Lon = 71.428,
                TimezoneId = "Asia/Almaty",
                Localtime = DateTime.Now,
                LocaltimeEpoch = "1613423040",
                UtcOffset = 6.0
            };
        }
    }
}
