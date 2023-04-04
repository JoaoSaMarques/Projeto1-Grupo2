using System;

//Define the state of which the lamps will be at
public enum LampState
{
    On,
    Off
}

//Create a list for the states (all of them start off)
LampState[] lamps = new LampState[3] { LampState.Off, LampState.Off, LampState.Off };

//Will be used to toggle the lamp states later on
void ToggleLamps(int index1, int index2)
{
    ToggleLamp(index1);
    ToggleLamp(index2);
}

namespace ProjetoLP1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
