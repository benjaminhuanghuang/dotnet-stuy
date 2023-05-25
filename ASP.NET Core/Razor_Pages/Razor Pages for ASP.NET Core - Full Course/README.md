# Razor Pages for ASP.NET Core - Full Course
https://www.youtube.com/watch?v=eru2emiqow0


  
## EF



## Create

validation use attribute
```
[Required]
public string  Name { get; set; }
```


error message
```
<div asp-validation-summary="All"></div>
```

```
 <span asp-validation-for="Category.DisplayOrder" class="text-danger"></span>
```






## Use bootst
bootswatch.com

Download cyborg min css

Add it to Pages\Shared\_Layout.cshtml

Change bootstrap.bundle.min.js to latest version

Add bootstrap icons
https://icons.getbootstrap.com/


Change nav bar style
```
navbar-dark bg-dark
```