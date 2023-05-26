# Razor Pages for ASP.NET Core - Full Course
https://www.youtube.com/watch?v=eru2emiqow0

https://github.com/bhrugen/Abby/tree/54f6e2e8aa01aa133fe795c742fed426e255a4ed/AbbyWeb/Pages

  
## EF



## Create

validation use attribute
```
[Required]
public string  Name { get; set; }
```

Customize error
```
    if(category.Name == category.DisplayOrder.ToString()){
        ModelState.AddModelError("DisplayOrder", "DisplayOrder cannot be the same as Name");
    }
```

error message
```
<div asp-validation-summary="All"></div>
```

```
 <span asp-validation-for="Category.DisplayOrder" class="text-danger"></span>
```

Client side validation
```
@section Scripts {
    @{
        <partial name="_ValidationScriptsPartial"/>
    }
}
````
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

## Edit
```
public void OnGet(int id)
{
    Category = _db.Category.Find(id);
    // Category =_db.Category.FirstOrDefault(u => u.Id == id);
    // Category =_db.Category.SingleOrDefault(u => u.Id == id);
    // Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
}
```



## Delete



## Deploy to Azure
Create SQL Database

