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
        [Description("Tests to see if name has been set in initialisation of Train")]
        public void setNameTest()
        {
            Assert.AreEqual(name, train.GetName());
        }

        [TestMethod]
        [Description("Tests to see that train is initialised as not being in a journy")]
        public void initialJouneyStateTest()
        {
            Assert.IsFalse(train.IsInJourney());
        }

    }
}
