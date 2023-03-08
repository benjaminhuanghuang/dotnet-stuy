# .NET MAUI Data Binding with MVVM & XAML [5 of 8] | .NET MAUI for Beginners
https://www.youtube.com/watch?v=5Qga2pniN78&list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY&index=6

MVVM is a way for your interface to response to your code behind and vice versa.

The view just knows how to display data, 

The code behind represent what to display

The binding system inside MAUI enabling UI to automatically update the code behind and vice versa.


Install package CommunityToolkit.Mvvm

Create model
```
    using CommunityToolkit.Mvvm.ComponentModel;

    public partial class MainViewModel : ObservableObject {
        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;


        [RelayCommand]
        async Task Add() {

        }
    }
```

Add ViewModel to Xmal
```
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:viewmodel="clr-namespace:MauiBeginner.ViewModel"
             x:DataType="viewmodel:MainViewModel"
             x:Class="MauiBeginner.MainPage">


        <Entry Placeholder="Enter task"
               Text="{Binding Text}"
               Grid.Row="1"/>

        // Add 
        <Button Text="Add"
                Command="{Binding AddCommand}" />

        <CollectionView ItemsSource="{Binding Items}">
            <CollectionView.ItemTemplate>
                <DataTemplate x:DataType="{x:Type x:String}">


        // delete
        <SwipeItem Text="Delete" 
            Command="{Binding Source={RelativeSource AncestorType={x:Type viewmodel:MainViewModel}}, Path=DeleteCommand}" 
            CommandParameter="{Binding .}"/>
```

Create binding context using dependencies injection
```
    public MainPage(MainViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
```

Register page and viewmodel to dependency service
```
    builder.Services.AddSingleton<MainPage>();
    builder.Services.AddSingleton<MainViewModel>();
```