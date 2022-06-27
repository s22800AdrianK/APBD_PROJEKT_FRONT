using ProjektFront.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektFront.Services
{
    public interface IStockService
    {
        public Task<List<CompanyDetailed>> GetWatchList(int idUser);
        public Task<CompanyDetailed> GetCompany(string ticker);
        public Task<List<OHLC>> GetOHLC(string ticker, DateTime from, DateTime to, string timespan);
        public Task<List<Company>> GetCompanies(string regex);
        public List<ChartData> ToChartData(List<OHLC> oHLCs);
        public Task AddToWatchlist(int IdUser, string ticker);
        public Task Delete(int IdUser, string ticker);
    }

}
