
```
// Install Package: Newtonsoft.Json
// Clone method in Manager : Person

using Newtonsoft.Json;

public override Person Clone(bool deepClone = false)
{
    if (deepClone)
    {
        var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
        var objectAsJson = JsonConvert.SerializeObject(this, typeof(Manager), settings);
        return JsonConvert.DeserializeObject<Person>(objectAsJson, settings);
    }

    return (Person)MemberwiseClone();
}
```