using System.Diagnostics;

namespace MenuBarItemBindingIssue;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageModel();
		
		// Workaround number 2
		foreach (var menuBarItem in MenuBarItems)
		{
			Debug.WriteLine($"MenuBarItem {menuBarItem.Text} BindingContext = {menuBarItem.BindingContext}");
			
			if (menuBarItem.Text == "ViaCodeBehind")
			{
				menuBarItem.BindingContext = BindingContext;
			}
		}
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

