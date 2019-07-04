using System;
namespace TrainStop
{
    public class Station
    {
        private string name;

        public Station(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
