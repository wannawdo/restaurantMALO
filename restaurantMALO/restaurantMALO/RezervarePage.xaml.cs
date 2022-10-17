using System.Text.RegularExpressions;

namespace restaurantMALO;

public partial class RezervarePage : ContentPage
{
	public RezervarePage()
	{
		InitializeComponent();
	}

	private void txtEmailId_TextChanged(object sender, TextChangedEventArgs e)
	{
        bool result = ValidatorExtensions.IsValidEmailAddress(txtEmailId.Text);
    }
}