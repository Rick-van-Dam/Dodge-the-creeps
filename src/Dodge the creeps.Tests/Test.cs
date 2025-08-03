using GdUnit4;

using static GdUnit4.Assertions;

namespace Dodge_the_creeps.Tests;

[TestSuite]
public class Test
{
    [TestCase]
    public void IsEqual()
    {
        AssertThat("This is a test message").IsEqual("This is a test message");
    }
}