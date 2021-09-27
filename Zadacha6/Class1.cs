using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha6
{
    public class Converter
    {
        public double UsdToUah { get; set; }

        public double EurToUah { get; set; }

        public double RubToUah { get; set; }

        public Converter(double usd, double eur, double rub)
        {
            UsdToUah = usd;
            EurToUah = eur;
            RubToUah = rub;
        }

        public double ConvertToUsd(double uah)
        {
            return uah * UsdToUah;
        }

        public double ConvertToEur(double uah)
        {
            return uah * EurToUah;
        }

        public double ConvertToRub(double uah)
        {
            return uah * RubToUah;
        }

        public double ConvertFromUsd(double usd)
        {
            return usd / UsdToUah;
        }

        public double ConvertFromEur(double eur)
        {
            return eur / EurToUah;
        }

        public double ConvertFromRub(double rub)
        {
            return rub / RubToUah;
        }
    }
}
