using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model;

public class Weather
{
    public string? Temperature { get; set; }
    public string? Time { get; set; }

    public Weather(string temperature, string time)
    {
        Temperature = temperature;
        Time = time;
    }
}
