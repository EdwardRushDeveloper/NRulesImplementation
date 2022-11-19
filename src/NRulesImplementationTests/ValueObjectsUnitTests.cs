namespace NRulesImplementation.Tests
{
    using NRulesImplementation.Layers.Domain.ValueObjects;
    public class ValueObjectsUnitTests
    {
        [Fact]
        public void AmountDateFromIntegerAssertTests()
        {
            //Arrange
            int validDateOne = 19900101;
            DateTime validDateOneDate = new DateTime(1990, 1, 1);
            int validDateTwo = 20991231;
            DateTime validDateTwoDate = new DateTime(2099, 12, 31);

            int invalidDate  = 23002365;


            bool validDateOneAssert = true;
            bool validDateTwoAssert = true;
            bool invalidDateAssert  = false;

            DateTime now = DateTime.Now;

            //assigning default values to prevent compiler exceptons.
            AmountDate amountDateOne = new AmountDate(now);
            AmountDate amountDateTwo= new AmountDate(now);
            AmountDate amountInvalidDate= new AmountDate(now);

            //Act
            // When the constructor creation fails, the value will be set to False
            try
            {
                 amountDateOne = new AmountDate(validDateOne);
            }
            catch
            {
                validDateOneAssert = false;
            }

            try
            {
                amountDateTwo = new AmountDate(validDateTwo);
            }
            catch
            {
                validDateTwoAssert = false;
            }

            try
            {
                 amountInvalidDate = new AmountDate(invalidDate);
            }
            catch
            {
                invalidDateAssert = true;
            }
            //Assert

            Assert.True(validDateOneAssert);
            Assert.True(validDateTwoAssert);
            Assert.True(invalidDateAssert);

            Assert.Equal<DateTime>(validDateOneDate, amountDateOne.DateTime);
            Assert.Equal<DateTime>(validDateTwoDate, amountDateTwo.DateTime);

        }

        [Fact]
        public void InvoiceNumberNoDecimalsTest()
        {
            //Arrange
            string invoiceNumber = "1.0";
            bool assertValue = false;

            //Act
            try
            {
                InvoiceNumber invoiceObject = new InvoiceNumber(invoiceNumber);
            }
            catch
            {
                assertValue = true;
            }

            //Assert
            Assert.True(assertValue);

        }

        [Fact]
        public void InvoiceNumberCreateFailureTest()
        {
            //Arrange
            string invoiceNumber = "TEST00000";
            bool assertValue = false;

            //Act
            try
            {
                InvoiceNumber invoiceObject = new InvoiceNumber(invoiceNumber);
            }
            catch
            {
                assertValue = true;
            }

            //Assert
            Assert.True(assertValue);         

        }
        [Fact]
        public void InvoiceNumberCreateSuccessTest()
        {
            //Arrange
            string invoiceNumber = "1";
            bool assertException = false;

            //Act

            InvoiceNumber invoiceObject = null;

            try
            {
                invoiceObject = new InvoiceNumber(invoiceNumber);
            }
            catch
            {
                assertException = true;
            }

            //Assert

            Assert.False(assertException);
            Assert.NotNull(invoiceObject);
            Assert.Equal("0000000001", invoiceObject.Value);

        }
    }
}