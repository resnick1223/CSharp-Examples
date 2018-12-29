using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthdayParty__first_version_
{
    public class Party
    {
        public Party(int numberOfPeople, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }

        public const int CostOfFoodPerPerson = 25;
        public bool FancyDecorations { get; set; }

        public int NumberOfPeople { get; set; }

        public virtual decimal Cost
        {
            get
            {
                return CalculateCostOfDecorations() + CostOfFoodPerPerson * NumberOfPeople;
            }
        }

        protected decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }
    }
}