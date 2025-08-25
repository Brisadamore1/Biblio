using Microsoft.Extensions.Configuration;
using Service.Services;
using System.Text;
using System.Text.Json;
using Xunit;

namespace Test
{
    public class UnitTestGemini
    {
        [Fact]
        public async Task TestObtenerResumenLibroIA()
        {
            //leemos la clave de la api desde appsettings.json 
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

            var apiKey = "AIzaSyBsfwgSlt6kyBtRYHOPByWIVZBEjmVC_Lw";
            var url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key= " + apiKey;

            var prompt = $"Me puedes dar un resumen de 200 palabras como máximo de deja de ser tu de joe dispenza";

            var payload = new
            {
                contents = new[]
                {
                new
                {
                    parts = new[]
                    {
                        new { text = prompt }
                    }
                }
            }
            };

            var json = JsonSerializer.Serialize(payload);
            using var client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            var result = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(result);
            var texto = doc.RootElement
                .GetProperty("candidates")[0]
                .GetProperty("content")
                .GetProperty("parts")[0]
                .GetProperty("text")
                .GetString();

            Console.WriteLine($"Respuesta de IA: {texto}");
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task TestServiceGeminiGetPrompt()
        {
            //leemos la api key desde appsettings.json
            var configuration = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                  .AddEnvironmentVariables()
                  .Build();
            var prompt = $"Me puedes dar un resumen de 100 palabras como máximo del libro el duelo de gabriel rolon ";
            var servicio = new GeminiService(configuration);
            var resultado = await servicio.GetPrompt(prompt);
            Console.WriteLine($"Respuesta de IA desde servicio: {resultado}");
            Assert.NotNull(resultado);
        }
    }
}
