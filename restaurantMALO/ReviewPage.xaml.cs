using Newtonsoft.Json.Linq;

namespace restaurantMALO;

public partial class ReviewPage : ContentPage
{
	List<Recenzie> listaRecenzii = new List<Recenzie>();
	public ReviewPage()
	{
		InitializeComponent();
		GetJsonAsync();
	}
	public async Task GetJsonAsync()
	{
		var uri = new Uri("https://www.jsonkeeper.com/b/3EIT");
		HttpClient httpClient = new HttpClient();
		var response = await httpClient.GetAsync(uri);
		if(response.IsSuccessStatusCode)
		{
			var content = await response.Content.ReadAsStringAsync();
			string json = content.ToString();
			var jsonObject = JObject.Parse(json);
			var data = jsonObject["data"];
			var jsonArray = JArray.Parse(data.ToString());
			foreach(var token in jsonArray)
			{
				Recenzie recenzie = new Recenzie();
				string id = token["id"].ToString();
				string nume = token["nume"].ToString();
				string comentariu = token["comentariu"].ToString();
				string nota = token["nota"].ToString();
				recenzie.Id = id;
				recenzie.Nume = nume;
				recenzie.Comentariu = comentariu;
				recenzie.Nota = int.Parse(nota);
				listaRecenzii.Add(recenzie);
			}
		}
		recenziiListView.ItemsSource = listaRecenzii;

	}
}