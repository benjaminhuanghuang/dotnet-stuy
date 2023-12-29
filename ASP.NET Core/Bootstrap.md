

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



Annotation in the model
```cs
[Display(Name = "Price per night")]
public double Price { get; set; }

```

## Server side validation, DataAnnotation in the model
```cs
  [HttpPost]
  public IActionResult Create(Villa villa)
  {
    if(obj. Name == obj.Description)
        ModelState AddModelError("", "The description cannot exactly match the Name.");


      if (ModelState.IsValid)
      {
          _db.Villas.Add(villa);
          _db.SaveChanges();
          return RedirectToAction("Index");
      }
      return View(villa);
  }   


   [Range(10,1000)]
    public double Price { get; set; }
```

Disable the server side validation in the view
```html
<div asp-validation-summary="ModelOnly"></div>

<span asp-validation-for="Name" class="text-danger"></span>
```


Custom model validation
```cs
[HttpPost]
  public IActionResult Create(Villa villa)
  {
    if(obj. Name == obj.Description)
        ModelState AddModelError("<Field has error>", "The description cannot exactly match the Name.");


      if (ModelState.IsValid)
      {
          _db.Villas.Add(villa);
          _db.SaveChanges();
          return RedirectToAction("Index");
      }
      return View(villa);
  }   
```
Disable the server side validation in the view
```html
<div asp-validation-summary="ModelOnly"></div>   # Disable the error without field name

<div asp-validation-summary="All"></div>
```


## Client side validation
The model validation can be done at client side
```html
@section Scripts {
   @{
       <partial name="_ValidationScriptsPartial"/>
   }
}
```
