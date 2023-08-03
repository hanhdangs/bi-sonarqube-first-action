using Hello.All;

namespace Hello.Tests;

public class FooTests
{
    Foo foo;

    [SetUp]
    public void Setup()
    {
        foo = new Foo
        {
            Id = 1,
            Name = "A"
        };
    }

    [Test]
    public void GetIdTest()
    {
        var expected = 1;
        var actual = foo.GetId();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetNameTest()
    {
        var expected = "A";
        var actual = foo.GetName();

        Assert.That(actual, Is.EqualTo(expected));
    }
}