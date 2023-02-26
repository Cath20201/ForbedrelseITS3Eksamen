using ForbedrelseITS3EksamenLibrary;
using ForbedrelseITS3EksamenLibrary.GoF_Strategy;
using NUnit.Framework;

namespace ForbedrelseITS3EksamenNunit
{
    public class TestFixedPricePayment
    {
        private MeterDataSample m_sample, m2_sample, m3_sample;
        private FixedPricePayment uut;
        [SetUp]
        public void Setup()
        {
            m_sample = new MeterDataSample(1, Convert.ToDateTime("00:00:00"), 0.4);
            m2_sample = new MeterDataSample(1, Convert.ToDateTime("01:30:00"), 0.24);
            m3_sample = new MeterDataSample(1, Convert.ToDateTime("06:00:00"), 0.05);
            uut = new FixedPricePayment();
        }

        [TestCase(1.432)]
        public void Test_PriceBillForFixedPayment_m_sample(double expectedResult)
        {
            double price = uut.GetPriceBill(m_sample);
            Assert.That(price, Is.EqualTo(expectedResult).Within(0.001));
        }

        [TestCase(0.859)]
        public void Test_PriceBillForFixedPayment_m2_sample(double expectedResult)
        {
            double price = uut.GetPriceBill(m2_sample);
            Assert.That(price, Is.EqualTo(expectedResult).Within(0.001));
        }

        [TestCase(0.179)]
        public void Test_PriceBillForFixedPayment_m3_sample(double expectedResult)
        {
            double price = uut.GetPriceBill(m3_sample);
            Assert.That(price, Is.EqualTo(expectedResult).Within(0.001));
        }
    }
}