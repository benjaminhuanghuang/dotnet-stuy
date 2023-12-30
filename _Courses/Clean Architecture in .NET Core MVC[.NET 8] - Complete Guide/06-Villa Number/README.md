## Create Entity with Foreign Key


## Create DBSet
```cs
    public DbSet<VillaNumber> VillaNumbers { get; set; }
```

## Seed data
```
 modelBuilder.Entity<VillaNumber>().HasData(
    new VillaNumber
    {
        Villa_Number = 101,
        VillaId = 1,
    },
    ...
 );
```

## Update database
 ```
 add-migration AddVillaNumber
 update-database
 ```

## Crete VillaNumberController
```

```

## Use ViewData with DropDown
```cs

 IEnumerable<SelectListItem> list = _db.Villas.ToList().Select(u => new SelectListItem
  {
      Text = u.Name,
      Value = u.Id.ToString()
  });
ViewData["VillaList"] = list;

ViewBag.VillaList = list;

```

## Use ViewModels



## Load Navigation Properties
```cs

 public IActionResult Index()
 {
     var villaNumbers = _db.VillaNumbers.Include(u=>u.Villa).ToList();   // Load navigation properties

     return View(villaNumbers);
 }
 
```

```
 <td>@obj.Villa.Name</td>


```
