using Mopups.Services;

namespace MauiMopupsSample;

public partial class MyPopupPage
{
	public MyPopupPage()
	{
		InitializeComponent();
	}

    private void LoginButton_Clicked(object sender, EventArgs e)
    {
		MopupService.Instance.PopAsync();
    }
}