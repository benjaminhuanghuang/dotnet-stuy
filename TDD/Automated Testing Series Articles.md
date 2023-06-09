# Automated Testing Series' Articles
https://dev.to/ant_f_dev/series/23001


## 4 Types of Tests to Help Keep Your Software's Bug Count Low
- Manual.
  
- End-to-end.
check that requests can successfully be made to an API and that the response is as expected. validate more than integration tests.

- Integration.
tests to test multiple components together

- Unit.
provide a basic input/output check.


## 7 Easy Steps to Writing Your First C# Unit Test
1. Choose a Framework to Use When Writing Tests: MSTest, NUnit and xUnit 
2. Create a Separate Project for Your Tests
3. Identify the Components in a Solution
4. Create an Empty Test
```
public class MultiplicationServiceTests
{
    [Test]
    public void MultiplicationServiceCanSquareNumber()
    {
        // Arrange

        // Act

        // Assert
    }
}
```
5. Fill in the Test Steps
6. Write the Code
7. Run the Test
```
    Ctrl+R, T
    Ctrl+R, Ctrl+T  // Debug

```


## Parameterise Your Tests: Use this One Simple Trick to Increase Test Coverage

Passing inputs and expected outputs as test parameters.

```
[TestCase(2, 4)]
[TestCase(3, 9)]
[TestCase(4, 16)]
public void MultiplicationServiceCanSquareNumber(int input, int expected)
{
    // Arrange

    var service = new MultiplicationService();

    // Act

    var result = service.Square(input);

    // Assert

    Assert.That(result, Is.EqualTo(expected));
}
```

## Isolate your Components in Tests: How to Mock your Dependencies
```
[Test]
public void CalculationServiceCanCalculateSumOfSquares()
{
    // Arrange

    var multiplicationService = Mock.Of<IMultiplicationService>();
    var service = new CalculationService(multiplicationService);

    // Act

    var result = service.SumOfSquares(3, 4);

    // Assert

    Assert.That(result, Is.EqualTo(25));
}
```
