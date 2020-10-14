using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSeries15()
        {
            int k = 120;
            int rez = 0;
            int rez15 = masha.mas_dz.Series15(k);
            Assert.AreEqual(rez, rez15);
        }
        [Test]
        public void TestSeries17()
        {
            int b = 120;
            double[] rez = new double[] { 2.3, 4.5, 11, 20, 32.1, 120 };
            double[] rez17 = masha.mas_dz.Series17(b);
            Assert.AreEqual(rez, rez17);
        }
        [Test]
        public void TestSeries19()
        {
            int n = 9;
            int k = 0;
            int[] rez = new int[] { 3 };
            int[] rez18 = masha.mas_dz.Series19(n, k);
            Assert.AreEqual(rez, rez18);
        }
    }

    
}
