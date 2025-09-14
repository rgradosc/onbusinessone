using OnBusinessOne.Domain.Entities;
using OnBusinessOne.Service.Models;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace OnBusinessOne.Service
{
    public class LoginService : BaseService
    {
        public async Task<Company> LoginAsync(Login login)
        {
            var response = await RequestAsync(new BaseServiceRequest<Login>
            {
                Body = login,
                Company = new Company(),
                Method = Method.Post,
                Resource = "Login",
            });

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return new Company
                {
                    InSession = true,
                    RouteId = response.Cookies[1].Value,
                    SessionId = response.Cookies[0].Value,
                };
            }

            return null;
        }

        public async Task LogoutAsync(Company company)
        {
            await RequestAsync(new BaseServiceRequest<Logout>
            {
                Body = new Logout { IsNull = true },
                Company = company,
                Method = Method.Post,
                Resource = "Logout",
            });
        }
    }
}
