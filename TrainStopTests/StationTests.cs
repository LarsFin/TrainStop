using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
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

        [TestMethod]
        [Description("Tests to make sure a Train is added to a Station")]
        public void TrainIsAddedTest()
        {
            var mockTrain = new Mock<Train>("Mock-Train");
            mockTrain.Setup(train => train.IsInJourney()).Returns(true);
            station.ReceiveTrain(mockTrain.Object);
            Assert.IsTrue(station.GetTrains().Contains(mockTrain.Object));
        }

        [TestMethod]
        [Description("Tests to make sure only moving Trains can be added to Station")]
        [ExpectedException(typeof(ArgumentException), "Train is not on journey!")]
        public void StoppedTrainCannotBeAddedTest()
        {
            var mockTrain = new Mock<Train>("Mock-Train");
            station.ReceiveTrain(mockTrain.Object);
        }
    }
}
