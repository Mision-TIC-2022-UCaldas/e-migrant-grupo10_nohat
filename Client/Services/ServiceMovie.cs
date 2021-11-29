using System;
using System.Text;
using System.Security.AccessControl;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using proyFinal_g63.Shared.Model;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace proyFinal_g63.Client.Services

{
    
    
    
    //Service Movie hereda de IServiceMovie
    public class ServiceMovie:IServiceMovie
    {
        private readonly HttpClient httpClient;
        public ServiceMovie(HttpClient httpClient){     //Es la peticion Post, get, delete etc
            this.httpClient = httpClient;
        }

            public async Task <HttpResponseWrapper<object>> Post<T>(string url,T send){
                var sendJSON = JsonSerializer.Serialize(send);
                var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
                var responseHttp = await httpClient.PostAsync(url, sendContent);
                return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
            }

        public List <Movie> GetMovies()
        {
            return new List<Movie>(){
                new Movie(){Id=1, Name="Pelicula 1"},
                new Movie(){Id=2, Name="Pelicula 2"},
                new Movie(){Id=3, Name="Pelicula 3"}


            };
        }
    }

}
