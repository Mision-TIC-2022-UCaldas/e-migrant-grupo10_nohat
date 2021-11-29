using proyFinal_g63.Shared.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace proyFinal_g63.Client.Services
{
    public interface IServiceMovie{
        
        List<Movie> GetMovies();
        Task <HttpResponseWrapper<object>>Post<T>(string url,T send);

    }
}