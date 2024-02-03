


```cs
[AttributeUsage(AttributeTargets.Method)]
public class ValidateParameterAttribute : Attribute
{
    private readonly string _ParamName;

    public ValidateParameterAttribute(string paramName)
    {
        _ParamName = paramName;
    }
}

[AttributeUsage(AttributeTargets.Property)]
public class ValidateAttribute<T> : Attribute
    where T : IValidator
{
    public T Validator { get; }
}

public class CoordinateValidator : IValidator
{
    public bool Validate(string input)
    {
        if (!(input.ToLower() == input))
            return false;
        if (input.Length > 100)
            return false;

        return true;
    }
}

internal class CityValidator : IValidator
{
    public bool Validate(string input)
    {
        if (!(input.ToUpper() == input))
            return false;
        if (input.Length > 20)
            return false;

        return true;
    }
}

public class MapPoint
{
    [Validate<CityValidator>]
    public string NearestCity { get; set; }

    [Validate<CoordinateValidator>]
    public string GpsCoordinates { get; set; }

    [ValidateParameter(nameof(startingPnt))]
    public int CalculateDistance(string startingPnt)
    {
        throw new NotImplementedException();
    }

}
```
