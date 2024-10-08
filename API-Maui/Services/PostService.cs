﻿using API_Maui.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
        private ObservableCollection<Post>? posts;
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

        public async Task<ObservableCollection<Post>> getPosts() {

            Uri uri = new Uri("https://jsonplaceholder.typicode.com/posts");
            ObservableCollection<Post> items = new();

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonSerializer.Deserialize<ObservableCollection<Post>>(content, jsonSerializerOptions);
                }

            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
                
            }
            return items;
        }
    }
}
