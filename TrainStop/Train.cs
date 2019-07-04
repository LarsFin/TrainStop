namespace TrainStop
{
    public class Train
    {
        private readonly string name;
        private bool inJourney;

        public Train(string name)
        {
            this.name = name;
        }

        public void StartJourney()
        {
            inJourney = true;
        }

        public void StopJourney()
        {
            
        }

        public string GetName() => name;

        public bool IsInJourney() => inJourney;
    }
}
