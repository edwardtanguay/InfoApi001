using System.Text;

namespace InfoApi001.Classes
{
    public class InfoManager
    {
        public WeatherForecast GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("one");
            sb.Append(", two");
            sb.Append(".");
            return new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                TemperatureC = 34,
                Summary = sb.ToString(),
            };

        }
    }
}
