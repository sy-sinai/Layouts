namespace proyecto2.Pages;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}


    async void OnButtonClicked(object sender, EventArgs args)
    {
        Navigation.PushAsync(new Pages.StackLayout());
    }
}