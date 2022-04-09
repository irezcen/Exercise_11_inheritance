using System;
using System.Collections.Generic;
using System.Text;

namespace C1_labolatorium_genetyczne_hierarchia_dziedziczeniea_
{
    class GenTest
    {
        protected double baseCost;
        protected double baseAproxTime;
        protected double cost;
        protected double aproxTime;
        public List<bool> result;
        protected int method;
        public int Method
        {
            get
            {
                return method;
            }
        }
        public double Cost
        {
            get
            {
                return cost;
            }
        }
        public double AproxTme
        {
            get
            {
                return aproxTime;
            }
        }
        public void ChooseMethod(int i)
        {
            switch (method)
            {
                case 1:
                    cost = cost*1.25;
                    aproxTime = aproxTime * (2 / 3);
                    break;
                case 2:
                    cost = cost * (10 / 13);
                    aproxTime = aproxTime * (10 / 9);
                    break;
                case 3:
                    cost = cost * (10 / 18);
                    aproxTime = aproxTime * 2;
                    break;
                default:
                    break;
            }
            switch (i)
            {
                case 1:
                    cost = cost*0.8;
                    aproxTime = aproxTime*1.5;
                    break;
                case 2:
                    cost = cost * 1.3;
                    aproxTime = aproxTime*0.9;
                    break;
                case 3:
                    cost  = cost* 1.8;
                    aproxTime = aproxTime * 0.5;
                    break;
                default:
                    method = 0;
                    break;
            }
        }
        public GenTest()
        {
            baseCost = 20;
            cost = baseCost;
            baseAproxTime = 5;
            aproxTime = baseAproxTime;
            result = new List<bool>();
            result.Add(false);
            method = 0;
        }
        public GenTest(double _cost, double _aproxTime)
        {
            baseCost = _cost;
            cost = baseCost;
            baseAproxTime = _aproxTime;
            aproxTime = baseAproxTime;
            result = new List<bool>();
            result.Add(false);
            method = 0;
        }
    }
}
