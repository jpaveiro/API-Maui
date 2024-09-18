using API_Maui.Models;
using API_Maui.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace API_Maui.ViewModels
{
    public partial class TodoViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Todo>? todos;

        public ICommand getTodosCommand { get; }

        public TodoViewModel()
        {
            getTodosCommand = new Command(getTodos);
        }

        public async void getTodos()
        {
            TodoService todoService = new();
            Todos = await todoService.getTodos();
        }
    }
}
