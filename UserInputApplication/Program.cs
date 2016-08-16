namespace UserInputApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();
            ui.PromptInput();
            ui.ProcessInput();
        }
    }
}
