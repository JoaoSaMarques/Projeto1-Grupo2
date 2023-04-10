using System;

//Will be used to toggle the lamp states later on
void ToggleLamps(int index1, int index2)
{
    ToggleLamp(index1);
    ToggleLamp(index2);
}

//Call this in main to start the program.
void PlayGame()
{
    //As told in the project we will have a maximum of 6 turns to successfully do the puzzle.
    int numTurns = 0;
    //While below those 6 turns then:
    while (numTurns < 6 && (lamps[0] == LampState.Off || lamps[1] == LampState.Off || lamps[2] == LampState.Off))
    {
        //It will tell you to press the buttons
        Console.WriteLine("Press a button (1, 2, or 3):");
        //Convert value into an int.
        int button = int.Parse(Console.ReadLine());

        //Switch the int into cases.
        switch (button)
        {
            case 1:
                ToggleLamp(0);
                break;
            case 2:
                ToggleLamps(0, 1);
                break;
            case 3:
                ToggleLamps(1, 2);
                break;
            default:
                Console.WriteLine("Invalid button.");
                break;
        }
        //Increase the num of turns per case.
        numTurns++;

        //Which turn you are on
        Console.WriteLine($"Turn {numTurns}:");
        Console.WriteLine($"Lamp 1: {lamps[0]}");
        Console.WriteLine($"Lamp 2: {lamps[1]}");
        Console.WriteLine($"Lamp 3: {lamps[2]}");
        //How many buttons have you pressed
        Console.WriteLine($"Total button presses: {numTurns}");
    }
    //Win condition
    if (lamps[0] == LampState.On && lamps[1] == LampState.On && lamps[2] == LampState.On)
    {
        Console.WriteLine($"Congratulations, you solved the puzzle in {numTurns} button presses!");
    }
    //Fail condition
    else
    {
        Console.WriteLine("Sorry, you didn't solve the puzzle in time.");
    }
}

namespace ProjetoLP1
{
    
    class Program
    {
        //Define the state of which the lamps will be at
        public enum LampState
        {
            On,
            Off
        }
        static void Main(string[] args)
        {
            //Create a list for the states (all of them start off)
            LampState[] lamps = new LampState[3] { LampState.Off, LampState.Off, LampState.Off };

            PlayGame();
        }
    }
}
