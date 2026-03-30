using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace Part1_CyberChatBot
{
    internal class UIHelper
    {
        // created a method to play the voice greeting for when the app starts.
        public void PlayVoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Greeting.wav");
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
    }
}