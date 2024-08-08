using API_Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API_Maui.Services
{
    public class PostService
    {
        private HttpClient? httpClient;
        private Post? post;
        private List<Post>? posts;
        private JsonSerializerOptions? jsonSerializerOptions;

        public PostService()
        {
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            httpClient = new();
        }

    }
}
