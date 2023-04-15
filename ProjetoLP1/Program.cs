using System;

namespace ProjetoLP1
{
    /// LampState
    public enum LampState
    {
        On,
        Off
    }

    class Program
    {
        /// Main
        static void Main(string[] args)
        {
            PlayGame();
        }

        static void PlayGame()
        {
            /// Create a list
            LampState[] lamps = new LampState[3] { LampState.Off, LampState.Off, LampState.Off };
            int numTurns = 0;

            /// Toggle Lamp States
            void ToggleLamps(int index1, int index2)
            {
                ToggleLamp(index1);
                ToggleLamp(index2);
            }
            /// Define the lamp toggles
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
                /// Paragraph
                Console.WriteLine();
                /// Asks for user input
                Console.WriteLine($"Press a button - 1, 2 ou 3: ");
                int button = int.Parse(Console.ReadLine());

                switch (button)
                {
                    case 1:
                        ToggleLamp(0); /// Changes 1st Lamp
                        Console.WriteLine(); /// Paragraph
                        break;
                    case 2:
                        ToggleLamps(0, 1); /// Changes 1st Lamp and 2nd Lamp
                        Console.WriteLine(); /// Paragraph
                        break;
                    case 3:
                        ToggleLamps(1, 2); /// Changes 2nd Lamp and 3rd Lamp
                        Console.WriteLine(); /// Paragraph
                        break;
                    default:
                        Console.WriteLine("Invalid Button.");
                        break;
                }
                /// Increase the number of turns you have done
                numTurns++;

                /// Which turn you are on
                Console.WriteLine($"Turn {numTurns}");
                Console.WriteLine($"Lamp 1: {lamps[0]}");
                Console.WriteLine($"Lamp 2: {lamps[1]}");
                Console.WriteLine($"Lamp 3: {lamps[2]}");

                /// How many buttons have you pressed
                Console.WriteLine($"Total button presses: {numTurns}");

                /// Win Condition. All Lamps are On and the Turns is lower or equal to 6
                if (lamps[0] == LampState.On && lamps[1] == LampState.On && lamps[2] == LampState.On && numTurns <= 6)
                {
                    Console.WriteLine($"Congratulations, you solved the puzzle in {numTurns} button presses!");
                    Console.WriteLine(); /// Paragraph
                    break;
                }
                else if (numTurns > 5) /// Since it starts counting from 0, the 6th turn, is equal to 5.
                {
                    /// Fail Condition (Exceeded 6 Turns)
                    Console.WriteLine($"Sorry, you didn't solve the puzzle in time.");
                    Console.WriteLine(); /// Paragraph
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

