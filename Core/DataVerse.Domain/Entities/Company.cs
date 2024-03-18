using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVerse.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sector { get; set; }
        public DateTime FoundedDate { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public List<Founder> Founders { get; set; }
        public CompanyContact ContactInfo { get; set; }
        public string Website { get; set; }
    }
}
