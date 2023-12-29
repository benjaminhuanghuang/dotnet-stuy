## Add Edit and Delete button in the view
Pass asp-route-villaId="@obj.Id" to controller
```html
 <div class="y-75 btn-group" role="group">
     <a asp-controfler="Villa" asp-action="Update" asp-route-villaId="@obj.Id"
        class="btn btn-success mx-2">
         <i class="bi bi-pencil-square"></i>
         Edit
     </a>
     <a asp-controfler="Villa" asp-action="Update" asp-route-villaId="@obj.Id"
        class="btn btn-danger mx-2">
         <i class="bi bi-trash-fill"></i>
         Delete
     </a>
 </div>
```




## Not Found Page



## Update need id in the view
Need id in the view
```html
<input asp-for="Id" hidden/>
```


## Delete
Add action and view
