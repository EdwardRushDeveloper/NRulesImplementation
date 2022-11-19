using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRulesImplementation.Layers.Domain
{
    public  class Amount
    {
        private Amount() { }

        public Amount(AmountType amountType, string description, int startDate, int endDate) 
        {
            AmountType = amountType;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }
        public AmountType AmountType { get; }
        public string Description { get; }
        public int StartDate { get; }
        public int EndDate { get; }
        public decimal Value
        {
            get; set;
        }

        
    }
}
