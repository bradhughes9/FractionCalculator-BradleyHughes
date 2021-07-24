using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalculator_BradleyHughes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextNumerator1.Text = "";
            TextNumerator2.Text = "";
            TextNumeratorAnswer.Text = "";
            TextDenominator1.Text = "";
            TextDenominator2.Text = "";
            TextDenominatorAnswer.Text = "";
            lblAnswer.Text = "";
        }
        //The = or calculate button
        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (MathButton.SelectedItem == "+")
            {
                try
                {
                    //Use the user input assigned variables to create the fractions.
                    Fraction f1 = new Fraction(int.Parse(TextNumerator1.Text), int.Parse(TextDenominator1.Text));
                    Fraction f2 = new Fraction(int.Parse(TextNumerator2.Text), int.Parse(TextDenominator2.Text));
                    Fraction result = f1.Add(f2);
                    TextNumeratorAnswer.Text = result.Numerator.ToString();
                    TextDenominatorAnswer.Text = result.Denominator.ToString();
                    lblAnswer.Text = result.ToDecimalString(3);
                    lblAnswer.Refresh();
                    lblMixed.Text = $"{result.ToMixedNumberString()}";
                }
                catch (Exception ception)
                {
                    MessageBox.Show(ception.ToString());
                }
            }

            if (MathButton.SelectedItem == "-")
            {
                try
                {
                    //Use the user input assigned variables to create the fractions.
                    Fraction f1 = new Fraction(int.Parse(TextNumerator1.Text), int.Parse(TextDenominator1.Text));
                    Fraction f2 = new Fraction(int.Parse(TextNumerator2.Text), int.Parse(TextDenominator2.Text));
                    Fraction result = f1.Subtract(f2);
                    TextNumeratorAnswer.Text = result.Numerator.ToString();
                    TextDenominatorAnswer.Text = result.Denominator.ToString();
                    lblAnswer.Text = result.ToDecimalString(3);
                    lblAnswer.Refresh();
                    lblMixed.Text = $"{result.ToMixedNumberString()}";
                }
                catch (Exception ception)
                {
                    MessageBox.Show(ception.ToString());
                }
            }

            if (MathButton.SelectedItem == "*")
            {
                try
                {
                    //Use the user input assigned variables to create the fractions.
                    Fraction f1 = new Fraction(int.Parse(TextNumerator1.Text), int.Parse(TextDenominator1.Text));
                    Fraction f2 = new Fraction(int.Parse(TextNumerator2.Text), int.Parse(TextDenominator2.Text));
                    Fraction result = f1.Multiply(f2);
                    TextNumeratorAnswer.Text = result.Numerator.ToString();
                    TextDenominatorAnswer.Text = result.Denominator.ToString();
                    lblAnswer.Text = result.ToDecimalString(3);
                    lblAnswer.Refresh();
                    lblMixed.Text = $"{result.ToMixedNumberString()}";
                }
                catch (Exception ception)
                {
                    MessageBox.Show(ception.ToString());
                }
            }

            if (MathButton.SelectedItem == "/")
            {
                try
                {
                    //Use the user input assigned variables to create the fractions.
                    Fraction f1 = new Fraction(int.Parse(TextNumerator1.Text), int.Parse(TextDenominator1.Text));
                    Fraction f2 = new Fraction(int.Parse(TextNumerator2.Text), int.Parse(TextDenominator2.Text));
                    Fraction result = f1.Divide(f2);
                    TextNumeratorAnswer.Text = result.Numerator.ToString();
                    TextDenominatorAnswer.Text = result.Denominator.ToString();
                    lblAnswer.Text = result.ToDecimalString(3);
                    lblAnswer.Refresh();
                    lblMixed.Text = $"{result.ToMixedNumberString()}";
                }
                catch (Exception ception)
                {
                    MessageBox.Show(ception.ToString());
                }
            }
        }
    }
}
