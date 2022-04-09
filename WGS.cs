using System;
using System.Collections.Generic;
using System.Text;

namespace C1_labolatorium_genetyczne_hierarchia_dziedziczeniea_
{
    class WGS:NGS
    {
        public List<string> kindOfCircumstance = new List<string>();
        public new void ChooseNumbersOfGenes(int _numbers)
        {
            result = new List<bool>();
            kindOfCircumstance = new List<string>();
            switch (method)
            {
                case 1:
                    cost = baseCost *_numbers*0.8;
                    break;
                case 2:
                    cost = baseCost * _numbers * 1.3;
                    break;
                case 3:
                    cost = baseCost * _numbers * 1.8;
                    break;
                default:
                    cost = baseCost * _numbers;
                    break;
            }
            for (int i = 0; i < _numbers; i++)
            {
                result.Add(false);
                kindOfCircumstance.Add("");
            }           
        }
        public WGS(double _cost, double _aproxTime):base(_cost, _aproxTime)
        {
            baseAproxTime = baseAproxTime * 4;
            baseCost = baseCost * 0.05;
            cost = baseCost;
            aproxTime = baseAproxTime;
            kindOfCircumstance.Add("");
        }
    }
}
