using ForbedrelseITS3EksamenLibrary.GoF_Strategy;
using ForbedrelseITS3EksamenLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenNunit
{
    public class TestFlexiblePricePayment
    {
        private MeterDataSample m_sample;
        private MeterDataSample m2_sample;
        private MeterDataSample m3_sample;
        private MeterDataSample m4_sample;
        private MeterDataSample m5_sample;
        private FlexiblePricePayment uut;

        [SetUp]
        public void Setup()
        {
            m_sample = new MeterDataSample(1, Convert.ToDateTime("00:00:00"), 0.4);
            m2_sample = new MeterDataSample(1, Convert.ToDateTime("06:00:00"), 0.4);
            m3_sample = new MeterDataSample(1, Convert.ToDateTime("11:00:00"), 0.4);
            m4_sample = new MeterDataSample(1, Convert.ToDateTime("20:00:00"), 0.4);
            m5_sample = new MeterDataSample(1, Convert.ToDateTime("21:00:00"), 0.4);
            uut = new FlexiblePricePayment();
        }

        [TestCase(0.58)]
        public void Test_PriceBillForFlexiblePayment_m_sample(double expectedResult)
        {
            double price = uut.GetPriceBill(m_sample);
            Assert.That(price, Is.EqualTo(expectedResult).Within(0.001));
        }
        [TestCase(1.32)]
        public void Test_PriceBillForFlexiblePayment_m2_sample(double expectedResult)
        {
            double price = uut.GetPriceBill(m2_sample);
            Assert.That(price, Is.EqualTo(expectedResult).Within(0.001));
        }
        [TestCase(0.76)]
        public void Test_PriceBillForFlexiblePayment_m3_sample(double expectedResult)
        {
            double price = uut.GetPriceBill(m3_sample);
            Assert.That(price, Is.EqualTo(expectedResult).Within(0.001));
        }
        [TestCase(1.74)]
        public void Test_PriceBillForFlexiblePayment_m4_sample(double expectedResult)
        {
            double price = uut.GetPriceBill(m4_sample);
            Assert.That(price, Is.EqualTo(expectedResult).Within(0.001));
        }
        [TestCase(0.48)]
        public void Test_PriceBillForFlexiblePayment_m5_sample(double expectedResult)
        {
            double price = uut.GetPriceBill(m5_sample);
            Assert.That(price, Is.EqualTo(expectedResult).Within(0.001));
        }
    }
}
