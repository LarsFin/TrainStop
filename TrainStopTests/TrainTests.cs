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
        public void SetUp()
        {
            train = new Train(name);
        }

        [TestMethod]
        [Description("Tests to see if name has been set in initialisation of Train")]
        public void SetNameTest()
        {
            Assert.AreEqual(name, train.GetName());
        }

        [TestMethod]
        [Description("Tests to see that train is initialised as not being in a journy")]
        public void InitialJouneyStateTest()
        {
            Assert.IsFalse(train.IsInJourney());
        }

        [TestMethod]
        [Description("Tests to see that train can be set in motion")]
        public void CanSetInJourneyTest()
        {
            train.StartJourney();
            Assert.IsTrue(train.IsInJourney());
        }

        [TestMethod]
        [Description("Tests to see that train motion can be stopped")]
        public void CanStopInJourneyTest()
        {
            train.StartJourney();
            train.StopJourney();
            Assert.IsFalse(train.IsInJourney());
        }

    }
}
