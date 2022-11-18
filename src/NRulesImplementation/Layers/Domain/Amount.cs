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

        public Amount(AmountType amountType, string description) {
            AmountType = amountType;
            Description = description;
        }
        public AmountType AmountType { get; }
        public string Description { get; }
        public decimal Value
        {
            get; set;
        }
    }
}
