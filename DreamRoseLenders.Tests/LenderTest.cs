using DreamRoseLenders.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DreamRoseLenders.Tests
{
    [TestClass]
    public class LenderTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Lender lender = new()
            {
                ContactFirstName = "Chelsea",
                ContactLastName = "Russell"
            };
            string expected = "Chelsea Russell";

            //--Act
            string actual = lender.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Lender lender = new Lender()
            {
                ContactLastName = "Russell"
            };
            string expected =  " Russell";

            //--Act
            string actual = lender.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Lender lender = new Lender()
            {
                ContactFirstName = "Chelsea"
            };
            string expected = "Chelsea ";

            //--Act
            string actual = lender.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
}




