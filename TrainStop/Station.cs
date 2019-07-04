using System;
using System.Collections.Generic;

namespace TrainStop
{
    public class Station
    {
        private readonly string name;
        private readonly List<Train> trains;

        public Station(string name)
        {
            this.name = name;
            trains = new List<Train>();
        }

        // Station receives a train into its platforms
        public void ReceiveTrain(Train train)
        {
            if (!train.IsInJourney())
            {
                throw new ArgumentException("Train is not on journey!");
            }
            trains.Add(train);
        }

        // Returns the name of the station.
        public string GetName() => name;

        // Returns the list of trains within the station.
        public List<Train> GetTrains() => trains;

        // Returns whether or not the station holds any trains.
        public bool IsEmpty() => trains.Count == 0;
    }
}
