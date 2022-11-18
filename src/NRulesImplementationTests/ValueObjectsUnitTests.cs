namespace NRulesImplementation.Tests
{
    using NRulesImplementation.Layers.Domain.ValueObjects;
    public class ValueObjectsUnitTests
    {
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