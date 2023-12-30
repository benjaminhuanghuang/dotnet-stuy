Add notification in the _Layout.cshtml
```html
 <div class="container">
     <main role="main" class="pb-3">
         @if(TempData["error"] != null)
         {
          <div class="text-danger h3">@TempData["error"]</div>   
         }
         @if (TempData["success"] != null)
         {
             <div class="text-danger h3">@TempData["success"]</div>
         }
         @RenderBody()
     </main>
 </div>
```


## Use Toastr by CodeSeven
https://github.com/CodeSeven/toastr

add CDN link of toastr css and js in _Layout.cshtml

```html
 @if (TempData["error"] != null)
 {
     <script src="~/lib/jquery/dist/jquery.min.js"></script>
     <script src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js" integrity="sha512-VEd+nq25CkR676O+pLBnDW09R7VQX9Mdiij052gVCp5yVH3jGtH70Ho/UUv4mJDsEdTvqRCFZg0NKGiojGnUCw==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>

     <script type="text/javascript">
         toastr.success('@TempData["error"]');
     </script>
 }
```


## Partial View
```
<partial name="_Notification"/>
```


## Scoped CSS
Scoped css is bundled into App.Web.styles.css
```
<link rel="stylesheet" href="~/WhiteLagoon.Web.styles.css" asp-append-version="true" />
``` 

## Global using statement
Views/_ViewImports.cshtml
```html
@using WhiteLagoon.Domain.Entities
```
