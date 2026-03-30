using System;
using System.Collections.Generic;
using System.Text;

namespace Part1_CyberChatBot
{
    internal class Responses
    {
        // used a parallel array to store the conversation, between the user and the bot.
        public string[] ConversationKeys;
        public string[] ConversationValues;

        public void LoadResponses()
        {
            // Responses that the user will get as they are asking the bot questions about the topics and about itself, to make the bot feel more engaging.
            ConversationKeys = new string[]
            {
                "how are you",
                "what's your purpose",
                "what can i ask you about"
            };

            ConversationValues = new string[]
            {
                "I am a robot so i h have no emeotions. But to answer your question, im happy to help you. Ready to learn?",
                "My purpose is to teach people on cybersecurity and help them stay safe online.",
                "You can ask me about many things! Type 'topics' to see the full list."
            };
        }

        // Returns the matching conversation response, or null if no match is found.
        public string GetConversationResponse(string lowerInput)
        {
            for (int i = 0; i < ConversationKeys.Length; i++)
            {
                if (lowerInput.Contains(ConversationKeys[i]))
                {
                    return ConversationValues[i];
                }
            }

            return null;
        }
    }
}