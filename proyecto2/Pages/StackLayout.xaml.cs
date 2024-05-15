namespace proyecto2.Pages;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}
    async void OnButtonClicked(object sender, EventArgs args)
    {
        Navigation.PushAsync(new Pages.FlexLayout());
    }
}