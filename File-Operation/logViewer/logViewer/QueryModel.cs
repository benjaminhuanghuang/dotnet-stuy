namespace PBiLogViewer
{
    /*
     * record is a new language feature that was introduced in C# 9.0. 
     * 
     * A record is a reference type that represents an immutable data structure, similar to a class or a struct.
     * The primary purpose of records is to simplify the creation of data transfer objects (DTOs),
     * which are used to represent data that is transferred between layers of an application or across network boundaries. 
     * 
     * Records provide a concise syntax for defining a type with properties, equality members, and other methods that are commonly used with DTOs.
     */
    public record QueryModel(int LineNumber, QueryType QueryType, string QueryText);

    public enum QueryType
    {
        SQ,
        DSQ,
        DAX
    }
}
