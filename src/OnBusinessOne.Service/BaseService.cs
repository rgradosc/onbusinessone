using OnBusinessOne.Service.Models;
using RestSharp;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace OnBusinessOne.Service
{
    public class BaseService
    {
        public async Task<RestResponse> RequestAsync<T>(BaseServiceRequest<T> baseRequest) 
        {
            var options = new RestClientOptions(baseRequest.BaseUrl + baseRequest.Resource)
            {
                RemoteCertificateValidationCallback = (sender, certificate, chain, SslPolicyErrors) => true
            };
            var client = new RestClient(options);

            var request = new RestRequest(baseRequest.Resource, baseRequest.Method);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/xml");

            CookieContainer cookieContainer = new CookieContainer();
            if (baseRequest.Company != null && baseRequest.Company.SessionId != null)
            {
                cookieContainer.Add(new Cookie
                {
                    Name = "B1SESSION",
                    Value = baseRequest.Company.SessionId
                });
            }

            if (baseRequest.Company != null && baseRequest.Company.RouteId != null)
            {
                cookieContainer.Add(new Cookie
                {
                    Name = "ROUTEID",
                    Value = baseRequest.Company.RouteId
                });
            }

            if (baseRequest.Body != null)
            {
                string bodyJson = JsonSerializer.Serialize(baseRequest.Body);
                request.AddBody(bodyJson);
            }

            if (cookieContainer.Count > 0)
            {
                request.CookieContainer = cookieContainer;
            }

            RestResponse response = await client.ExecuteAsync(request);
            return response;
        }
    }
}
