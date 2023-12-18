namespace MoneyExtension.Tests;

[TestClass]
public class MoneyTests
{
    [TestMethod]
    public void Deve_converter_decimal_para_inteiro()
    {
        decimal originalValue = 279.98M;
        var cents = originalValue.ToCents();

        Assert.AreEqual(27998, cents);
    }
}