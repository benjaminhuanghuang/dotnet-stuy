
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


## Validation
Model
```cs

```

Controller
```cs
```

Error message in view
```html
<div class="col">
    <span class="text-danger" asp-validation-for="Name"></span>
</div>
```


## Use js
```html
@await RenderSectionAsync("Scripts", required: false)

```


## Partial view
