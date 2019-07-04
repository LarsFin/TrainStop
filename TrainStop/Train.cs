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

        // Begins a journey for a Train
        public virtual void StartJourney()
        {
            inJourney = true;
        }

        // Stops a journey for a Train
        public virtual void StopJourney()
        {
            inJourney = false;
        }

        // Returns the private name variable of the Train
        public virtual string GetName() => name;

        // Returns the status of a Train's journy
        public virtual bool IsInJourney() => inJourney;
    }
}
