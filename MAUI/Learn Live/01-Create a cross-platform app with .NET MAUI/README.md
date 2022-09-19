# Learn Live: Build mobile and desktop apps with .NET MAUI
https://docs.microsoft.com/en-us/events/learn-events/learnlive-mobile-desktop-apps-dotnet-maui/


## Project structure
- The `Resources` folder contains shared fonts, images, and assets used by all platforms.

- The MauiProgram.cs file contains the code that `configures the app` and specifies that the App class should be used to run the application.

- The App.xaml.cs file, the constructor for the App class `creates a new instance of the AppShell` class, which is then displayed in the application window.

- The AppShell.xaml file contains the `main layout` for the application and `starting page` of MainPage.

- The MainPage.xaml file contains the `layout for the page`. This layout includes the XAML code for a button with the caption Click me, and an image that displays the dotnet_bot.png file. There are two other labels as well.

- The MainPage.xaml.cs file contains the `application logic` for the page. Specifically, the MainPage class includes a method named OnCounterClicked that runs when the user taps the Click me button.

- Platforms. This folder contains platform-specific initialization code files and resources

## App structure
- The MauiProgram.cs file that contains the code for creating and configuring the Application object.

- The App.xaml and App.xaml.cs files that provide UI resources and create the initial window for the application (create a instance of AppShell). App instance is loaded by the bootstrap code for each platform.

The App class also contains: Methods for handling life-cycle events and Methods for creating new Windows for the application. The .NET MAUI application by default has a single window, but you can create and launch additional windows, which is helpful in desktop and tablet applications.


- The AppShell.xaml and AppShell.xaml.cs files that specify the initial page for the application and handle the registration of pages for navigation routing. Shell provides features for multiple-platform apps including app styling, URI navigation, layout...

- The MainPage.xaml and MainPage.xaml.cs files that define the layout and UI logic for the page displayed by default in the initial window.
```
<ContentPage ...>
    <ScrollView ...>
        <VerticalStackLayout>
            <Image ... />
            <Label ... />
            <Label ... />
            <Button ... />
        </VerticalStackLayout>
    </ScrollView>
</ContentPage>
```


## Build and run the application on Windows


## Build and run the application on Android
- Create a Android Device


## Update the Android application manifest to enable Android to use the phone