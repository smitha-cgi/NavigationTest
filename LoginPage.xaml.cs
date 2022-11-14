namespace NavigationTest;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void ButtonClicked(object sender, EventArgs e)
	{
        MainPage page = new();

        if (Application.Current != null)
        {
            Application.Current.MainPage = page;
        }
    }
}

