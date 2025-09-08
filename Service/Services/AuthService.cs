using Microsoft.Extensions.Configuration;
using Service.DTOs;
using Service.Interfaces;
using Service.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class Authservice : IAuthService
    {
        private readonly IConfiguration _configuration;
        public Authservice(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<string?> Login(LoginDTO? login)
        {
            if (login == null)
            {
                throw new ArgumentException("El objeto login no llegó.");
            }
            try
            {
                var UrlApi = _configuration["UrlApi"];
                var endpointAuth = ApiEndpoints.GetEndpoint("Login");
                var client = new HttpClient();
                var response = await client.PostAsJsonAsync($"{UrlApi}{endpointAuth}/login/",login);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al loguearse:" + ex.Message);
            }
        }
    }
}
