namespace Trains {
    public class FreightTrain : Train {
        private int maxSize;
        private int maxWeight;

        public FreightTrain(string name, int maxSize, int maxWeight) : base(name) {
            this.maxSize = maxSize;
            this.maxWeight = maxWeight;
        }
        
    }
}
