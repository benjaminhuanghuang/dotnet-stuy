using MauiBeginner.ViewModel;

namespace MauiBeginner;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}

