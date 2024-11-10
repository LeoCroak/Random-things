// original code found on https://github.com/LeoCroak/Random-things/blob/main/countdown.cs
using System;
using System.Threading;

namespace Countdown {
    class Timerlogic {
        public static void Main(string[] args) {
            int chosentime;
            
            // Input validation
            while (true) {
                Console.Write("Enter countdown time in seconds: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out chosentime) && chosentime > 0) {
                    break; // Exit loop if valid input is provided
                } else {
                    Console.WriteLine("Please enter a valid positive number.");
                }
            }

            // Timer logic
            for (; chosentime > 0; chosentime--) {
                Console.WriteLine(chosentime);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Time is up!"); // when timer is done
        }
    }
}

