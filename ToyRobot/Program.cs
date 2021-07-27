using System;

namespace ToyRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = String.Empty;

            Robot robot = new Robot();

            Console.WriteLine("Robot initialised. Enter commands to send to Robot: (E at any time to quit)");

            while (true)
            {
                Console.WriteLine("Enter command for Robot:");
                command = Console.ReadLine();

                if (command.ToUpper().Equals("E"))
                    break;

                Console.WriteLine(robot.command(command));
                Console.WriteLine();
            }
            Console.WriteLine("Exited - press any key to close");
            Console.ReadLine();
        }
    }
}
