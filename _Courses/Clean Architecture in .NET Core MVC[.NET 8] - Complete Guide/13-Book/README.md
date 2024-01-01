## Create domain model
WhiteLagoon.Domain/Entities/Booking.cs


## Add Booking model to DbContext
```cs
        public DbSet<Booking> Bookings { get; set; }
```

## Create repository
WhiteLagoon.Application/Common/Interfaces/IBookingRepository.cs
WhiteLagoon.Infrastructure/Repository/BookingRepository.cs


## Create database
```
add-migration addBookingToDb

update-database
```

## Add Booking controller



## Reuse VillaDetail partial view
```
   <partial name="_VillaDetail" model="@Model.Villa" />
```       


## Application User
Use user information when booking
```cs
    var claimsIdentity = (ClaimsIdentity)User.Identity;
    var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

    ApplicationUser user = _unitOfWork.User.GetFirstOrDefault(u => u.Id == userId);
```
