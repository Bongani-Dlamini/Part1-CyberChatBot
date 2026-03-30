using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading; // Added this for Thread.Sleep

namespace Part1_CyberChatBot
{
    internal class UIHelper
    {
        // created a method to play the voice greeting for when the app starts.
        public void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Greeting.wav"); // Reference: CloudConvert, n.d. - MP4 to WAV Converter: https://cloudconvert.com/mp4-to-wav
                player.Play();
            }
            catch (Exception)
            {
                Console.WriteLine("Audio file 'Greeting.wav' not found.");
            }
        }

        // This is the ascii logo.
        public void ShowAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  ____       _               ____ _           _   ____        _                                                                           ║");
            Console.WriteLine("║ / ___| ___ | |__   ___ _ __/ ___| |__   __ _| |_ | __ )  ___ | |_                                                                             ║");
            Console.WriteLine("║| |    / _ \\| '_ \\ / _ \\ '__| |   | '_ \\ / _` | __||  _ \\ / _ \\| __|                     ║");
            Console.WriteLine("║| |___| (_) | |_) |  __/ |  | |___| | | | (_| | |_ | |_) | (_) | |_                                                                       ║");
            Console.WriteLine("║ \\____|\\___/|_.__/ \\___|_|   \\____|_| |_|\\__,_|\\__||____/ \\___/ \\__|                                                                     ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.ResetColor();
            Console.WriteLine();
        }

        // The typewriter effect method i created will be used for all the bots responses, so the user can feel more engaged.
        public void TypewriterEffect(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char letter in text)
            {
                Console.Write(letter);
                // Reference: (GeeksforGeeks, 2023) - Thread.Sleep Method: https://www.geeksforgeeks.org/c-sharp-thread-sleep-method/
                Thread.Sleep(30); // what this does is that is that its adds a small delay for each letter that will be printed when the app is running.
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}