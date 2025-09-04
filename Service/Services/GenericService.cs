using Service.Interfaces;
using Service.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        //El cliente http nos permite hacer peticiones http a una api, como get, post, put, delete.
        //Lo puede instanciar directamente o recibirlo por inyeccion de dependencia.
        private readonly HttpClient _httpClient;
        //Esto es para serializar y deserializar objetos json. Nos permite convertir objetos a json y viceversa. 
        protected readonly JsonSerializerOptions _options;
        //Los generic service necesitan impactar sobre un endpoint. Es un punto de entrada de nuestra api. 
        protected readonly string _endpoint;

        public GenericService(HttpClient? httpClient = null)
        {
            //Esto es un operador de fusión nula. Si httpClient es null, se crea una nueva instancia de HttpClient. El operador ?? verifica si el operando de la izquierda es null; si lo es, devuelve el operando de la derecha.
            _httpClient = httpClient?? new HttpClient();
            //Esto es para que no importe si las propiedades del json vienen en mayuscula o minuscula.  
            _options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            _endpoint = Properties.Resources.UrlApiLocal+ApiEndpoints.GetEndpoint(typeof(T).Name);
        }
        public Task<T?> AddAsync(T? entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>?> GetAllAsync(string? filtro = "")
        {
           var response= await _httpClient.GetAsync($"{_endpoint}?filtro={filtro}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<T>>(content, _options);
               
            }
            else
            {
                throw new Exception("Error al obtener los datos");
            }
        }

        public Task<List<T>?> GetAllDeletedsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RestoreAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T? entity)
        {
            throw new NotImplementedException();
        }
    }
}
