using System;

namespace CyberBotPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play voice greeting
            AudioManager.PlayVoiceGreeting();

            Console.Title = "Cybersecurity Awareness Bot";
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Display ASCII Art Logo
            DisplayLogo();

            // Ask for user's name
            Console.Write("❓ What is your name? ");
            Console.ForegroundColor = ConsoleColor.White;
            string userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("❓ Please enter a valid name: ");
                userName = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n🤖 Nice to meet you, {userName}!");

            ResponseManager.ShowHelp();

            // Main chat loop
            string userInput;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n{userName}: ");
                userInput = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("🤖 I didn't catch that. Please say something.");
                    continue;
                }

                if (userInput == "exit" || userInput == "quit" || userInput == "bye")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"\n🤖 Goodbye {userName}! Stay safe online! 👋");
                    break;
                }

                if (userInput == "help")
                {
                    ResponseManager.ShowHelp();
                    continue;
                }

                // Process responses
                ProcessInput(userInput, userName);

            } while (true);
        }

        static void DisplayLogo()
        {
            Console.WriteLine(@"
    ╔══════════════════════════════════════════════════════╗
    ║     CYBERSECURITY AWARENESS CHATBOT                  ║
    ╚══════════════════════════════════════════════════════╝
");
            Console.ResetColor();
            Console.WriteLine("🤖 I'm here to help you stay safe online.\n");
        }

        static void ProcessInput(string input, string userName)
        {
            if (input.Contains("how are you"))
            {
                Console.WriteLine("🤖 I'm functioning well. Thank you for asking!");
            }
            else if (input.Contains("purpose") || input.Contains("what can you do"))
            {
                Console.WriteLine("🤖 I can help you learn about cybersecurity topics like passwords, phishing, privacy, and safe browsing.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine($"🤖 {ResponseManager.GetRandomPasswordTip()}");
            }
            else if (input.Contains("phish") || input.Contains("scam"))
            {
                Console.WriteLine($"🤖 {ResponseManager.GetRandomPhishingTip()}");
            }
            else if (input.Contains("privacy"))
            {
                Console.WriteLine("🤖 Protect your privacy by using strong passwords, enabling two-factor authentication, and being careful what you share on social media.");
            }
            else if (input.Contains("browsing") || input.Contains("browser"))
            {
                Console.WriteLine("🤖 Always check for HTTPS in website addresses. Avoid clicking suspicious links and keep your browser updated.");
            }
            else if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
            {
                Console.WriteLine($"🤖 Hello {userName}! How can I help you today?");
            }
            else if (input.Contains("another tip") || input.Contains("tell me more"))
            {
                Console.WriteLine($"🤖 {ResponseManager.GetRandomGeneralTip()}");
            }
            else
            {
                Console.WriteLine("🤖 I didn't understand that. Try asking about passwords, phishing, or privacy. Type 'help' for options.");
            }
        }
    }
}