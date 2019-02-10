using RestSharp;
using System.Configuration;

namespace Logica
{
    public class RestHelper
    {
        private readonly RestClient _client;

        public RestHelper()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["UrlColegioApi"]);
        }

        /// <summary>
        /// Ejecuta un Método REST de un API usando como parametros de entrada y salida los valores de <typeparamref name="TRequest"/>
        /// y <typeparamref name="TResponse"/>
        /// </summary>
        /// <param name="metodo">Nombre del Método</param>
        /// <param name="request">Instancia de la clase <typeparamref name="TRequest"/></param>
        /// <param name="verbo">Verbo HTTP (POST es por default)</param>
        /// <returns>Una instancia de <typeparamref name="TResponse"/></returns>
        public TResponse Execute<TRequest, TResponse>(string metodo, TRequest request, Method verbo = Method.POST)
            where TRequest : class
            where TResponse : class, new()
        {

            var restRequest = new RestRequest(metodo, verbo)
            {
                RequestFormat = DataFormat.Json
            };

            restRequest.AddJsonBody(request);

            var restResponse = _client.Execute<TResponse>(restRequest);
            return restResponse.Data;
        }

    }
}