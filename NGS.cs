﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C1_labolatorium_genetyczne_hierarchia_dziedziczeniea_
{
    class NGS:GenTest
    {
        public void ChooseNumbersOfGenes(int _numbers)
        {
            result = new List<bool>();
            switch (method)
            {
                case 1:
                    cost = baseCost * _numbers * 0.8;
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
            }
        }
        public NGS(double _cost, double _aproxTime):base(_cost, _aproxTime)
        {

        }
    }
}
