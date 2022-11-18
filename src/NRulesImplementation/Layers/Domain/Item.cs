using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRulesImplementation.Layers.Domain
{
    public class Item
    {
        private List<Amount> _amounts = new List<Amount>();
        public Item() { }
        public string Name { get; set; }
        public string UPC { get; set; }

        #region Public Methods
        public void AddAmount(Amount amount)
        {
            _amounts.Add(amount);
        }

        public List<Amount> GetAmounts()
        {
            List<Amount> returnValue = new List<Amount>(_amounts);
            return returnValue;
        }
        #endregion

    }
}
