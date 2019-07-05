using System;
using System.Collections.Generic;

namespace TrainStop
{
    public class Station
    {
        private readonly string name;
        private readonly List<Train> trains;
        private const int DEFAULT_CAPACITY = 6;
        private readonly int capacity;
        private bool underMaintenance;

        public Station(string name)
        {
            this.name = name;
            trains = new List<Train>();
            capacity = DEFAULT_CAPACITY;
        }

        public Station(string name, int customCapacity)
        {
            this.name = name;
            trains = new List<Train>();
            capacity = customCapacity;
        }

        // Station receives a train into its platforms
        public void ReceiveTrain(Train train)
        {
            if (trains.Count == capacity)
            {
                throw new ApplicationException("Full! Cannot accept anymore trains");
            }
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
            Train train;
            for (int i = 0; i < trains.Count; i++)
            {
                train = trains[i];
                if (train.GetName() == name)
                {
                    if (train.IsInJourney())
                    {
                        throw new ApplicationException("Cannot release moving train!");
                    }
                    validCall = true;
                    train.StartJourney();
                    trains.Remove(train);                
                }
            }
            if (!validCall)
            {
                throw new ApplicationException("Train does not exist at station");
            }
        }

        // Starts maintenance on a station
        public void StartMaintenance()
        {
            underMaintenance = true;
        }

        // Returns the name of the station.
        public string GetName() => name;

        // Returns the list of trains within the station.
        public List<Train> GetTrains() => trains;

        // Returns whether or not the station holds any trains.
        public bool IsEmpty() => trains.Count == 0;

        // Returns the default capacity of the station.
        public int GetDefaultCapacity() => DEFAULT_CAPACITY;

        // Returns the capacity of the station.
        public int GetCapacity() => capacity;

        // Returns whether or not the station is under maintenance
        public bool IsUnderMaintenace() => underMaintenance;
    }
}
