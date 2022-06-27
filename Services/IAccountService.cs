using ProjektFront.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektFront.Services
{
    public interface IAccountService
    {
        public User User { get; }
        public Task Login(Login model);
        public Task Logout();
        public Task Initialize();
        public Task Register(AddClient model);
        public Task RefreashToken();
    }
}
