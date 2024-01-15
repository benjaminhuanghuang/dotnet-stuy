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
## Data validation and OpenAPI
To add our custom validation attribute’s info to the swagger.json file
Create filter class implementing the IParameterFilter 

Add filter to the filter pipeline in Program.cs
```cs
builder.Services.AddSwaggerGen(options => {
    options.ParameterFilter<SortColumnFilter>();    
    options.ParameterFilter<SortOrderFilter>();     
});
```

https://localhost:7081/swagger/v1/swagger.json


## Binding complex types
Instead of having a potentially long list of method parameters, we can box all the parameters into a single DTO class
Create DOT/RequestDTO.cs

The IValidatableObject interface provides an alternative way to validate a class. 


## Error handling

## Custom error messages
