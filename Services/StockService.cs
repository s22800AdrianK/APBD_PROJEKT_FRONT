using ProjektFront.Models;
using ProjektFront.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProjektFront.Services
{
    public class StockService : IStockService
    {
        private readonly HttpClient http;
        private readonly ILocalStorageService _localStorageService;
        private readonly IAccountService _accountService;

        public StockService(ILocalStorageService localStorageService, IAccountService accountService)
        {
            _localStorageService = localStorageService;
            http = new HttpClient();
            http.BaseAddress = new Uri("https://localhost:5001/api/");
            _accountService = accountService;
        }

        public async Task<List<CompanyDetailed>> GetWatchList(int idUser)
        {
            addAuth();
            var res = await http.GetAsync($"Stock/company/watched?idUser={idUser}");
            if (await RequestHandler(res)) res = await http.GetAsync($"Stock/company/watched?idUser={idUser}");
            return await res.Content.ReadFromJsonAsync<List<CompanyDetailed>>();
        }



        public async Task<CompanyDetailed> GetCompany(string ticker)
        {
            addAuth();
            var res = await http.GetAsync($"Stock/company?ticker={ticker}");
            if (await RequestHandler(res)) res = await http.GetAsync($"Stock/company?ticker={ticker}");
            return await res.Content.ReadFromJsonAsync<CompanyDetailed>();
        }

        private static DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        public async Task<List<OHLC>> GetOHLC(string ticker, DateTime from, DateTime to, string timespan = "day")
        {
            var toS = to.ToString("yyyy-MM-dd");
            var fromS = from.ToString("yyyy-MM-dd");
            addAuth();
            var res = await http.GetAsync($"Stock/OHLCs?ticker={ticker}&from={fromS}&to={toS}&timespan={timespan}");
            if (await RequestHandler(res)) res = await http.GetAsync($"Stock/OHLCs?ticker={ticker}&from={fromS}&to={toS}&timespan={timespan}");
            return await res.Content.ReadFromJsonAsync<List<OHLC>>();
        }

        public List<ChartData> ToChartData(List<OHLC> oHLCs)
        {
            return oHLCs.Select(e => new ChartData
            {
                Volume = e.v,
                Close = e.c,
                High = e.h,
                Low = e.l,
                Open = e.o,
                Date = UnixTimeStampToDateTime(e.t)
            }).ToList();
        }

        public async Task AddToWatchlist(int IdUser, string ticker)
        {
            addAuth();
            var res = await http.PostAsJsonAsync($"Stock/company/watched?idUser={IdUser}&ticker={ticker}", new { ticker});
            if (await RequestHandler(res)) res = await http.PostAsJsonAsync($"Stock/company/watched?idUser={IdUser}&ticker={ticker}", new { ticker});
        }

        public async Task<List<Company>> GetCompanies(string regex)
        {
            addAuth();
            var res = await http.GetAsync($"Stock/company/regex?regex={regex}");
            if(await RequestHandler(res)) res = await http.GetAsync($"Stock/company/regex?regex={regex}");
            return await res.Content.ReadFromJsonAsync<List<Company>>();
        }

        public async Task Delete(int IdUser, string ticker)
        {
            addAuth();
            var res = await http.DeleteAsync($"Stock/company/watched?ticker={ticker}&idUser={IdUser}");
            if (await RequestHandler(res)) res = await http.DeleteAsync($"Stock/company/watched?ticker={ticker}&idUser={IdUser}");
        }

        private async Task<bool> RequestHandler(HttpResponseMessage message)
        {
            if(message.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                await _accountService.RefreashToken();
                addAuth();
                return true;
            }
            return false;
        }

        private void addAuth()
        {
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accountService.User.token);
        }
    }
}
