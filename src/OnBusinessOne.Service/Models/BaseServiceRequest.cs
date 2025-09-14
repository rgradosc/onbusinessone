using OnBusinessOne.Domain.Entities;
using RestSharp;

namespace OnBusinessOne.Service.Models
{
    public class BaseServiceRequest<T>
    {
        private const string baseUrl = "https://127.0.0.1:50000/b1s/v1/";

        public T Body { get; set; }

        public string BaseUrl { get { return baseUrl; } }

        public string Resource { get; set; }

        public Company Company { get; set; }

        public Method Method { get; set; }
    }
}
