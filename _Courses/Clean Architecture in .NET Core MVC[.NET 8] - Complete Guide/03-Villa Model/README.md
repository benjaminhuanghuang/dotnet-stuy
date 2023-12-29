
Add VillaController 


inject dbcontext in controller
```cs
 private readonly ApplicationDbContext _context;

 public VillaController(ApplicationDbContext context)
 {
     _context = context;
 }
 ```


Add VillaView



Add link in the Views\Shared\_Layout.cshtml
```html
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="Villa" asp-action="Index">Villa</a>
</li>
```
