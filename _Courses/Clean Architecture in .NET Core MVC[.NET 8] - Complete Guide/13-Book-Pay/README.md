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


## Stripe payment
Register

add publishable key and secret key to appsettings.json

Install stripe.net

config stripe in Program.cs
```cs
    StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKy").Get<string>();
```

Card information 
4111 1111 1111 1111


## Process the booking
```cs
  public IActionResult BookingConfirmation(int bookingId)
```
