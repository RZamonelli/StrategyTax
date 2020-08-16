using System;

namespace Tax
{
    public class CalcTax
    {
        public double Calc(String tax, double value)
        {
            if (tax.Equals("ICMS"))
                return value * 0.10;
            else if (tax.Equals("IPI"))
                return value * 0.20;
            else if (tax.Equals("NEW_TAX"))
                return value * 0.50;
            return value;
        }
    }
}
