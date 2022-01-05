using System.Collections.Generic;

namespace ParserAnalyzing.Model
{
    class DataTable
    {
        public int? total { get; set; }
        public string time { get; set; }
        public string next_page { get; set; }
        public List<Domain> domains { get; set; }
    }
}
