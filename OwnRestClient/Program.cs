using RestSharp;
using System.Text.Json;

RestClient OwnClient = new RestClient("https://digi-api.com/api/v1/");
string digiName = "Culumon";
RestRequest request = new ($"digimon/{digiName}");

RestResponse response = OwnClient.GetAsync(request).Result;

Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);

Console.WriteLine(d.Name);

Console.ReadLine();

