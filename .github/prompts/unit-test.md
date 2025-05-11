# Unit Test Guidelines

## Purpose
Unit tests ensure individual components of the codebase work as expected, improving reliability and maintainability.

## General Principles
- Write tests for every new feature and bug fix.
- Tests should be **isolated**: mock dependencies and avoid external systems.
- Use **descriptive names** for test cases.
- Follow the **Arrange-Act-Assert** pattern.

## Structure
- Place unit tests in a `__tests__` or `tests` directory, mirroring the source structure.
- Use a consistent naming convention: `filename.test.js`, `filename.spec.ts`, or `ClassNameTests.cs` for .NET.

## Best Practices
- Test both **positive** and **negative** scenarios.
- Keep tests **small** and **focused**.
- Avoid logic duplication between tests and implementation.
- Use setup/teardown methods for repeated initialization.

## Tools
- Use [Jest](https://jestjs.io/) for JavaScript/TypeScript projects.
- Use [pytest](https://docs.pytest.org/) for Python projects.
- Use [xUnit](https://xunit.net/) or [NUnit](https://nunit.org/) for .NET projects.

## Example (Jest)
```js
describe('sum', () => {
    it('returns the sum of two numbers', () => {
        expect(sum(1, 2)).toBe(3);
    });
});
```

## Example (.NET xUnit)
```csharp
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSumOfTwoNumbers()
    {
        var calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }
}
```

## Review
- Ensure all tests pass before merging.
- Aim for high code coverage, but prioritize meaningful tests over coverage percentage.# Unit Test Guidelines

## Purpose
Unit tests ensure individual components of the codebase work as expected, improving reliability and maintainability.

## General Principles
- Write tests for every new feature and bug fix.
- Tests should be **isolated**: mock dependencies and avoid external systems.
- Use **descriptive names** for test cases.
- Follow the **Arrange-Act-Assert** pattern.

## Structure
- Place unit tests in a `__tests__` or `tests` directory, mirroring the source structure.
- Use a consistent naming convention: `filename.test.js`, `filename.spec.ts`, or `ClassNameTests.cs` for .NET.

## Best Practices
- Test both **positive** and **negative** scenarios.
- Keep tests **small** and **focused**.
- Avoid logic duplication between tests and implementation.
- Use setup/teardown methods for repeated initialization.

## Tools
- Use [Jest](https://jestjs.io/) for JavaScript/TypeScript projects.
- Use [pytest](https://docs.pytest.org/) for Python projects.
- Use [xUnit](https://xunit.net/) or [NUnit](https://nunit.org/) for .NET projects.

## Example (Jest)
```js
describe('sum', () => {
    it('returns the sum of two numbers', () => {
        expect(sum(1, 2)).toBe(3);
    });
});
```

## Example (.NET xUnit)
```csharp
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSumOfTwoNumbers()
    {
        var calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }
}
```

## Review
- Ensure all tests pass before merging.
- Aim for high code coverage, but prioritize meaningful tests over coverage percentage.