using WeatherApp.Model;

namespace WeatherApp.Pages;

public partial class WeekWeatherScreen : ContentPage
{
	public WeekWeatherScreen()
	{
		InitializeComponent();

		InitViews();

    }

	private void InitViews()
	{
		collectionViewWeekWeather.ItemsSource = GetListOfDayOfWeekWeather();
	}

	private List<DayOfWeekWeather> GetListOfDayOfWeekWeather() => new List<DayOfWeekWeather> { 
		new DayOfWeekWeather("Monday", "+16", "55%", "20km/h"),
		new DayOfWeekWeather("Tuesday", "+16", "55%", "20km/h"),
		new DayOfWeekWeather("Wednesday", "+16", "55%", "20km/h"),
		new DayOfWeekWeather("Thursday", "+16", "55%", "20km/h"),
		new DayOfWeekWeather("Friday", "+16", "55%", "20km/h"),
		new DayOfWeekWeather("Saturday", "+16", "55%", "20km/h"),
		new DayOfWeekWeather("Sunday", "+16", "55%", "20km/h"),
	};
}