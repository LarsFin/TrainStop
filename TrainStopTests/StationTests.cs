﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        [Description("Tests to make sure 'stopJourney' is called on received trains")]
        public void ReceivedTrainIsStopped()
        {
            var mockTrain = new Mock<Train>("Mock-Train");
            mockTrain.Setup(train => train.IsInJourney()).Returns(true);
            station.ReceiveTrain(mockTrain.Object);
            mockTrain.Verify(train => train.StopJourney(), Times.Once());
        }

        [TestMethod]
        [Description("Tests to make sure a train can be released from a station")]
        public void TrainIsReleasedTest()
        {
            string trainName = "Mock-Train";
            var mockTrain = new Mock<Train>(trainName);
            mockTrain.Setup(train => train.IsInJourney()).Returns(true);
            station.ReceiveTrain(mockTrain.Object);
            mockTrain.Setup(train => train.IsInJourney()).Returns(false);
            mockTrain.Setup(train => train.GetName()).Returns(trainName);
            station.ReleaseTrain(trainName);
            Assert.IsTrue(station.IsEmpty());
        }

        [TestMethod]
        [Description("Tests to make sure an exception is thrown when releasing a missing train")]
        [ExpectedException(typeof(ArgumentException), "Train does not exist at station")]
        public void MissingTrainCannotBeReleasedTest()
        {
            station.ReleaseTrain("Non-existant Train");
        }
    }
}
