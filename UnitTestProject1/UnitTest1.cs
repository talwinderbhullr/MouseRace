using Microsoft.VisualStudio.TestTools.UnitTesting;
using MouseRace_Project;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //this test should pass because the DinoNumber assigned to "Diplodocus in the factory is 0
        public void DinoSuccess()
        {
            MouseRace_Project.Factory.ChooseDino("Diplodocus");

            Assert.AreEqual(0, Factory.DinoNumber);

        }
        [TestMethod]
        //this test should fail because the DinoNumber assigned to "Diplodocus in the factory is not 1
        public void DinoFail()
        {
            MouseRace_Project.Factory.ChooseDino("Diplodocus");

            Assert.AreEqual(1, Factory.DinoNumber);

        }

        [TestMethod]
        //this test should pass because the number 1 is equal to the DinoNumber for "Ankylosaurus"
        public void Dinotesing()
        {
            MouseRace_Project.Factory.ChooseDino("Ankylosaurus");

            Assert.IsTrue(1 == Factory.DinoNumber);

        }



    }
}
