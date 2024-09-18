using API_Maui.ViewModels;

namespace API_Maui.Views;

public partial class TodoView : ContentPage
{
	public TodoView()
	{
		InitializeComponent();
        BindingContext = new TodoViewModel();
    }
}