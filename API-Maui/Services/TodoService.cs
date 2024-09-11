using API_Maui.Models;
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
    public class TodoService
    {
        private HttpClient? httpClient;
        private Todo? todo;
        private ObservableCollection<Todo>? todos;
        private JsonSerializerOptions? jsonSerializerOptions;

        public TodoService()
        {
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            httpClient = new();
        }

        public async Task<ObservableCollection<Todo>> getTodos()
        {

            Uri uri = new Uri("https://jsonplaceholder.typicode.com/todos");
            ObservableCollection<Todo> items = new();

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    items = JsonSerializer.Deserialize<ObservableCollection<Todo>>(content, jsonSerializerOptions);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

            }
            return items;
        }
    }
}
