using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RabbitMQ.Models.Processors
{
    public class WebRequestProcessor
    {
        public async Task<string> WebRequestGet(string url)
        {
            var httpClient = new HttpClient();
            var _UserAgent = "HttpClient";
            // You can actually also set the User-Agent via a built-in property
            httpClient.DefaultRequestHeaders.Add("User-Agent", _UserAgent);
            var response = await httpClient.GetAsync(new Uri(url));

            var jsonResponse = await response.Content.ReadAsStringAsync();

            return jsonResponse;
        }

        public async Task<bool> WebRequestPost(string url, string sJson)
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.PostAsync(new Uri(url), new StringContent(sJson, Encoding.UTF8, "application/json"));

                var content = await response.Content.ReadAsStringAsync();
                return Boolean.Parse(content); 
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
