using System;

namespace Part1_CyberChatBot
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Initializes the classes for UI and the bot's brain, meaning the questions and the logic to answer those quuestions.
            UIHelper graphics = new UIHelper();
            CyberQuestions botBrain = new CyberQuestions();

            botBrain.LoadQuestions();

            // where the app actally starts. handdles greeting and the interaction with the user.
            graphics.PlayVoiceGreeting();
            graphics.ShowAsciiArt();

            graphics.TypewriterEffect("Welcome to the Cybersecurity Awareness Bot!", ConsoleColor.Cyan);
            graphics.TypewriterEffect("Before we begin, what is your name?", ConsoleColor.White);

            Console.Write(" > ");
            string userName = Console.ReadLine();

            // Input Validation for the users name.
            while (string.IsNullOrWhiteSpace(userName))
            {
                graphics.TypewriterEffect("Please enter a valid name to continue:", ConsoleColor.Red);
                Console.Write(" > ");
                userName = Console.ReadLine();
            }
            // greets the user by their name and tips on how they can use the bot.
            graphics.TypewriterEffect($"Hello, {userName}! I am here to help you stay safe online.", ConsoleColor.Cyan);
            graphics.TypewriterEffect("You can type 'topics' at any time to see what I can help you with.", ConsoleColor.Gray);

            // This is the main chat loop for the bot that i have made.
            bool isChatting = true;
            while (isChatting)
            {
                Console.WriteLine();
                graphics.TypewriterEffect("Ask me a question (or type 'exit' to quit):", ConsoleColor.Magenta);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" > ");
                string userInput = Console.ReadLine();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    graphics.TypewriterEffect("You didn't type anything!", ConsoleColor.Red);
                    continue;
                }

                if (userInput.ToLower() == "exit")
                {
                    graphics.TypewriterEffect($"Goodbye, {userName}! Stay safe when using the internet.", ConsoleColor.Green);
                    isChatting = false;
                }
                else
                {
                    // So this is basically the helper for the user, so that the user can know what to ask about.
                    string botReply = botBrain.GetAnswerForUser(userInput, graphics);

                    Console.WriteLine("--------------------------------------------------");
                    graphics.TypewriterEffect(botReply, ConsoleColor.White);
                    Console.WriteLine("--------------------------------------------------");
                }
            }
        }
    }
}