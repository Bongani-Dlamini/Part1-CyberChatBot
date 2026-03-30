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
    }
}
