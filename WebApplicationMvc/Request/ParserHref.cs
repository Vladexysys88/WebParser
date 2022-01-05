using ParserAnalyzing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplicationMvc.Request
{
    public class ParserHref
    {
        private static List<string> _urls;
        public List<ViewTable> DataTable { get; set; }
        public ParserHref()
        {
            _urls = new List<string>();
            DataTable = new List<ViewTable>();
        }
        
        private static async Task GetUrlsAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var response = await result.Content.ReadAsStringAsync();
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(response);
                HtmlAgilityPack.HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//a/@href");
                foreach (var item in nodes)
                {
                    _urls.Add(item.GetAttributeValue("href", null));
                }
            }
        }

        public async Task GetDataAsync(string url)
        {
            await GetUrlsAsync(url);
            using (var client = new HttpClient())
            {
                try
                {
                    for (int k = 0; k < _urls.Count; k++)
                    {
                        var result = await client.GetAsync($"https://api.domainsdb.info/v1/domains/search?domain={_urls[k]}");
                        var response = await result.Content.ReadAsStringAsync();
                        var finalData = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(response);

                        if (finalData.domains == null)
                            return;

                        for (var i = 0; i < finalData.domains.Count; i++)
                        {
                            DataTable.Add(new ViewTable
                            {
                                A = finalData.domains[i].A,
                                CNAME = finalData.domains[i].CNAME,
                                country = finalData.domains[i].country,
                                create_date = finalData.domains[i].create_date,
                                domain = finalData.domains[i].domain,
                                isDead = finalData.domains[i].isDead,
                                MX = finalData.domains[i].MX,
                                NS = finalData.domains[i].NS,
                                TXT = finalData.domains[i].TXT,
                                update_date = finalData.domains[i].update_date,
                            });
                        }
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
