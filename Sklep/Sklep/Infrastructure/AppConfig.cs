using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Sklep.Infrastructure
{
    public class AppConfig
    {
        private static string posterPath = ConfigurationManager.AppSettings["Posters"];

        public static string PosterPath { get => posterPath; set => posterPath = value; }
    }
}