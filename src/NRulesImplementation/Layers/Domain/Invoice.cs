using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRulesImplementation.Layers.Domain
{
    public class Invoice
    {
        
        List<Item> _items = new List<Item>();
        private Invoice() { }

        public Invoice(ShipTo shipTo) 
        { 
            ShipTo= shipTo;
        }

        #region Public Properties

        public ShipTo ShipTo { get; private set; }


        #endregion

        #region Public Methods
        void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void RemoveItem(Item item) { }

        #endregion
    }
}
