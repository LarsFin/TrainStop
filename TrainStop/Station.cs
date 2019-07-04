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

        public void ReceiveTrain(Train train)
        {

        }

        public string GetName() => name;

        public List<Train> GetTrains() => trains;

        public bool IsEmpty() => trains.Count == 0;
    }
}
