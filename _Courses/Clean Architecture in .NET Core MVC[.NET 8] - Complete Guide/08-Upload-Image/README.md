

```html
 <form method="post" class="row" enctype="multipart/form-data">
```

## Add form field



## Upload image
```cs
 string fileName = Guid.NewGuid().ToString()+ Path.GetExtension(obj.Image.FileName);
 string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\Villa");

 using (var fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create))
 {
     obj.Image.CopyTo(fileStream);
 }

```
