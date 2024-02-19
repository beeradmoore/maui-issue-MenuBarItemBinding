using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MenuBarItemBindingIssue;

public partial class MainPageModel : ObservableObject
{
	[RelayCommand]
	void MenuItemClicked()
	{
		Debug.WriteLine("FooBar hit");
		Debugger.Break();
	}
}