using Mopups.Interfaces;

namespace MauiMopupsSample;

public partial class MainPage : ContentPage
{
	IPopupNavigation popupNavigation;

	public MainPage(IPopupNavigation popupNavigation)
	{
		InitializeComponent();

		this.popupNavigation = popupNavigation;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        popupNavigation.PushAsync(new MyPopupPage());
	}
}

