Change parameters to
```cs
public async Task<RestDTO<BoardGame[]>> Get(
    int pageIndex = 0,
    [Range(1, 100)] int pageSize = 10,
    string? sortColumn = "Name",
    [RegularExpression("ASC|DESC")] string? sortOrder = "ASC",
    string? filterQuery = null)
{

}
```


to 
```cs
public async Task<RestDTO<BoardGame[]>> Get([FromQuery] RequestDTO input)
```

Tell the routing middleware that we want to get the input values
[FromQuery]—To get values from the query string

[FromRoute]—To get values from route data

[FromForm]—To get values from posted form fields

[FromBody]—To get values from the request body

[FromHeader]—To get values from HTTP headers

[FromServices]—To get values from an instance of a registered service

[FromUri]—To get values from an external URI


The IValidatableObject interface provides an alternative way to validate a class. 
