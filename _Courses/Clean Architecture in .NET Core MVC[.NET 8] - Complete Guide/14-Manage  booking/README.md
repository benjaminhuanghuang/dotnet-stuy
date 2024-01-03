## Create Index action in BookingController and view


## Use datatable.net
datatable.net
copy cdn link of css and javascript to _Layout


## Add a API for the datatable in BookingController
```cs
    [HttpGet]
    public IActionResult GetAll()
    {
       
    }
```

## Add wwwroot/js/booking.js

Add booking.js to booking/index.cshtml
```
@section Scripts {
    <script src="~/js/booking.js"></script>
}
```
