using System;
using System.Media;
using System.IO;

namespace CyberBotPart1
{
    public class AudioManager
    {
        public static void PlayVoiceGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "greeting.wav");

                if (File.Exists(path))
                {
                    using (SoundPlayer player = new SoundPlayer(path))
                    {
                        player.PlaySync();
                    }
                    Console.WriteLine("🔊 Welcome message played!");
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ greeting.wav not found. Please add it to the Resources folder.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Could not play voice greeting: {ex.Message}");
            }
        }
    }
}