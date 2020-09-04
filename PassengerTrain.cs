namespace Trains {
    public class PassengerTrain : Train {
        private int maxPassengers;
        public PassengerTrain(string name, int maxPas) : base(name) {
            this.maxPassengers = maxPas;
        }
    }
}