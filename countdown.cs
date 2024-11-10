// original code found on https://github.com/LeoCroak/Random-things/blob/main/countdown.cs
using System;
using System.Threading; // Corrected the namespace

namespace Countdown {
    class Timerlogic {
        public static void Main(string[] args) {

            int chosentime = int.Parse(Console.ReadLine()); // Collects user input 

            for (chosentime; chosentime > 0; chosentime--) { // Timer logic
                Console.WriteLine(chosentime); // Display the countdown
                Thread.Sleep(1000); // Wait for 1 second (1000 milliseconds)
            }

            Console.WriteLine("Time is up!"); // Message when the countdown reaches 0
        }
    }
}
