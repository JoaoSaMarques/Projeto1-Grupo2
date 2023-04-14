using System;

namespace ProjetoLP1
{
    /// <summary>
    /// LampState
    /// </summary>
    public enum LampState
    {
        On,
        Off
    }

    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PlayGame();
        }

        static void PlayGame()
        {
            /// <summary>
            /// Create a list
            /// </summary>
            /// <value></value>
            LampState[] lamps = new LampState[3] { LampState.Off, LampState.Off, LampState.Off};
            int numTurns = 0;

            /// <summary>
            /// Toggle Lamp States
            /// </summary>
            /// <param name="index1"></param>
            /// <param name="index2"></param>
            void ToggleLamps(int index1, int index2)
            {
                ToggleLamp(index1);
                ToggleLamp(index2);
            }
            /// <summary>
            /// Define the lamp toggles
            /// </summary>
            /// <param name="index"></param>
            void ToggleLamp(int index)
            {
                if (lamps[index] == LampState.On)
                {
                    lamps[index] = LampState.Off;
                }
                else
                {
                    lamps[index] = LampState.On;
                }
            }

            while (true)
            {
                /// <summary>
                /// Paragraph
                /// </summary>
                Console.WriteLine();
                /// <summary>
                /// Asks for user input
                /// </summary>
                Console.WriteLine("Press a button - 1, 2 ou 3: ");
                int button = int.Parse(Console.ReadLine());

                switch (button)
                {
                    case 1:
                        ToggleLamp(0);
                        /// <summary>
                        /// Simulation on pressing 1
                        /// </summary>
                        Console.WriteLine("The First Lamp turned On.");
                        break;
                    case 2:
                        ToggleLamps(0, 1);
                        /// <summary>
                        /// Simulation on pressing 2
                        /// </summary>
                        Console.WriteLine("The First Lamp turned Off, The Second Lamp turned On.");
                        break;
                    case 3:
                        ToggleLamps(1, 2);
                        /// <summary>
                        /// Simulation on pressing 3
                        /// </summary>
                        Console.WriteLine("The Second Lamp turned Off, The Third Lamp turned On.");
                        break;
                    default:
                        Console.WriteLine("Invalid Button.");
                        break;
                }
                /// <summary>
                /// Increase the number of turns you have done
                /// </summary>
                numTurns++;

                /// <summary>
                /// Which turn you are on
                /// </summary>
                /// <value></value>
                Console.WriteLine($"Turn {numTurns}:");
                Console.WriteLine($"Lamp 1: {lamps[0]}");
                Console.WriteLine($"Lamp 2: {lamps[1]}");
                Console.WriteLine($"Lamp 3: {lamps[2]}");
                /// <summary>
                /// How many buttons have you pressed
                /// </summary>
                /// <value></value>
                Console.WriteLine($"Total button presses: {numTurns}");

                /// <summary>
                /// Win Condition
                /// </summary>
                if (lamps[0] == LampState.On && lamps[1] == LampState.On && lamps[2] == LampState.On)
                {
                    Console.WriteLine($"Congratulations, you solved the puzzle in {numTurns} button presses!");
                    break;
                }
            }
            /// <summary>
            /// Fail Condition(Exceeded 6 turns)
            /// </summary>
            Console.WriteLine("Sorry, you didn't solve the puzzle in time.");
        }
    }
}
