## Redirect admin to Dashboard
Add DashboardController.cs



AccountController.cs / Login Post
```cs
 if (await _userManager.IsInRoleAsync(user, SD.Role_Admin))
 {
     return RedirectToAction("Index", "Dashboard");
 }
```

## Layout for Admin
_LayoutAdmin
```
 data-bs-target="#sidebarMenu" aria-controls="sidebarMenu"


```

_ViewStart.cshtml
```html
@if(User.IsInRole(SD.Role_Admin))
{
    Layout = "_LayoutAdmin";
}
else
{
    Layout = "_Layout";
}
```
## _LoginPartialAdmin.cshtml



## Modify the css of data table
site.css
```
.dataTables_filter{
    margin-bottom:20px;
}
```
