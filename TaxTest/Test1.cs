using TaxLibrary;

namespace TaxTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(TaxClass.CalculateSalesTax("11111"), 0.0875M);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Invalid Zip Code")]
    public void TestMethod2()
    {
        TaxClass.CalculateSalesTax("x1");
    }

    [TestMethod]
    public void TestMethod3()
    {
        Assert.AreEqual(TaxClass.CalculateSalesTax("99999"), 0.0925M);
    }

    [TestMethod]
    public void TestMethod4()
    {
        Assert.AreEqual(TaxClass.CalculateSalesTax("77777"), 0.0445M);
    }

    [TestMethod]
    public void TestMethod5()
    {
        Assert.AreEqual(TaxClass.CalculateSalesTax("66666"), 0.0625M);
    }

    [TestMethod]
    public void TestMethod6()
    {
        Assert.AreEqual(TaxClass.CalculateSalesTax("33333"), 0.07M);
    }

    [TestMethod]
    public void TestMethod7()
    {
        Assert.AreEqual(TaxClass.CalculateSalesTax("22222"), 0.05M);
    }
}
