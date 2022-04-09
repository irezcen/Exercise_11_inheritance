using System;
using System.Collections.Generic;
using System.Text;

namespace C1_labolatorium_genetyczne_hierarchia_dziedziczeniea_
{
    class Sanger:GenTest
    {
        private int gene;
        public int Gene
        {
            get
            {
                return gene;
            }
        }
        public void ChooseGene(int _gene)
        {
            if(_gene >0 || _gene <= 22000)
            {
                if(gene % 3 == 1)
                {
                    cost = cost * (5/6);
                }
                gene = _gene;
                if (gene % 3 == 1)
                {
                    cost = cost * 1.2;
                }
            }
            else
            {
                gene = 0;
            }
        }
        public Sanger(double _cost, double _aproxTime):base(_cost, _aproxTime)
        {
            gene = 0;
        }
        public Sanger(int _gene,double _cost, double _aproxTime) : base(_cost, _aproxTime)
        {
            gene = _gene;
        }
    }
}
