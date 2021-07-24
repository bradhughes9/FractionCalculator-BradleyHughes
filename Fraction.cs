using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator_BradleyHughes
{
    class Fraction
    {
        public Fraction() : this(1, 1) { }
        public Fraction(int theNumerator, int theDenominator)
        {
            Numerator = theNumerator;
            Denominator = theDenominator;
            this.Reduce();
        }
        public int Numerator;
        public int Denominator;
        public Fraction Add(Fraction rightFrac)
        {
            int Numerator = this.Numerator * rightFrac.Denominator + rightFrac.Numerator * this.Denominator;
            int Denominator = this.Denominator * rightFrac.Denominator;
            Fraction result = new Fraction(Numerator, Denominator);
            return result;
            
        }
        public Fraction Subtract(Fraction rightFrac)
        {
            int Numerator = this.Numerator * rightFrac.Denominator - rightFrac.Numerator * this.Denominator;
            int Denominator = this.Denominator * rightFrac.Denominator;

            Fraction result = new Fraction(Numerator, Denominator);
            return result;

        }
        public Fraction Multiply(Fraction rightFrac)
        {
            int Numerator = this.Numerator * rightFrac.Numerator;
            int Denominator = this.Denominator * rightFrac.Denominator;

            Fraction result = new Fraction(Numerator,Denominator);
            return result;
        }
        public Fraction Divide(Fraction rightFrac)
        {
            int Numerator = this.Numerator * rightFrac.Denominator;
            int Denominator = this.Denominator * rightFrac.Numerator;

            Fraction result = new Fraction(Numerator, Denominator);
            return result;
        }
        private void Reduce()
        {

            if (this.Denominator == 0)
            {
                throw new Exception("You cannot have a 0 in the Denominator.");
            }
            int lowNumber = this.Numerator >= this.Denominator ? this.Denominator : this.Numerator;

            for (int i = lowNumber; i>0; i--)
            {
                if (this.Numerator % i == 0 && this.Denominator % i == 0)
                {
                    this.Numerator = this.Numerator / i;
                    this.Denominator = this.Denominator / i;
                }
            }
        }
        public double ToDouble()
        {
            double result = 0;
            result = (double)this.Numerator / this.Denominator;
            return result;
        }
        public override string ToString()
        {
            string result = $"{this.Numerator.ToString()}/{this.Denominator.ToString()}";
            return result;
        }
        public string ToDecimalString(int numOfDigitsToRight)
        {
            string result = "";
            result = string.Format($"{{0:F{numOfDigitsToRight}}}", this.ToDouble());

            return result;
        }
        public string ToMixedNumberString()
        {
            string result = "";
            int wholeNumber = this.Numerator / this.Denominator;
            int resultNumerator = this.Numerator % this.Denominator;
            Fraction resultFraction = new Fraction(resultNumerator, this.Denominator);
            result = $"{wholeNumber.ToString()} {resultFraction.ToString()}";
            return result;

        }




    }
}
