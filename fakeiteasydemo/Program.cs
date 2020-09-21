using System;

namespace fakeiteasydemo
{
    public interface IMaths
    {
        double Add(double a, double b);
        double Substract(double a, double b);
        double Multiply(double a, double b, double c);
        double Divide(double a, int b);
        double Multiply2No(double a, double b);
    }
    public class Maths : IMaths
    {
        public virtual double Add(double a, double b)
        {
            return a + b;
        }
        public virtual double Substract(double a, double b)
        {
            return a - b;
        }
        public virtual double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

        public virtual double Multiply2No(double a, double b)
        {
            return a * b;
        }
        public virtual double Divide(double a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return a / b;
            }
        }
    }

    public class SimpleInterest
    {
        private IMaths _IMaths;
        public SimpleInterest(IMaths maths)
        {
            _IMaths = maths;
        }
        public virtual dynamic SimpleInterestMethod(double principal, double rate, double time, int deniom)
        {
            if (principal < 0 || rate < 0 || time < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (deniom < 0)
            {
                throw new DivideByZeroException();
            }
            double result = _IMaths.Divide(_IMaths.Multiply(principal, rate, time), deniom);
            return result;
        }
    }
    public class CompoundInterest
    {
        private IMaths _IMaths;
        public CompoundInterest(IMaths maths)
        {
            _IMaths = maths;
        }
        public virtual dynamic CompoundInterestMethod(double principal, double rate, int time, double year)
        {
            // (1 + r/n)
            double body = 1 + _IMaths.Divide(rate, time);
            // nt
            double exponent = _IMaths.Multiply2No(time, year);
            // p(1+r/n)^nt
            return principal * Math.Pow(body, exponent);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double principal = 200, rate = 25, time = 10, year = 6;
            int denom = 100, timec = 20;
            Maths maths = new Maths();
            SimpleInterest simpleInterest = new SimpleInterest(maths);
            Console.WriteLine("Simple Interest Result : {0}", simpleInterest.SimpleInterestMethod(principal, rate, time, denom));
            CompoundInterest compoundInterest = new CompoundInterest(maths);
            Console.WriteLine("Compound Interest Result : {0}", compoundInterest.CompoundInterestMethod(principal, rate, timec, year));
            Console.ReadLine();

        }
    }
}
