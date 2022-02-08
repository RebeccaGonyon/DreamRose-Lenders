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
            Lender lender = new Lender
            {
                ContactFirstName = "Chelsea",
                ContactLastName = "Russell"
            };
            string expected = "Russell, Chelsea";

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
            string expected = "Russell";

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
            string expected = "Chelsea";

            //--Act
            string actual = lender.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            _ = new Lender
            {
                ContactFirstName = "Chelsea",
                ContactLastName = "Russell"
            };
            Lender.InstanceCount = +1;
            _ = new Lender
            {
                ContactFirstName = "James",
                ContactLastName = "Russell"
            };
            Lender.InstanceCount = +1;
            _ = new Lender
            {
                ContactFirstName = "Nathan",
                ContactLastName = "Russell"
            };
            Lender.InstanceCount = +1;

            //--Act

            //--Assert
            Assert.AreEqual(3, Lender.InstanceCount);
        }
    }
}




