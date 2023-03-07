```
<CollectionView Grid.Row="2" Grid.ColumnSpan="2">
    <CollectionView.ItemsSource>
        <x:Array Type="{x:Type x:String}">
            <x:String>Apple</x:String>
            <x:String>Bananas</x:String>
        </x:Array>
    </CollectionView.ItemsSource>
</CollectionView>
```

Data binding
```
 <CollectionView Grid.Row="2" Grid.ColumnSpan="2">
    <CollectionView.ItemsSource>
        <x:Array Type="{x:Type x:String}">
            <x:String>Aplle</x:String>
            <x:String>Bananas</x:String>
        </x:Array>
    </CollectionView.ItemsSource>
    <CollectionView.ItemTemplate>
        <DataTemplate>
            <Grid>
                <Frame>
                    <Label Text="{Binding .}"/>
                </Frame>
            </Grid>
        </DataTemplate>
    </CollectionView.ItemTemplate>
</CollectionView>
```

Using ItemsSource
```
    <CollectionView Grid.Row="2" Grid.ColumnSpan="2" ItemsSource="{Binding Items}" SelectionMode="None">
        <CollectionView.ItemTemplate>
        </CollectionView.ItemTemplate>
    </CollectionView>
```