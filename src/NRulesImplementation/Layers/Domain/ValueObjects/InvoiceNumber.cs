using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NRulesImplementation.Layers.Domain.ValueObjects
{
    public class InvoiceNumber
    {
        
        
           public string Value { get; private set; }

        /*
            ^ asserts position at start of the string
            \+ matches the character + with index 4310 (2B16 or 538) literally (case sensitive)
            ? matches the previous token between zero and one times, as many times as possible, giving back as needed (greedy)
            \d matches a digit (equivalent to [0-9])
            {1,10} matches the previous token exactly 10 times
            $ asserts position at the end of the string, or before the line terminator right at the end of the string (if any)
       */
        /// <summary>
        /// Minimum 10 Digits, Maximum 10 Digits. Padding will be applied
        /// </summary>
        private static string _invoiceNumberExpression = "^\\+?\\d{1,10}$";

        #region Public Static Methods
            public static string InvoiceNumberExpression { get { return _invoiceNumberExpression; } }
        #endregion

        public InvoiceNumber(string value)
        {
            var result = Regex.Match(value, InvoiceNumberExpression);
            if (!result.Success)
            {
                throw new Exception($"{value} is an invalid number. Only digits with a maximum of 10 are allowed.");
            }

            Value = String.Format("{0:0000000000}", int.Parse(value));
        }
    }
}
