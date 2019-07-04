using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainStop;

namespace TrainStopTests
{
    [TestClass]
    public class TrainTests
    {

        Train train;
        string name = "SWR820";

        [TestInitialize]
        public void setUp()
        {
            train = new Train(name);
        }

        [TestMethod]
        public void setNameTest()
        {
            Assert.AreEqual(name, train.getName());
        }

        [TestMethod]
        public void initialJouneyStateTest()
        {
            Assert.IsFalse(train.isInJourney());
        }

    }
}
