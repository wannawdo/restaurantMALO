using System.Text.RegularExpressions;

namespace restaurantMALO;

public partial class RezervarePage : ContentPage
{
    List<Rezervare> listaRezervare = new List<Rezervare>();
    DaoRezervare daoRezervare = new DaoRezervare();

    public RezervarePage()
	{
		InitializeComponent();
	}

	private void txtEmailId_TextChanged(object sender, TextChangedEventArgs e)
	{
        bool result = ValidatorExtensions.IsValidEmailAddress(txtEmailId.Text);
    }

	private void adaugaRezervare_Clicked(object sender, EventArgs e)
	{
		
		Rezervare rezervare = new Rezervare()
		{
			Data = DateTime.Now,
			Ora = "23:00",
			NrOaspeti = "4",
			Zona = "parter",
			Nume = txtNameId.Text,
			Prenume = txtPrenumeId.Text,
			Email = txtEmailId.Text,
			Observatii = txtObservatiiId.Text

		};
		listaRezervare.Add(rezervare);
		daoRezervare.AdaugaListaRezervare(listaRezervare);
        

    }
}