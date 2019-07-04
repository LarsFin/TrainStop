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
                throw new ApplicationException("Train is not on journey!");
            }
            train.StopJourney();
            trains.Add(train);
        }

        // Releases a train from the station by passing the train name
        public void ReleaseTrain(string name)
        {
            bool validCall = false;
            for (int i = 0; i < trains.Count; i++)
            {
                if (trains[i].GetName() == name)
                {
                    validCall = true;
                    trains[i].StartJourney();
                    trains.Remove(trains[i]);                
                }
            }
            if (!validCall)
            {
                throw new ApplicationException("Train does not exist at station");
            }
        }

        // Returns the name of the station.
        public string GetName() => name;

        // Returns the list of trains within the station.
        public List<Train> GetTrains() => trains;

        // Returns whether or not the station holds any trains.
        public bool IsEmpty() => trains.Count == 0;
    }
}
