using System;
using System.Collections.Generic;

namespace ParserAnalyzing.Model
{
    class Domain
    {
        public string domain { get; set; }
        public DateTime? create_date { get; set; }
        public DateTime? update_date { get; set; }
        public string country { get; set; }
        public string isDead { get; set; }
        public List<string> A { get; set; }
        public List<string> NS { get; set; }
        public List<string> CNAME { get; set; }
        public List<MX> MX { get; set; }
        public List<string> TXT { get; set; }
    }
}
