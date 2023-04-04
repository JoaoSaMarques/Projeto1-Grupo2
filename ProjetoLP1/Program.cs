using System;

//Define the state of which the lamps will be at
public enum LampState
{
    On,
    Off
}

//Create a list for the states (all of them start off)
LampState[] lamps = new LampState[3] { LampState.Off, LampState.Off, LampState.Off };

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
