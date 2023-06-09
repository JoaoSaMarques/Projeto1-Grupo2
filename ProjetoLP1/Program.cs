<<<<<<< HEAD
using System;

namespace ProjetoLP1
{

    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /// <summary>
            /// Player's Explanation. How the Games Work.
            // </summary>
            Console.WriteLine();
            Console.WriteLine($"Welcome player, to the Most Wonderful Game of all the time!");
            Console.WriteLine($"THE LIGHTS SWITCHES!");

            Console.WriteLine();

            Console.WriteLine($"All you need to do is within 6 Turns, have all the Lamps On.");
            Console.WriteLine($"By typing a Lamp's Number, you will be able to change their states, from Off to On and so on.");
                
            Console.WriteLine();
            Console.WriteLine($"But be careful! Some Lamps are tricky, we will be giving you a hint: ");

            Console.WriteLine();

            Console.WriteLine($"Lamp 1 changes only itself;\n" +
                "Lamp 2 changes itself and Lamp 1 state;\n" +
                "Lamp 3 changes itself and Lamp 2 state;\n");

            /// <summary>
            /// Paragraph
            /// </summary>
            Console.WriteLine();

            /// <summary>
            /// Reading keys Player's Input
            /// </summary>
            Console.WriteLine($"Press any key to start playing the game...");
            Console.ReadLine();

            Console.WriteLine();

            PlayGame();
        }

        static void PlayGame()
        {
            /// <summary>
            /// Create a list
            /// </summary>
            /// <value></value>
            LampState[] lamps = new LampState[3] { LampState.Off, LampState.Off, LampState.Off };
            int numTurns = 0;

            /// <summary>
            /// Toggle Lamp States
            /// </summary>
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
                /// Asks for User Input
                /// </summary>
                Console.WriteLine($"Type a Lamp Number - 1, 2 or 3: ");

                int button = int.Parse(Console.ReadLine());

                switch (button)
                {
                    case 1:
                        /// <summary>
                        /// Changes 1st Lamp
                        ///</summary>
                        ToggleLamp(0);

                        /// <summary>
                        /// Paragraph
                        /// </summary>
                        Console.WriteLine();
                        break;
                    case 2:
                        /// <summary>
                        /// Changes 1st Lamp and 2nd Lamp
                        /// </summary>
                        ToggleLamps(0, 1);

                        /// <summary>
                        /// Paragraph
                        /// </summary>
                        Console.WriteLine();
                        break;
                    case 3:
                        /// <summary>
                        /// Changes 2nd Lamp and 3rd Lamp
                        /// </summary>
                        ToggleLamps(1, 2);

                        /// <summary>
                        ///Paragraph
                        ///</summary>
                        Console.WriteLine();
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
                Console.WriteLine($"Turn {numTurns}");
                Console.WriteLine($"Lamp 1: {lamps[0]}");
                Console.WriteLine($"Lamp 2: {lamps[1]}");
                Console.WriteLine($"Lamp 3: {lamps[2]}");

                /// <summary>
                /// How many buttons have you pressed
                /// </summary>
                /// <value></value>
                Console.WriteLine($"Total button presses: {numTurns}");

                /// <summary>
                /// Win Condition. All Lamps are On and the Turns is lower or equal to 6
                /// </summary>
                if (lamps[0] == LampState.On && lamps[1] == LampState.On && lamps[2] == LampState.On && numTurns <= 6)
                {
                    Console.WriteLine($"Congratulations, you solved the puzzle in {numTurns} button presses!");
                    Console.WriteLine();
                    break;
                }
                /// <summary>
                /// Fail Condition (Exceeded 6 Turns)
                /// Since it starts counting from 0, the 6th turn, is equal to 5.
                /// </summary>
                else if (numTurns > 5)
                {
                    Console.WriteLine($"Sorry, you didn't solve the puzzle in time.");
                    Console.WriteLine();
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