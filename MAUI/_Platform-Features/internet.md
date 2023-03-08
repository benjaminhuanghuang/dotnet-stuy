
```
// MauiProgram.cs
builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);


// View
IConnectivity connectivity;

public MainViewModel(IConnectivity connectivity)
{
    Items = new ObservableCollection<string>();
    this.connectivity = connectivity;
}

if (connectivity.NetworkAccess != NetworkAccess.Internet)
{
    await Shell.Current.DisplayAlert("Uh Oh!", "No Internet", "OK");
    return;
}
```