using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Snackbarbug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

        var snackbarOptions = new SnackbarOptions
        {
            BackgroundColor = Color.FromArgb("#D5092E"),
            TextColor = Color.FromArgb("#FFFFFF"),
            ActionButtonTextColor = Color.FromArgb("#FFFFFF"),
            CornerRadius = new CornerRadius(20),
            Font = Microsoft.Maui.Font.SystemFontOfSize(16),
            ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(16),
            CharacterSpacing = 0
        };

        TimeSpan duration = TimeSpan.FromSeconds(10);

        var snackbar = Snackbar.Make($"Text should be in white(#FFFFFF) colour.", null, "Ok", duration, snackbarOptions);

        await snackbar.Show(default);
    }
}


