// <T> La clase queda deserializable
//Serializar: Coger todas las propiedades que estan independientes por un formulario y únelas, envíalas a la base de datos
//Deserializalas porque en la base de datos estan independientes, y en algun momento tengo que volverlas a unir para ponerlas en un JSON o volverlas a segmentar para traerlas a un JSON


using System.Net.Http;
namespace proyFinal_g63.Client.Services
{
    public class HttpResponseWrapper<T> 
    {
            public bool Error {get;set;}
            public T Response{get;set;}
            public HttpResponseMessage HttpResponseMessage{get;set;}


        public HttpResponseWrapper(T response, bool error, HttpResponseMessage httpResponseMessage){
            //Estos parametros llegan desde las interfaces:
            Error=error;
            Response=response;
            HttpResponseMessage=httpResponseMessage;

        }

    }
}
