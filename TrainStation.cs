using System;

namespace Trains {
    public class TrainStation {
        private string name;
        Train[] trains = new Train[5];
        

        public TrainStation(string n) {
            Console.WriteLine(n);
            name = n;
        } 


        public bool AddTrain(Train train) {
            bool success = false;
            for(int i=0; i < trains.Length; i++) {
                if(trains[i] == null) {
                    trains[i] = train;
                    success = true;
                    break;
                }
            }
            return success;
        }
















        // public bool AddTrain(Train t) {
        //     for(int i=0; i < trains.Length; i++) {
        //         if(trains[i] == null) {
        //             trains[i] = t;
        //             return true;
        //         }
        //     }
        //     return false;
        // }

        public void setName(string name) {
            this.name = name;
        }
        public string getName() {
            return name;
        }

    }
}