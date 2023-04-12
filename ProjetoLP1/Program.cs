using System;

namespace ProjetoLP1
{
    //Define the state of which lamps will be at
    public enum LampState
    {
        On,
        Off
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            //Create a list of states (all of them start off)
            LampState[] lamps = new LampState[3] { LampState.Off, LampState.Off, LampState.Off};

            //Will be used to toggle the lamp states later on
            void ToggleLamps(int index1, int index2)
            {
                ToggleLamp(index1);
                ToggleLamp(index2);
            }

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

            //Creates a paragraph
            Console.WriteLine();
            //Asks for user input
            Console.WriteLine("Press a button - 1, 2 ou 3: ");
            int button = int.Parse(Console.ReadLine());

            switch (button)
            {
                case 1:
                    ToggleLamp(0);
                    //Just a simulation
                    Console.WriteLine("The First Lamp turned On.");
                    break;
                case 2:
                    ToggleLamps(0, 1);
                    //Just a simulation
                    Console.WriteLine("The First Lamp turned Off, The Second Lamp turned On.");
                    break;
                case 3:
                    ToggleLamps(1, 2);
                    //Just a simulation
                    Console.WriteLine("The Second Lamp turned Off, The Third Lamp turned On.");
                    break;
                default:
                    Console.WriteLine("Invalid Button.");
                    break;
            }

        }

        }
    }
}
