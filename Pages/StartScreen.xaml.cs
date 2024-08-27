using WeatherApp.Model;

namespace WeatherApp.Pages;

public partial class StartScreen : ContentPage
{
    public StartScreen()
    {
        InitializeComponent();

        initView();
    }

    private void initView()
    {
        collectionViewDayWeather.ItemsSource = GetWetherList();
    }

    private List<Weather> GetWetherList() => new List<Weather>()
        {
            new Weather("27", "Weather1"),
            new Weather("30", "Weather2"),
            new Weather("27", "Weather3")
        };

    private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {

    }
}
