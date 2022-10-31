using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;
namespace dotnet_rpg.Data
{
    public interface IAuthRepository
    {
        public Task<ServiceResponse<string>> Login(string username, string password);
        public Task<ServiceResponse<string>> Register(User user, string password);
        public Task<bool> UserExists(string username);



    }
}