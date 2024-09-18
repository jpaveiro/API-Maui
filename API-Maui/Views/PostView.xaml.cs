using API_Maui.ViewModels;

namespace API_Maui.Views;

public partial class PostView : ContentPage
{
	public PostView()
	{
		InitializeComponent();
		BindingContext = new PostViewModel();
	}
}