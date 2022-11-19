using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NRulesImplementation.Layers.Domain.ValueObjects
{
    public class AmountDate
    {
        public int Value { get; private set; }
        private DateTime _datetime = default;

        private static string expression = "^(?'Year'(?:[2][0]|[1][9])(?:[0-9]{2,2}))(?'Month'(?:[0][1-9]|[1][0-2]))(?'Day'[0-2][1-9]|[3][0-1]|[1,2][0])$";
        public AmountDate(DateTime dateTime)
        {
            _datetime = dateTime;
            Value = int.Parse(dateTime.ToString("yyyyMMdd"));
        }
        #region Public Static Methods
        public static string Expression
        {
            get { return expression; }
        }
        #endregion

        #region Other Properties
            public DateTime DateTime { get { return _datetime; } }
        #endregion
        public AmountDate(int value)
        {
            Match match = Regex.Match(value.ToString(), Expression);

            if (!match.Success)
            {
                throw new Exception($"{value} invalid integer date provided. Only the values 19900101 through 20991231.");
            }

            try
            {
                //validate that the date provide can acctually be a date.
                //get 3 groups to access.
                /*

                    Year
                    Month
                    DaY

                */
                Group year = match.Groups["Year"];
                Group month = match.Groups["Month"];
                Group day = match.Groups["Day"];


                _datetime = new DateTime(int.Parse(year.Value), int.Parse(month.Value), int.Parse(day.Value));
                Value = value;
            }
            catch
            {
                throw new Exception($"{value} invalid integer date provided. Only the values 19900101 through 20991231.");
            }

        }
    }
}
