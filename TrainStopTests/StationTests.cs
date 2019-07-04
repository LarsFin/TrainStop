using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TrainStop;

namespace TrainStopTests
{
    [TestClass]
    public class StationTests
    {
        Station station;
        string name = "London Waterloo";

        [TestInitialize]
        public void SetUp()
        {
            station = new Station(name);
        }

        [TestMethod]
        [Description("Tests to see if name has been set in intiliasation of Station")]
        public void SetNameTest()
        {
            Assert.AreEqual(name, station.GetName());
        }

        [TestMethod]
        [Description("Tests to see if a List has been created in a Station to store Trains")]
        public void SetTrainListTest()
        {
            Assert.IsInstanceOfType(station.GetTrains(), typeof(List<Train>));
        }

        [TestMethod]
        [Description("Tests to check that train list in Station is empty upon initialisation")]
        public void InitiallyEmptyTrainListTest()
        {
            Assert.IsTrue(station.IsEmpty());
        }
    }
}
