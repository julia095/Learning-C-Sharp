using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_If_String_Ends_With_E_Then_We_Get_Success_Message()
        {
            // Arrange
            string enterValue = "some";
            string successMessage = "success";
            // Act


            //Assert
            Assert.AreEqual(enterValue, successMessage);
            
        }
        [TestMethod]
        public void Check_If_Values_Are_Equal ()
        {
            // Arrange
            int enterValue = 5;
            int successMessage = 5;
            // Act


            //Assert
            Assert.AreEqual(enterValue, successMessage);

        }
    }
}
