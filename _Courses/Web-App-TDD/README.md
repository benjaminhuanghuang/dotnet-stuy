# C# Test-Driven Development
Testing web applications and APIs
https://www.linkedin.com/learning/c-sharp-test-driven-development-14275015


Testing Framworks
- MSTest
- Nunit [*]
- xUnit

Mocking libraries
- Moq [*]
- NSubstitute
- FakeItEasy 
- MS Fakes


- Run test
```
dotnet test
```


- Mock testing
```
  <PackageReference Include="Moq" Version="4.16.1" />    
  <PackageReference Include="Microsoft.EntityFrameworkCore" Version="5.0.9" />
  <PackageReference Include="Moq.EntityFrameworkCore" Version="5.0.0.2" />
```
Using interface, mock the storage

```
  var mockManager = new Mock<IShoppingCartManager>();

  mockManager.Setup(manager => manager.AddToCart(
      It.IsAny<AddToCartRequest>())).Returns(
          (AddToCartRequest request) => new AddToCartResponse()
          {
              Items = new AddToCartItem[] { request.Item }
          }
      );

  //var manager = new ShoppingCartManager();
```




