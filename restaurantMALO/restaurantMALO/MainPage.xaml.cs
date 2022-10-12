namespace restaurantMALO;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnMenuClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MeniuPage());

    }
    private void DespreToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DesprePage());
    }
    private void ContactToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ContactPage());
    }

    private void LocatiiToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LocatiiPage());
    }
    private void NotaToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NotaPage());
    }
    private void ReviewToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ReviewPage());
    }
    private void GraficToolbarItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ChartPage());
    }

}

