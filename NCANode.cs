using System.Text.Json;
using System.Threading.Tasks;
using NCANode.Models.NCANode.Requests;
using NCANode.Models.NCANode.Responses;
using RestSharp;

// ReSharper disable InconsistentNaming

namespace NCANode
{
    /// <summary>
    /// Class that allows to interact with NCANode API
    /// </summary>
    public class NCANode
    {
        private readonly RestClient _client;

        /// <summary>
        /// NCANode object constructor
        /// </summary>
        /// <param name="host">API host</param>
        /// <param name="port">API port</param>
        public NCANode(string host, int port)
        {
            _client = new RestClient($"http://{host}:{port}/");
        }


        /// <summary>
        /// Get general information about sign 
        /// </summary>
        /// <param name="pkcs12InfoRequest">Request data</param>
        /// <returns>PKCS12.info object</returns>
        public async Task<PKCS12InfoResponse> GetPKCS12Info(PKCS12InfoRequest pkcs12InfoRequest)
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json",
                JsonSerializer.Serialize(pkcs12InfoRequest)
                , ParameterType.RequestBody);
            var response = await _client.ExecuteAsync(request);
            return JsonSerializer.Deserialize<PKCS12InfoResponse>(response.Content);
        }
    }
}