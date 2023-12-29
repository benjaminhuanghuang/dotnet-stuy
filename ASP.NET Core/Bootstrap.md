

Add link in the Views\Shared\_Layout.cshtml
```html
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="Villa" asp-action="Index">Villa</a>
</li>
```


Add Bootstrap icons
https://icons.getbootstrap.com/ -> Usage -> copy the CDN link and paste in _Layout.cshtml


Add Bootstrap theme
Search CDN bootstrap 5 -> cdnjs -> 5.3.1
Replace the link of bootstrap css and js in _Layout.cshtml
Use the dark theme in _Layout.cshtml
```
<html lang="en" data-bs-theme="dark">
```
Remove  bg-white and text-dark from the nvabar in _Layout.cshtml
