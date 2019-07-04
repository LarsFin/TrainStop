using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainStop;

namespace TrainStopTests
{
    [TestClass]
    public class StationTests
    {

        Station station;
        string name = "London Waterloo";

        [TestInitialize]
        public void setUp()
        {
            station = new Station(name);
        }

        [TestMethod]
        public void setNameTest()
        {
            Assert.AreEqual(name, station.GetName());
        }

    }
}
