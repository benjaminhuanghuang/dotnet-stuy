using MauiBegineer.ViewModel;

namespace MauiBeginner;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
    }
}