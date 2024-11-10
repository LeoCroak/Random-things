using System;
using System.Threadding;

namespace Countdown {
    class Timerlogic {
        public static void Main(string[] args) {

            int chosentime = int.Parse(Console.ReadLine()); // collects user input 

            for (chosentime; chosentime > 0; chosentime--) // timer logic
            {
                Console.WriteLine(chosentime)
                Thread.Sleep(1000)
            }

            Console.WriteLine("Time is up")
        }
    }
}