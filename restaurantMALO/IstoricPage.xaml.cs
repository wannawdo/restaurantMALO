namespace restaurantMALO;

public partial class IstoricPage : ContentPage
{
    List<Rezervare> listaRezervare = new List<Rezervare>();
    DaoRezervare daoRezervare = new DaoRezervare();
    public IstoricPage()
    {
        InitializeComponent();
        listaRezervare = daoRezervare.ObtineToateInregistrarile();

        System.Diagnostics.Debug.WriteLine(listaRezervare[0].Nume.ToString());
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        listViewRezervari.ItemsSource = listaRezervare;
    }
}