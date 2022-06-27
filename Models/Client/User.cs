using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektFront.Models.Client
{
    public class User
    {

        public int id { get; set; }
        public string token { get; set; }
        public string refreshToken { get; set; }

    }
}
