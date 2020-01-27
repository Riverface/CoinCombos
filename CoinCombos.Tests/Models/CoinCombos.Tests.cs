using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombos;
namespace CoinCombos
{
    [TestClass]
    public class Tests
    {
        Counter wallet = new Counter(9.52F);
        [TestMethod]
        public void ComboTest()
        {
        wallet.CalculateChange();
        Assert.AreEqual(wallet.Pennies, 2);
        }
    }

}