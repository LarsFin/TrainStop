namespace TrainStop
{
    public class Train
    {
        private string name;
        private bool inJourney;

        public Train(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public bool isInJourney()
        {
            return inJourney;
        }
    }
}
