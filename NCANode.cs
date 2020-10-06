using System;
using System.Text.Json;
using System.Threading.Tasks;
using NCANode.Models.NCANode.Requests;
using NCANode.Models.NCANode.Responses;
using RestSharp;

// ReSharper disable UnusedMember.Global
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
        public PKCS12InfoResponse GetPKCS12Info(PKCS12InfoRequest pkcs12InfoRequest) =>
            GetPKCS12InfoAsync(pkcs12InfoRequest).Result;

        /// <summary>
        /// Get general information about sign async
        /// </summary>
        /// <param name="pkcs12InfoRequest">Request data</param>
        /// <returns>PKCS12.info object</returns>
        public async Task<PKCS12InfoResponse> GetPKCS12InfoAsync(PKCS12InfoRequest pkcs12InfoRequest)
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json",
                JsonSerializer.Serialize(pkcs12InfoRequest)
                , ParameterType.RequestBody);
            var response = await _client.ExecuteAsync(request);
            try
            {
                return JsonSerializer.Deserialize<PKCS12InfoResponse>(response.Content);
            }
            catch (Exception)
            {
                throw new JsonException($"Cannot deserialize: '{response.Content}'");
            }
        }

        /// <summary>
        /// Sign XML
        /// </summary>
        /// <param name="xmlSignRequest">Request data to sign</param>
        /// <returns>XML.sign object</returns>
        public XMLSignResponse SignXML(XMLSignRequest xmlSignRequest) => SignXMLAsync(xmlSignRequest).Result;

        /// <summary>
        /// Sign XML async
        /// </summary>
        /// <param name="xmlSignRequest">Request data to sign</param>
        /// <returns>XML.sign object</returns>
        public async Task<XMLSignResponse> SignXMLAsync(XMLSignRequest xmlSignRequest)
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json",
                JsonSerializer.Serialize(xmlSignRequest)
                , ParameterType.RequestBody);
            var response = await _client.ExecuteAsync(request);
            try
            {
                return JsonSerializer.Deserialize<XMLSignResponse>(response.Content);
            }
            catch (Exception)
            {
                throw new JsonException($"Cannot deserialize: '{response.Content}'");
            }
        }
    }
}