namespace restaurantMALO;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();
	}
	public async void TapGesture_Recognizer_Tapped(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new LocatiiPage());
	}
}