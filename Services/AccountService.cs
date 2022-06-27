using Microsoft.AspNetCore.Components;
using ProjektFront.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjektFront.Services
{
    public class AccountService : IAccountService
    {
        private readonly NavigationManager _navigationManager;
        private readonly ILocalStorageService _localStorageService;
        private string _userKey = "user";
        private readonly HttpClient http;
        public User User { get; private set; }
        public AccountService(NavigationManager navigationManager,ILocalStorageService localStorageService)
        {
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
            http = new HttpClient();
            http.BaseAddress = new Uri("https://localhost:5001/api/");
        }
        public async Task Initialize()
        {
            User = await _localStorageService.GetItem<User>(_userKey);
        }
        public async Task Login(Login model)
        {
            var res = await http.PostAsJsonAsync("Client/login", model);
            if (res.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await res.Content.ReadAsStringAsync());
            User = await res.Content.ReadFromJsonAsync<User>();
            Console.WriteLine(User.refreshToken);
            await _localStorageService.SetItem(_userKey, User);
        }

        public async Task Logout()
        {
            User = null;
            await _localStorageService.RemoveItem(_userKey);
            _navigationManager.NavigateTo("user/login");
        }

        public async Task Register(AddClient model)
        {
           var res = await http.PostAsJsonAsync("Client/register", model);
           if (res.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await res.Content.ReadAsStringAsync());
        }

        public async Task RefreashToken()
        {
            var u = await _localStorageService.GetItem<User>(_userKey);
            try
            {
                var model = new Refreash();
                model.token = u.refreshToken;
                var res = await http.PostAsJsonAsync("Client/refreash",model);
                User = await res.Content.ReadFromJsonAsync<User>();
                await _localStorageService.SetItem(_userKey, u);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                await Logout();
                _navigationManager.NavigateTo("user/login");
            }
        }
    }
}
