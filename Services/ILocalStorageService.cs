using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektFront.Services
{
    public interface ILocalStorageService
    {
        public Task<T> GetItem<T>(string key);
        public Task SetItem<T>(string key, T value);
        public Task RemoveItem(string key);
    }
}
