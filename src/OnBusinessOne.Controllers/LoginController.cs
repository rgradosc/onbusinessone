using OnBusinessOne.Domain.Entities;
using OnBusinessOne.Service;
using System.Threading.Tasks;

namespace OnBusinessOne.Controllers
{
    public class LoginController
    {
        private Company _company;
        
        private readonly LoginService _loginService;
        
        private const string Company = "SBODemoGT";
        private const string UserName = "manager";
        private const string Password = "manager";

        public LoginController()
        {
            _loginService = new LoginService();
        }

        public async Task<Company> AuthenticateAsync()
        {
            _company = await _loginService.LoginAsync(new Login
            {
                CompanyDB = Company,
                Password = UserName,
                UserName = Password,
            });
            return _company;
        }

        public async Task LogoutAsync()
        {
            await _loginService.LogoutAsync(_company);
        }

    }
}
