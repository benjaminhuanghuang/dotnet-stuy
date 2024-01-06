```cs
static int previousMonth = DateTime.Now.Month ==1? 12 : DateTime. Now.Month-1;
readonly DateTime previousMonthStartDate = new(DateTime. Now. Year, previousMonth, 1);
readonly DateTime currentMonthStartDate = new(DateTime.Now. Year, DateTime.Now.Month, 1);
```
