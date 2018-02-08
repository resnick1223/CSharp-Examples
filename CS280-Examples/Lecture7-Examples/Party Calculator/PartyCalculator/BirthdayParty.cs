using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty__first_version_
{
    public class BirthdayParty : Party
    {

        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            :base(numberOfPeople, fancyDecorations)
        {
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                return CakeWriting.Length > MaxWritingLength() ? MaxWritingLength() : CakeWriting.Length;
            }
        }

        private int CakeSize()
        {
            return NumberOfPeople <= 4 ? 8 : 16;
        }

        private int MaxWritingLength()
        {
            return CakeSize() == 8 ? 16 : 40;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                return CakeWriting.Length > MaxWritingLength();
            }
        }

        public override decimal Cost
        {
            get
            {
                decimal cakeCost = CakeSize() == 8 ? 40M : 75M;
                cakeCost += ActualLength * .25M;

                return base.Cost + cakeCost;
            }
        }
    }
}