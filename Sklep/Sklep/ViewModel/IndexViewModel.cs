using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.ViewModel
{
    public class IndexViewModel
    {
        public Category Category { get; set; }

        public IEnumerable<Film> FilmsFromCategory { get; set; }

        public IEnumerable<Film> Top3NewestFilms { get; set; }

        public IEnumerable<Film> Top3LongestFilms { get; set; }
    }
}