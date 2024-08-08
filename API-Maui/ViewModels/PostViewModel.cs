using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Maui.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace API_Maui.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Post>? posts;

        public void getPosts()
        {

        }
    }
}
