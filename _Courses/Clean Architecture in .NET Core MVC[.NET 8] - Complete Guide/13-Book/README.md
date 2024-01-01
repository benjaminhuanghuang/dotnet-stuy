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
