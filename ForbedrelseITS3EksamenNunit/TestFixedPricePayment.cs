using ForbedrelseITS3EksamenLibrary;
using ForbedrelseITS3EksamenLibrary.GoF_Strategy;
using NUnit.Framework;

namespace ForbedrelseITS3EksamenNunit
{
    public class Tests
    {
        private MeterDataSample m_sample;
        private FixedPricePayment uut;
        [SetUp]
        public void Setup()
        {
            m_sample = new MeterDataSample(1, Convert.ToDateTime("00:00:00"), 0.57);
            uut = new FixedPricePayment();
        }

        [TestCase(2.041)]
        public void Test_PriceBillForFixedPayment(double expectedResult)
        {
            double price = uut.GetPriceBill(m_sample);
            Assert.That(price, Is.EqualTo(expectedResult).Within(0.001));
        }
    }
}