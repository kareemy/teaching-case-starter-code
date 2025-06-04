using ShippingLibrary;

namespace ShippingTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(ShippingClass.CalculateShippingCost("11111"), 5.99M);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Invalid Zip Code")]
    public void TestMethod2()
    {
        ShippingClass.CalculateShippingCost("x1");
    }

    [TestMethod]
    public void TestMethod3()
    {
        Assert.AreEqual(ShippingClass.CalculateShippingCost("22222"), 7.99M);
    }

    [TestMethod]
    public void TestMethod4()
    {
        Assert.AreEqual(ShippingClass.CalculateShippingCost("33333"), 9.99M);
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.AreEqual(ShippingClass.CalculateShippingCost("44444"), 11.99M);
    }

    [TestMethod]
    public void TestMethod6()
    {
        Assert.AreEqual(ShippingClass.CalculateShippingCost("55555"), 13.99M);
    }

    [TestMethod]
    public void TestMethod7()
    {
        Assert.AreEqual(ShippingClass.CalculateShippingCost("66666"), 15.99M);
    }
}
