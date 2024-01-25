using RestSharp;
using System.Text.Json;

RestClient OwnClient = new ("https://digi-api.com/api/v1/");

string digimonName = "Culumon";
RestRequest request = new ($"digimon/{digimonName}");

RestResponse response = OwnClient.GetAsync(request).Result;

Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);

Console.WriteLine(d.Name);
File.WriteAllText("digimon.json", response.Content);

Console.ReadLine();

