using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model;

class DayOfWeekWeather
{
    public string? DayOfWeek { get; set; }

    public string? Temperature { get; set; }

    public string? Humidity { get; set; }

    public string? WindSpeed { get; set; }

    public DayOfWeekWeather(string dayOfWeek, string temperature, string humidity, string windSpeed)
    { 
        DayOfWeek = dayOfWeek;

        Temperature = temperature;

        Humidity = humidity;

        WindSpeed = windSpeed;
    }


}
