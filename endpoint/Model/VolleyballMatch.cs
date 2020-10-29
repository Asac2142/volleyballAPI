using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace endpoint.Model
{
    public class VolleyballMatch
    {
        public string Team1 { get; set; }

        public string Team2 { get; set; }

        public string[] score { get; set; }

        public Accountant accountant { get; set; }
    }
}
