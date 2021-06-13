using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeleProducts.Models;

namespace TeleProducts.Services
{
    interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
