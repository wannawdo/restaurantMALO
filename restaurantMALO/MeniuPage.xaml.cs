namespace restaurantMALO;

public partial class MeniuPage : ContentPage
{
    List<Menu> listaMeniu = new List<Menu>();
    public MeniuPage()
    {
        InitializeComponent();

    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listaMeniu = await ServiciuMeniu.PreiaCurs();
        listViewMeniu.ItemsSource = listaMeniu;

    }
}