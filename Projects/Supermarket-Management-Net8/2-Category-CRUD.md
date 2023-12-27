
## Add In-memory CategoriesRepository


## CategoryController and View
```html
   @foreach(var category in Model)
   {
       <li>@category.Name</li>
   }
```


## Tag helpers create links
```html
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

<a class="btn btn-link" asp-controller="categories" asp-action="edit" asp-route-id="@category.CategoryId">Edit</a>
         
```

## Import in central view
_ViewStart


## 
