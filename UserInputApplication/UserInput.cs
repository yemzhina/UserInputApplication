using System;

namespace UserInputApplication
{
    class UserInput
    {
        public string Input { get; set; }

        public void PromptInput()
        {
            Console.WriteLine("Enter value");
            Input = Console.ReadLine();
        }

        public char GetFirstChar()
        {
            return Input[0];
        }

        public void ProcessInput()
        {
            try
            {
                Console.WriteLine($"First char in the string: '{GetFirstChar()}'");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
