Box

```
// Box x by assigning it to an object.
ant x = 3;

/ Because we are "upcasting" this to be of an object type it is now considered box, tha
// the box variable is a reference to the value type x
object box = x;

ChangeBoxedValue(ref box);
Console .WriteLine (box);


private static void ChangeBoxedValue(ref object o)
{
    // Change the boxed value of o.
    o = 6;
}
```
