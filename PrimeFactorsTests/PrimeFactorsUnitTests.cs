using PrimeFactors;

namespace PrimeFactorsTests;

public class PrimeFactorsUnitTests
{
    [Theory]
    [InlineData(3, "Prime factors of 3 = 3")]
    [InlineData(12, "Prime factors of 12 = 3x2x2")]
    [InlineData(49, "Prime factors of 49 = 7x7")]
    public void PrimeFactors_ValidNumbers_ReturnsFactorMessage(int number, string expected)
    {
        var actual = Primes.PrimeFactors(number);
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(1001)]
    public void PrimeFactors_OutOfRangeNumber_ReturnsInvalidNumber(int number)
    {
        Assert.Equal("Invalid number", Primes.PrimeFactors(number));
    }
}
