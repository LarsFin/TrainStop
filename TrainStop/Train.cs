namespace TrainStop
{
    public class Train
    {
        private readonly string name;
        private readonly bool inJourney;

        public Train(string name)
        {
            this.name = name;
        }

        public void StartJourney()
        {

        }

        public string GetName() => name;

        public bool IsInJourney() => inJourney;
    }
}
