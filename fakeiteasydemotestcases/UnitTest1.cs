using FakeItEasy;
using fakeiteasydemo;
using NUnit.Framework;

namespace fakeiteasydemotestcases
{
    public class Tests
    {
        Maths m;
        SimpleInterest si;
        CompoundInterest ci;
        [SetUp]
        public void Setup()
        {
            ci = A.Fake<CompoundInterest>();
            si = A.Fake<SimpleInterest>();
            m = A.Fake<Maths>();
        }
        [Test]
        public void Calculate_Addition_Test_30()
        {
            double a = 10, b = 20;
            A.CallTo(() => m.Add(a, b)).Returns(30);
            Assert.AreEqual(30, m.Add(a, b));
        }
        [Test]
        public void Calculate_Substraction_10()
        {
            double a = 20, b = 10;
            A.CallTo(() => m.Substract(a, b)).Returns(10);
            Assert.AreEqual(10, m.Substract(a, b));
        }
        [Test]
        public void Calculate_Multiplication_100()
        {
            double a = 10, b = 2, c = 5;
            A.CallTo(() => m.Multiply(a, b, c)).Returns(100);
            Assert.AreEqual(100, m.Multiply(a, b, c));
        }
        [Test]
        public void Calculate_Multiplication_0()
        {
            double a = 10, b = 2, c = 0;
            A.CallTo(() => m.Multiply(a, b, c)).Returns(0);
            Assert.AreEqual(0, m.Multiply(a, b, c));
        }
        [Test]
        public void Calculate_Divide_10()
        {
            double a = 50;
            int b = 5;
            A.CallTo(() => m.Divide(a, b)).Returns(10);
            Assert.AreEqual(10, m.Divide(a, b));
        }
        [Test]
        public void Calculate_Multiplication_2No_100()
        {
            double a = 10, b = 2;
            A.CallTo(() => m.Multiply2No(a, b)).Returns(100);
            Assert.AreEqual(100, m.Multiply2No(a, b));
        }
        [Test]
        public void Calculate_Multiplication_2No_0()
        {
            double a = 10, b = 0;
            A.CallTo(() => m.Multiply2No(a, b)).Returns(0);
            Assert.AreEqual(0, m.Multiply2No(a, b));
        }
        [Test]
        public void Calculate_Simple_Interest_1000()
        {
            double p = 200, r = 25, t = 20;
            int n = 100;
            var maths = A.Fake<IMaths>();
            A.CallTo(() => si.SimpleInterestMethod(p, r, t, n)).Returns(1000);
            Assert.AreEqual(1000, si.SimpleInterestMethod(p, r, t, n));
        }

        [Test]
        public void Calculate_Simple_Interest_Error()
        {
            double p = 200, r = 25, t = 20; int n = 0;
            A.CallTo(() => si.SimpleInterestMethod(p, r, t, n)).Returns("DivideByZeroException");
            Assert.AreEqual("DivideByZeroException", si.SimpleInterestMethod(p, r, t, n));
        }
        [Test]
        public void Calculate_Compound_Interest()
        {
            double p = 200, r = 25, y = 6;
            int t = 20;
            A.CallTo(() => ci.CompoundInterestMethod(p, r, t, y)).Returns(3.655);
            Assert.AreEqual(3.655, ci.CompoundInterestMethod(p, r, t, y));
        }
    }
}