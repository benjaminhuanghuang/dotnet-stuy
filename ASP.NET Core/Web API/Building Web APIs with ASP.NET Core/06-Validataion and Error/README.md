# Data validation and error handling

## Model binding
Add validation attributes parameter of controller
```cs
[Range(1, 100)] int pageSize = 10,  
[RegularExpression("ASC|DESC")] string? sortOrder = "ASC",
```

## Custom validation Attributes
Attributes/SortOrderAttribute.cs
Attributes/SortOrderAttribute.cs
Use it on conroller
```cs
 [SortOrderValidator] string? sortOrder = "ASC",
 [SortColumnValidator(typeof(BoardGameDTO))] string? sortColumn = "Name",
  
```
