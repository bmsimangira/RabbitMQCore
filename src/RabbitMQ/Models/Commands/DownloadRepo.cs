using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbitMQ.Models.Processors;

namespace RabbitMQ.Models.Commands
{
    public class DownloadRepo : ICommand
    {
        private string _urlToPost = "http://localhost:57723/";
        private string _urlToDownloadFrom = "https://api.github.com/orgs/gopangea/repos";

        public DownloadRepo(string baseUrlToPost)
        {
            _urlToPost = baseUrlToPost + "Repositories";
        }

        public async Task<bool> Execute()
        {
            var result = await RetrieveRepositories(_urlToDownloadFrom);
            var status = await PostRepositories(_urlToPost, result);
            return status;
        }

        private async Task<string> RetrieveRepositories(string url)
        {
            var requestProecessor = new WebRequestProcessor();
            var jsonResponse = await requestProecessor.WebRequestGet(url);

            return jsonResponse;
        }

        private async Task<bool> PostRepositories(string url, string json)
        {
            var requestProecessor = new WebRequestProcessor();
            var result = await requestProecessor.WebRequestPost(url, json);

            return result;
        }
    }
}
