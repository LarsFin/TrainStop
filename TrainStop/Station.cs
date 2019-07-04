namespace TrainStop
{
    public class Station
    {
        private readonly string name;

        public Station(string name)
        {
            this.name = name;
        }

        public string GetName() => name;
    }
}
