using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using API_Maui.Models;
using API_Maui.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace API_Maui.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Post>? posts;

        private ICommand getPostsCommand { get; }

        public PostViewModel()
        {
            getPostsCommand = new Command(getPosts);
        }

        public async void getPosts()
        {
            PostService postService = new();
            posts = await postService.getPosts();
        }
    }
}
