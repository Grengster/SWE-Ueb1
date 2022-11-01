
namespace SWE
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public DateTime DateHistory { get; set; }


        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public int TemperatureHistoryC { get; set; }

        public string? Summary { get; set; }
    }
}