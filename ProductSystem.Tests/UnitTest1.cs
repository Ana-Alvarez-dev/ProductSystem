
using NUnit.Framework;

namespace ProductSystem.Tests;

[TestFixture]
public class ProjectConfigurationTests
{
    [Test]
    public void NUnitConfiguration_WhenTestRuns_ShouldPass()
    {
        // Arrange
        int expected = 10;
        int actual = 5 + 5;

        // Act
        bool result = expected == actual;

        // Assert
        Assert.That(result, Is.True);
    }
}
