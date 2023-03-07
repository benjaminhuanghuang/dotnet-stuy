

3 rows: 100, Auto(us as much space as needed), *(fill all)
2 columns: 75% and 25%

```
    <Grid RowDefinitions="100, Auto, *"
          ColumnDefinitions=".75*, .25*"
          Padding="10"
          RowSpacing="10"
          ColumnSpacing="10">
        <Image Grid.ColumnSpan="2"
                    Source="logo.png"
                BackgroundColor="Transparent"/>
```